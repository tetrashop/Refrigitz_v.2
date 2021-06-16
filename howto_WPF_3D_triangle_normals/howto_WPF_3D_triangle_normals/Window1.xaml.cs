//#define SURFACE2

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using WindowsApplication1;
using OpenCL;
using howto_WPF_3D_triangle_normalsuser;

namespace howto_WPF_3D_triangle_normals
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    //Write to File.
                    File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString());
                }
            }
#pragma warning disable CS0168 // The variable 't' is declared but never used
            catch (Exception t) { }
#pragma warning restore CS0168 // The variable 't' is declared but never used
        }
        public Window1()
        {
            InitializeComponent();
        }
        WindowsApplication1.Form1 gr = null;
        // The main object model group.
        private Model3DGroup MainModel3Dgroup = new Model3DGroup();


        // The camera.
        private PerspectiveCamera TheCamera;

        // The camera's current location.
        private double CameraPhi = Math.PI / 6.0;       // 30 degrees
        private double CameraTheta = Math.PI / 6.0;     // 30 degrees
#if SURFACE2
        private double CameraR = 3.0;
#else
        private double CameraR = 13.0;
#endif

        // The change in CameraPhi when you press the up and down arrows.
        private const double CameraDPhi = 0.1;

        // The change in CameraTheta when you press the left and right arrows.
        private const double CameraDTheta = 0.1;

        // The change in CameraR when you press + or -.
        private const double CameraDR = 0.1;

        // The surface's model.
        private GeometryModel3D SurfaceModel;

        // The wireframe's model.
        private GeometryModel3D WireframeModel;

        // The normals model.
        private GeometryModel3D NormalsModel;

        // Create the scene.
        // MainViewport is the Viewport3D defined
        // in the XAML code that displays everything.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Give the camera its initial position.
            TheCamera = new PerspectiveCamera();
            TheCamera.FieldOfView = 60;
            MainViewport.Camera = TheCamera;
            PositionCamera();

            // Define lights.
            DefineLights();

            // Create the model.
            //DefineModel(MainModel3Dgroup);

            // Add the group of models to a ModelVisual3D.
            ModelVisual3D model_visual = new ModelVisual3D();
            model_visual.Content = MainModel3Dgroup;

            // Display the main visual in the viewportt.
            MainViewport.Children.Add(model_visual);
        }

        // Define the lights.
        private void DefineLights()
        {
            AmbientLight ambient_light = new AmbientLight(Colors.Gray);
            DirectionalLight directional_light =
                new DirectionalLight(Colors.Gray, new Vector3D(-1.0, -3.0, -2.0));
            MainModel3Dgroup.Children.Add(ambient_light);
            MainModel3Dgroup.Children.Add(directional_light);
        }

        // Add the model to the Model3DGroup.
        private void DefineModel(Model3DGroup model_group)
        {
            // Make a mesh to hold the surface.
            MeshGeometry3D mesh = new MeshGeometry3D();

            // Make the surface's points and triangles.
#if SURFACE2
            const double xmin = -1.5;
            const double xmax = 1.5;
            const double dx = 0.3;
            const double zmin = -1.5;
            const double zmax = 1.5;
            const double dz = 0.3;
#else
            const double xmin = -5;
            const double xmax = 5;
            const double dx = 1;
            const double zmin = -5;
            const double zmax = 5;
            const double dz = 1;
#endif
            for (double x = xmin; x <= xmax - dx; x += dx)
            {
                for (double z = zmin; z <= zmax - dz; z += dx)
                {
                    // Make points at the corners of the surface
                    // over (x, z) - (x + dx, z + dz).
                    Point3D p00 = new Point3D(x, F(x, z), z);
                    Point3D p10 = new Point3D(x + dx, F(x + dx, z), z);
                    Point3D p01 = new Point3D(x, F(x, z + dz), z + dz);
                    Point3D p11 = new Point3D(x + dx, F(x + dx, z + dz), z + dz);

                    // Add the triangles.
                    AddTriangle(mesh, p00, p01, p11);
                    AddTriangle(mesh, p00, p11, p10);
                }
            }
            Console.WriteLine("Surface: ");
            Console.WriteLine("    " + mesh.Positions.Count + " points");
            Console.WriteLine("    " + mesh.TriangleIndices.Count / 3 + " triangles");
            Console.WriteLine();

            // Make the surface's material using a solid green brush.
            DiffuseMaterial surface_material = new DiffuseMaterial(Brushes.LightGreen);

            // Make the surface's model.
            SurfaceModel = new GeometryModel3D(mesh, surface_material);

            // Make the surface visible from both sides.
            SurfaceModel.BackMaterial = surface_material;

            // Add the model to the model groups.
            model_group.Children.Add(SurfaceModel);

            // Make a wireframe.
            double thickness = 0.03;
#if SURFACE2
            thickness = 0.01
#endif
            MeshGeometry3D wireframe = mesh.ToWireframe(thickness);
            DiffuseMaterial wireframe_material = new DiffuseMaterial(Brushes.Red);
            WireframeModel = new GeometryModel3D(wireframe, wireframe_material);
            model_group.Children.Add(WireframeModel);
            Console.WriteLine("Wireframe: ");
            Console.WriteLine("    " + wireframe.Positions.Count + " points");
            Console.WriteLine("    " + wireframe.TriangleIndices.Count / 3 + " triangles");
            Console.WriteLine();

            // Make the normals.
            MeshGeometry3D normals = mesh.ToTriangleNormals(0.5, thickness);
            DiffuseMaterial normals_material = new DiffuseMaterial(Brushes.Blue);
            NormalsModel = new GeometryModel3D(normals, normals_material);
            model_group.Children.Add(NormalsModel);
            Console.WriteLine("Normals: ");
            Console.WriteLine("    " + normals.Positions.Count + " points");
            Console.WriteLine("    " + normals.TriangleIndices.Count / 3 + " triangles");
            Console.WriteLine();
        }

        // The function that defines the surface we are drawing.
        private double F(double x, double z)
        {
#if SURFACE2
            const double two_pi = 2 * 3.14159265;
            double r2 = x * x + z * z;
            double r = Math.Sqrt(r2);
            double theta = Math.Atan2(z, x);
            return Math.Exp(-r2) * Math.Sin(two_pi * r) * Math.Cos(3 * theta);
#else
            double r2 = x * x + z * z;
            return 8 * Math.Cos(r2 / 2) / (2 + r2);
#endif
        }

        // Add a triangle to the indicated mesh.
        // If the triangle's points already exist, reuse them.
        private void AddTriangle(MeshGeometry3D mesh, Point3D point1, Point3D point2, Point3D point3)
        {
            object o = new object();
            lock (o)
            {
                // Get the points' indices.
                int index1 = AddPoint(mesh.Positions, point1);
                int index2 = AddPoint(mesh.Positions, point2);
                int index3 = AddPoint(mesh.Positions, point3);

                // Create the triangle.
                mesh.TriangleIndices.Add(index1);
                mesh.TriangleIndices.Add(index2);
                mesh.TriangleIndices.Add(index3);
            }
        }

        // A dictionary to hold points for fast lookup.
        private Dictionary<Point3D, int> PointDictionary =
            new Dictionary<Point3D, int>();

        // If the point already exists, return its index.
        // Otherwise create the point and return its new index.
        private int AddPoint(Point3DCollection points, Point3D point)
        {
            // If the point is in the point dictionary,
            // return its saved index.
            if (PointDictionary.ContainsKey(point))
                return PointDictionary[point];

            // We didn't find the point. Create it.
            points.Add(point);
            PointDictionary.Add(point, points.Count - 1);
            return points.Count - 1;
        }

        // Adjust the camera's position.
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    CameraPhi += CameraDPhi;
                    if (CameraPhi > Math.PI / 2.0) CameraPhi = Math.PI / 2.0;
                    break;
                case Key.Down:
                    CameraPhi -= CameraDPhi;
                    if (CameraPhi < -Math.PI / 2.0) CameraPhi = -Math.PI / 2.0;
                    break;
                case Key.Left:
                    CameraTheta += CameraDTheta;
                    break;
                case Key.Right:
                    CameraTheta -= CameraDTheta;
                    break;
                case Key.Add:
                case Key.OemPlus:
                    CameraR -= CameraDR;
                    if (CameraR < CameraDR) CameraR = CameraDR;
                    break;
                case Key.Subtract:
                case Key.OemMinus:
                    CameraR += CameraDR;
                    break;
            }

            // Update the camera's position.
            PositionCamera();
        }

        // Position the camera.
        private void PositionCamera()
        {
            // Calculate the camera's position in Cartesian coordinates.
            double y = CameraR * Math.Sin(CameraPhi);
            double hyp = CameraR * Math.Cos(CameraPhi);
            double x = hyp * Math.Cos(CameraTheta);
            double z = hyp * Math.Sin(CameraTheta);
            TheCamera.Position = new Point3D(x, y, z);

            // Look toward the origin.
            TheCamera.LookDirection = new Vector3D(-x, -y, -z);

            // Set the Up direction.
            TheCamera.UpDirection = new Vector3D(0, 1, 0);

            // Console.WriteLine("Camera.Position: (" + x + ", " + y + ", " + z + ")");
        }

        // Show and hide the appropriate GeometryModel3Ds.
        private void chkContents_Click(object sender, RoutedEventArgs e)
        {
            // Remove the GeometryModel3Ds.
            for (int i = MainModel3Dgroup.Children.Count - 1; i >= 0; i--)
            {
                if (MainModel3Dgroup.Children[i] is GeometryModel3D)
                    MainModel3Dgroup.Children.RemoveAt(i);
            }

            // Add the selected GeometryModel3Ds.
            if ((SurfaceModel != null) && ((bool)chkSurface.IsChecked))
                MainModel3Dgroup.Children.Add(SurfaceModel);
            if ((WireframeModel != null) && ((bool)chkWireframe.IsChecked))
                MainModel3Dgroup.Children.Add(WireframeModel);
            if ((NormalsModel != null) && ((bool)chkNormals.IsChecked))
                MainModel3Dgroup.Children.Add(NormalsModel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gr = new Form1();
            WindowInteropHelper wih = new WindowInteropHelper(this);
            wih.Owner = gr.Handle;
            gr.Show();
        }
        bool exist(Point3D ss, List<List<Point3D>> d)
        {
            if (d.Count == 0)
                return false;

            for (int i = 0; i < d.Count; i++)
            {
                for (int j = 0; j < d[i].Count; j++)
                {

                    if (ss.X == d[i][j].X && ss.Y == d[i][j].Y && ss.Z == d[i][j].Z)
                        return true;
                }
            }
            return false;
        }

        bool exist(Point3D ss, List<Point3D> d)
        {
            if (d.Count == 0)
                return false;
            for (int i = 0; i < d.Count; i++)
            {
                if (ss.X == d[i].X && ss.Y == d[i].Y && ss.Z == d[i].Z)
                    return true;
            }
            return false;
        }
        bool exist(Point3D ss, Point3D d)
        {

            if (ss.X == d.X && ss.Y == d.Y && ss.Z == d.Z)
                return true;
            return false;
        }
        bool exist(Point3D[] ss, List<Point3D[]> d)
        {
            object o = new object();
            lock (o)
            {
                if (d.Count == 0)
                    return false;
                for (int i = 0; i < d.Count; i++)
                {
                    if (ss[0].X == d[i][0].X && ss[0].Y == d[i][0].Y && ss[0].Z == d[i][0].Z)
                    {
                        if (ss[1].X == d[i][1].X && ss[1].Y == d[i][1].Y && ss[1].Z == d[i][1].Z)
                        {
                            if (ss[2].X == d[i][2].X && ss[2].Y == d[i][2].Y && ss[2].Z == d[i][2].Z)
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }
        double minraddpoints(List<Point3D> p0)
        {
            double r = double.MaxValue;
            for (int i = 0; i < p0.Count; i++)
            {
                for (int j = 0; j < p0.Count; j++)
                {

                    double a = Math.Sqrt((p0[i].X - p0[j].X) * (p0[i].X - p0[j].X) + (p0[i].Y - p0[j].Y) * (p0[i].Y - p0[j].Y) + (p0[i].Z - p0[j].Z) * (p0[i].Z - p0[j].Z));

                    if (a < r && a != 0)
                        r = a;
                }
            }
            return r;
        }
        bool IsNeigbour(List<double[]> sall, List<Point3D> pall, Point3D p0, Point3D p1)
        {
            int siall = pall.IndexOf(p1);
            int all = pall.IndexOf(p0);
            if (all >= 0)
            {
                double i = 0;
                double j = 0;
                if (all < sall.Count)
                {
                    i = (double)sall[all][0];
                    j = (double)sall[all][1];
                    if (i >= 0 && j >= 0 && siall >= 0 && siall < sall.Count)
                    {
                        double mountsi = (double)sall[siall][0];
                        double mountsj = (double)sall[siall][1];
                        /*double minX = minGetListX(pall);
                        double minY = minGetListY(pall);
                        double maxX = maxGetListX(pall);
                        double maxY = maxGetListY(pall);*/
                        return IsNeigbourChild(mountsi, mountsj, sall, siall, i, j);
                    }
                }
            }
            return true;
        }

        bool IsNeigbourChild(double mountsi, double mountsj, List<double[]> sall, int siall, double i, double j)
        {
            bool Is = false;
            if (i < 1 || j > 1 || i > gr.a.cx - 1 || j > gr.a.cyp0 - 1)
                return Is;
            if (mountsi == i && mountsj == j)
            {
                Is = true;
            }
            if (sall[siall][3] == (i - 1) && sall[siall][4] == (j))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i - 1, j);
            }

            if (Is)
                return Is;

            if (sall[siall][6] == (i + 1) && sall[siall][7] == (j))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i + 1, j);
            }

            if (Is)
                return Is;

            if (sall[siall][9] == (i) && sall[siall][10] == (j - 1))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i, j - 1);
            }

            if (Is)
                return Is;

            if (sall[siall][12] == (i) && sall[siall][13] == (j + 1))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i, j + 1);
            }

            if (Is)
                return Is;

            if (sall[siall][15] == (i - 1) && sall[siall][16] == (j - 1))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i - 1, j - 1);
            }

            if (Is)
                return Is;

            if (sall[siall][18] == (i - 1) && sall[siall][19] == (j + 1))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i - 1, j + 1);
            }

            if (Is)
                return Is;

            if (sall[siall][21] == (i + 1) && sall[siall][22] == (j - 1))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i + 1, j - 1);
            }

            if (Is)
                return Is;

            if (sall[siall][24] == (i + 1) && sall[siall][25] == (j + 1))
            {
                Is = Is || IsNeigbourChild(mountsi, mountsj, sall, siall, i + 1, j + 1);
            }
            return Is;
        }
        void CtreatPoints(ref List<Point3D> PointsAddp0, List<Point3D> PointsAddp1, ref List<double[]> PointsAddp0Conected, ref List<double[]> PointsAddp1Conected)
        {
            for (int i = 0; i < gr.a.cx; i++)
            {
                for (int j = 0; j < gr.a.cyp0; j++)
                {
                    if (gr.a.c[i, j, 0] != 0 || gr.a.c[i, j, 1] != 0 || gr.a.c[i, j, 2] != 0)
                    {
                        Point3D s = new Point3D(i, j, (gr.a.c[i, j, 0] + gr.a.c[i, j, 1] + gr.a.c[i, j, 2]) / 3);
                        if (!exist(s, PointsAddp0))

                            PointsAddp0.Add(s);
                        PointsAddp0Conected.Add(gr.a.st[i][j]);
                    }
                }
            }
            for (int i = 0; i < gr.a.cx; i++)
            {
                for (int j = gr.a.cyp0; j < gr.a.cyp1; j++)
                {
                    if (gr.a.c[i, j, 0] != 0 || gr.a.c[i, j, 1] != 0 || gr.a.c[i, j, 2] != 0)
                    {
                        Point3D s = new Point3D(i, j, (gr.a.c[i, j, 0] + gr.a.c[i, j, 1] + gr.a.c[i, j, 2]) / 3);
                        PointsAddp1.Add(s);
                        PointsAddp1Conected.Add(gr.a.st[i][j]);
                    }
                }
            }

        }
        void reductFirst(ref List<Point3D> PointsAddp0, List<Point3D> PointsAddp1, ref List<double[]> PointsAddp0Conected, ref List<double[]> PointsAddp1Conected, double minrp0, double minrp1)
        {
            if (PointsAddp0.Count > 35 || PointsAddp1.Count > 35)
            {

                List<Point3D> xxxp0 = new List<Point3D>();

                List<Point3D> xxxp1 = new List<Point3D>();

                List<double[]> xxxp0C = new List<double[]>();

                List<double[]> xxxp1C = new List<double[]>();

                int f = (new Triangle()).reduceCountOfpoints(ref PointsAddp0, ref PointsAddp0Conected, minrp0 * 2, 35.0 / (double)PointsAddp0.Count, ref xxxp0, ref xxxp0C, System.Convert.ToDouble(gr.textBox1.Text));
                f = f + (new Triangle()).reduceCountOfpoints(ref PointsAddp1, ref PointsAddp1Conected, minrp1 * 2, 35.0 / (double)PointsAddp1.Count, ref xxxp1, ref xxxp1C, System.Convert.ToDouble(gr.textBox1.Text));
                if (xxxp0.Count > 1)
                {
                    PointsAddp0 = xxxp0;
                }
                if (xxxp1.Count > 1)
                {
                    PointsAddp1 = xxxp1;
                }
                MessageBox.Show("reduced...p0! " + PointsAddp0.Count.ToString() + " points." + "reduced...p1! " + PointsAddp1.Count.ToString() + " points.");

            }

        }
        void reductionSecond(ref List<Point3D> PointsAddp0, ref List<double[]> PointsAddp0Conected, ref List<Point3D> xxxp00, ref List<double[]> xxxp00C, double minrp)
        {
            int ff = (new Triangle()).reduceCountOfpoints(ref PointsAddp0, ref PointsAddp0Conected, minrp * 2, 35.0 / (double)PointsAddp0.Count, ref xxxp00, ref xxxp00C, System.Convert.ToDouble(gr.textBox1.Text) //System.Convert.ToDouble(gr.textBox1.Text) / 3
                                      /// (minrp / minrp0)
                                      );
            if (xxxp00.Count > 1)
            {
                PointsAddp0 = xxxp00;
                PointsAddp0Conected = xxxp00C;
                MessageBox.Show("reduced...p0! " + PointsAddp0.Count.ToString() + " points.");
            }
            else MessageBox.Show("no reductio p0! " + PointsAddp0.Count.ToString());

        }
        void DrawTriangle(List<Point3D> PointsAdd, List<Point3D> PointsAddp, double max, List<double[]> PointsAddpConected, ref List<Point3D> dd, ref List<Point3D[]> d, ref MeshGeometry3D mesh)
        {
            double x= PointsAdd.Count;;
            for (int i = 0; i < PointsAdd.Count; i++)
            {
                for (int j = 0; j < PointsAdd.Count; j++)
                {//float[,,] cc = new float[(maxr - minr + 1), (maxteta - minteta + 1), 3];
                    for (int k = 0; k < PointsAdd.Count; k++)
                    {
                        object o = new object();
                        lock (o)
                        {
                            double ind = ((i + 1) * x + (j + 1)) * x + (k + 1);
                            za.Content = ((int)((ind / max) * 100)).ToString() + "%";
                            za.InvalidateVisual();
                            if ((new Triangle()).boundry(i, j, k))
                                continue;

                            Point3D[] ss = new Point3D[3];
                            ss[0] = PointsAdd[i];
                            ss[1] = PointsAdd[j];
                            ss[2] = PointsAdd[k];
                            ss =ImprovmentSort.Do(ss);
                            //if (!(new Triangle()).distancesaticfied(ss[0], ss[1], ss[2], minr))
                            //continue;
                            if (!exist(ss, d))
                            {
                                /*if (!IsNeigbour(PointsAddpConected, PointsAddp, ss[0], ss[1]))
                                    continue;
                                if (!IsNeigbour(PointsAddpConected, PointsAddp, ss[0], ss[2]))
                                    continue;
                                if (!IsNeigbour(PointsAddpConected, PointsAddp, ss[1], ss[2]))
                                    continue;*/
                                bool s = true;
                                var outputn = Task.Factory.StartNew(() =>
                                {

                                    Parallel.Invoke(() =>
                                    {
                                        s = s && IsNeigbour(PointsAddpConected, PointsAddp, ss[0], ss[1]);
                                    }, () =>
                                    {
                                        s = s && IsNeigbour(PointsAddpConected, PointsAddp, ss[0], ss[2]);
                                    }, () =>
                                    {

                                        s = s && IsNeigbour(PointsAddpConected, PointsAddp, ss[1], ss[2]);
                                    });
                                });
                                outputn.Wait();
                                if (!s)
                                    continue;

                                d.Add(ss);
                                if ((new Triangle()).externalMuliszerotow(ss[0], ss[1], ss[2], PointsAdd, dd) == 0)
                                {
                                    dd.Add(ss[0]);
                                    dd.Add(ss[1]);
                                    dd.Add(ss[2]);
                                    AddTriangle(mesh, ss[0], ss[1], ss[2]);
                                }
                            }

                        }
                    }
                }
            }

        }
        public static class LockHolder
        {
            public static object Lock = new object();
        }
        void DrawTriangleParallel(List<Point3D> PointsAdd, List<Point3D> PointsAddp, double max, List<double[]> PointsAddpConected, List<Point3D> dd, List<Point3D[]> d, MeshGeometry3D mesh)
        {
            double x = PointsAdd.Count; ;
            var output = Task.Factory.StartNew(() =>
            {

                ParallelOptions po = new ParallelOptions(); po.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, PointsAdd.Count, i =>
                {

                    ParallelOptions poo = new ParallelOptions(); poo.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, PointsAdd.Count, j =>
                    {//float[,,] cc = new float[(maxr - minr + 1), (maxteta - minteta + 1), 3];
                        ParallelOptions ppoio = new ParallelOptions(); ppoio.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount; Parallel.For(0, PointsAdd.Count, k =>
                        {
                            object o = new object();
                            lock (o)
                            {
                                double ind = ((i + 1) * x + (j + 1)) * x + (k + 1);

                                /*  lock (LockHolder.Lock)
                                  {
                                      za.Content = ((int)((ind / max) * 100)).ToString() + "%";                                      
                                  }*/
                                if ((new Triangle()).boundry(i, j, k))
                                    return;

                                Point3D[] ss = new Point3D[3];
                                ss[0] = PointsAdd[i];
                                ss[1] = PointsAdd[j];
                                ss[2] = PointsAdd[k];
                                ss =ImprovmentSort.Do(ss);
                                //if (!(new Triangle()).distancesaticfied(ss[0], ss[1], ss[2], minr))
                                //continue;

                                bool n = true;
                                Dispatcher.Invoke(() =>
                                {
                                    n = exist(ss, d);
                                });
                                if (!n)
                                {
                                    d.Add(ss);
                                    if ((new Triangle()).externalMuliszerotow(ss[0], ss[1], ss[2], PointsAdd, dd) == 0)
                                    {
                                        bool s = true;
                                        var outputn = Task.Factory.StartNew(() =>
                                        {

                                            Parallel.Invoke(() =>
                                            {
                                                s = s && IsNeigbour(PointsAddpConected, PointsAddp, ss[0], ss[1]);
                                            }, () =>
                                             {
                                                 s = s && IsNeigbour(PointsAddpConected, PointsAddp, ss[0], ss[2]);
                                             }, () =>
                                             {

                                                 s = s && IsNeigbour(PointsAddpConected, PointsAddp, ss[1], ss[2]);
                                             });
                                        });
                                        outputn.Wait();
                                        if (!s)
                                            return;
                                        dd.Add(ss[0]);
                                        dd.Add(ss[1]);
                                        dd.Add(ss[2]);
                                        var outputt = Task.Factory.StartNew(() =>
                                        {
                                            object b = new object();
                                            lock (b)
                                            {
                                                Dispatcher.Invoke(() =>
                                                {
                                                    AddTriangle(mesh, ss[0], ss[1], ss[2]);
                                                });
                                            }

                                        });
                                        //outputt.Wait();
                                    }
                                }

                            }
                        });
                    });
                });
            });
            output.Wait();

        }
       static string IsCreation3D
        {
            get
            {

                return @"
        kernel    void Creation3D(List<Point3D> PointsAddp0,List<Point3D> PointsAddp1,
            List<Point3D> PointsAddp
            ,List<double[]> PointsAddp0Conected,List<double[]> PointsAddpConected,
            List<double[]> PointsAddp1Conected
             ,global  double* minrp0,global  double* minrp1,global  double* minrp,List<Point3D> xxxp00,List<double[]> xxxp00C 
        MeshGeometry3D* mesh,global  Model3DGroup* model_group,List<Point3D> PointsAdd,global  DiffuseMaterial* surface_material,global 
        double* thickness,global  MeshGeometry3D wireframe,global 
        DiffuseMaterial* wireframe_material,global  MeshGeometry3D* normals,global  DiffuseMaterial* normals_material,global  ModelVisual3D* model_visual ,global double* minr
            ,List<Point3D[]> d,List<Point3D> dd,global  double* max ,global int* A,global bool s,global  PerspectiveCamera* TheCamer,global  GeometryModel3D* SurfaceMode,global 
        GeometryModel3D* WireframeMode,global  Model3DGroup* MainModel3Dgrou,global  GeometryModel3D* NormalsMode)
        {

          //creation of target



                        CtreatPoints(ref PointsAddp0, PointsAddp1, ref PointsAddp0Conected, ref PointsAddp1Conected);



            addlist(PointsAddp, PointsAddp0, PointsAddp0Conected, PointsAddpConected);




                        if (PointsAddp0.Count >= 3 || PointsAddp1.Count >= 3)
                        {
                            //When is not strong
                            if (!s)
                            {
                    Strong(PointsAddp0, PointsAddp1,
            PointsAddp
           , PointsAddp0Conected, PointsAddpConected,
            PointsAddp1Conected
            , minrp0, minrp1, minrp);
                   }//else is strong
                            else
                            {
                                minrp = minraddpoints(PointsAddp0);

                                makeListExpand(ref PointsAddp0, ref PointsAddp, ref PointsAddp0Conected, ref PointsAddpConected, (int)minrp * (System.Convert.ToInt32(A))
                                    );

                                makeListFittness(ref PointsAddp0);
                            }
            // Give the camera its initial position.
            TheCamer = new PerspectiveCamera();
        TheCamer.FieldOfView = 60;
                            MainViewport.Camera = TheCamer;
                            PositionCamera();

        // Define lights.
        DefineLights();

        model_group = MainModel3Dgrou;



                            PointsAdd = PointsAddp0;

                            makeListCenteralized(ref PointsAdd);

        minr = minraddpoints(PointsAdd);
        d = new List<Point3D[]>();
                             dd = new List<Point3D>();
                             max = PointsAdd.Count* PointsAdd.Count * PointsAdd.Count;




        //DrawTriangleParallel(PointsAdd, PointsAddp, max, PointsAddpConected, dd, d, mesh);

        DrawTriangle(PointsAdd, PointsAddp, max, PointsAddpConected, ref dd, ref d, ref mesh);






        // Make a mesh to hold the surface.
    
                            // Make the surface's material using a solid green brush.
                            surface_material = new DiffuseMaterial(Brushes.LightGreen);

        // Make the surface's model.
        SurfaceMode = new GeometryModel3D(mesh, surface_material);

        // Make the surface visible from both sides.
        SurfaceMode.BackMaterial = surface_material;

                            // Add the model to the model groups.
                            model_group.Children.Add(SurfaceMode);

                            // Make a wireframe.

#if SURFACE2
            thickness = 0.01
#endif
                            wireframe = mesh.ToWireframe(thickness);
                            wireframe_material = new DiffuseMaterial(Brushes.Red);
        WireframeMode = new GeometryModel3D(wireframe, wireframe_material);
        model_group.Children.Add(WireframeMode);
               
                            // Make the normals.
                            normals = mesh.ToTriangleNormals(0.5, thickness);
                            normals_material = new DiffuseMaterial(Brushes.Blue);
        NormalsMode = new GeometryModel3D(normals, normals_material);
        model_group.Children.Add(NormalsMode);
                           
                            // Add the group of models to a ModelVisual3D.
                            model_visual = new ModelVisual3D();
        model_visual.Content = MainModel3Dgrou;

                            // Display the main visual in the viewportt.
                            MainViewport.Children.Add(model_visual);
                        }
                        // if (PointsAdd.Count > 0)
                        // Window_Loaded(sender, e);
                 

";
            }

        }
        void addlist(ref List<Point3D> PointsAddp, ref List<Point3D> PointsAddp0, ref List<double[]> PointsAddp0Conected, ref List<double[]> PointsAddpConected)
        {
            for (int y = 0; y < PointsAddp0.Count; y++)
                PointsAddp.Add(PointsAddp0[y]);
            for (int y = 0; y < PointsAddp0Conected.Count; y++)
                PointsAddpConected.Add(PointsAddp0Conected[y]);

        }
        void Strong(ref List<Point3D> PointsAddp0, ref List<Point3D> PointsAddp1,
            ref List<Point3D> PointsAddp
            , ref List<double[]> PointsAddp0Conected, ref List<double[]> PointsAddpConected,
            ref List<double[]> PointsAddp1Conected
             , double minrp0, double minrp1, double minrp, ref List<Point3D> xxxp00, ref List<double[]> xxxp00C, int A
            )
        {
            minrp0 = minraddpoints(PointsAddp0);
            minrp1 = minraddpoints(PointsAddp1);
            MessageBox.Show("Add capable...p0! " + PointsAddp0.Count.ToString() + " p1! " + PointsAddp1.Count.ToString() + " points. with minrp0 " + minrp0.ToString() + " with minrp1 " + minrp1.ToString());





            reductFirst(ref PointsAddp0, PointsAddp1, ref PointsAddp0Conected, ref PointsAddp1Conected, minrp0, minrp1);

            minrp = minraddpoints(PointsAddp0);

            makeListExpand(ref PointsAddp0, ref PointsAddp, ref PointsAddp0Conected, ref PointsAddpConected, (int)minrp * (System.Convert.ToInt32(A))
                );



            minrp = minraddpoints(PointsAddp0);
            MessageBox.Show("Add capable...p0! " + PointsAddp0.Count.ToString() + " points. with minrp0 " + minrp.ToString());
            if (PointsAddp0.Count > 35 || PointsAddp1.Count > 35)
            {
                reductionSecond(ref PointsAddp0, ref PointsAddp0Conected, ref xxxp00, ref xxxp00C, minrp);
            }
            makeListFittness(ref PointsAddp0);
            MessageBox.Show("begin draw! p0: " + PointsAddp0.Count + " points!");

        }
        void Creation3D(List<Point3D> PointsAddp0, List<Point3D> PointsAddp1,
            List<Point3D> PointsAddp
            , List<double[]> PointsAddp0Conected, List<double[]> PointsAddpConected,
            List<double[]> PointsAddp1Conected
             , double minrp0, double minrp1, double minrp, List<Point3D> xxxp00, List<double[]> xxxp00C,
        MeshGeometry3D mesh, Model3DGroup model_group, List<Point3D> PointsAdd, DiffuseMaterial surface_material,
        double thickness, MeshGeometry3D wireframe,
        DiffuseMaterial wireframe_material, MeshGeometry3D normals, DiffuseMaterial normals_material, ModelVisual3D model_visual ,double minr
            , List<Point3D[]> d, List<Point3D> dd, double max ,int A,bool s, PerspectiveCamera TheCamer, GeometryModel3D SurfaceMode,
        GeometryModel3D WireframeMode, Model3DGroup MainModel3Dgrou, GeometryModel3D NormalsMode)    {

          

                        //creation of target



                        CtreatPoints(ref PointsAddp0, PointsAddp1, ref PointsAddp0Conected, ref PointsAddp1Conected);



            addlist(ref PointsAddp, ref PointsAddp0,ref PointsAddp0Conected,ref PointsAddpConected);




                        if (PointsAddp0.Count >= 3 || PointsAddp1.Count >= 3)
                        {
                            //When is not strong
                            if (!s)
                            {
                    Strong(ref PointsAddp0, ref PointsAddp1,
            ref PointsAddp
           , ref PointsAddp0Conected, ref PointsAddpConected,
            ref PointsAddp1Conected
            , minrp0, minrp1, minrp, ref xxxp00, ref xxxp00C, A);
                   }//else is strong
                            else
                            {
                                minrp = minraddpoints(PointsAddp0);

                                makeListExpand(ref PointsAddp0, ref PointsAddp, ref PointsAddp0Conected, ref PointsAddpConected, (int)minrp * (System.Convert.ToInt32(A))
                                    );

                                makeListFittness(ref PointsAddp0);
                                MessageBox.Show("begin draw! p0: " + PointsAddp0.Count + " points!");
                            }
                            // Give the camera its initial position.
                            TheCamer = new PerspectiveCamera();
                            TheCamer.FieldOfView = 60;
                            MainViewport.Camera = TheCamer;
                            PositionCamera();

                            // Define lights.
                            DefineLights();

                            model_group = MainModel3Dgrou;



                            PointsAdd = PointsAddp0;

                            makeListCenteralized(ref PointsAdd);

                             minr = minraddpoints(PointsAdd);
                             d = new List<Point3D[]>();
                             dd = new List<Point3D>();
                             max = PointsAdd.Count * PointsAdd.Count * PointsAdd.Count;




                            //DrawTriangleParallel(PointsAdd, PointsAddp, max, PointsAddpConected, dd, d, mesh);

                            DrawTriangle(PointsAdd, PointsAddp, max, PointsAddpConected, ref dd, ref d, ref mesh);






                            // Make a mesh to hold the surface.
                            Console.WriteLine("Surface: ");
                            Console.WriteLine("    " + mesh.Positions.Count + " Points");
                            Console.WriteLine("    " + mesh.TriangleIndices.Count / 3 + " triangles");
                            Console.WriteLine();

                            // Make the surface's material using a solid green brush.
                            surface_material = new DiffuseMaterial(Brushes.LightGreen);

                            // Make the surface's model.
                            SurfaceMode = new GeometryModel3D(mesh, surface_material);

                            // Make the surface visible from both sides.
                            SurfaceMode.BackMaterial = surface_material;

                            // Add the model to the model groups.
                            model_group.Children.Add(SurfaceMode);

                            // Make a wireframe.

#if SURFACE2
            thickness = 0.01
#endif
                            wireframe = mesh.ToWireframe(thickness);
                            wireframe_material = new DiffuseMaterial(Brushes.Red);
                            WireframeMode = new GeometryModel3D(wireframe, wireframe_material);
                            model_group.Children.Add(WireframeMode);
                            Console.WriteLine("Wireframe: ");
                            Console.WriteLine("    " + wireframe.Positions.Count + " Points");
                            Console.WriteLine("    " + wireframe.TriangleIndices.Count / 3 + " triangles");
                            Console.WriteLine();

                            // Make the normals.
                            normals = mesh.ToTriangleNormals(0.5, thickness);
                            normals_material = new DiffuseMaterial(Brushes.Blue);
                            NormalsMode = new GeometryModel3D(normals, normals_material);
                            model_group.Children.Add(NormalsMode);
                            Console.WriteLine("Normals: ");
                            Console.WriteLine("    " + normals.Positions.Count + " Points");
                            Console.WriteLine("    " + normals.TriangleIndices.Count / 3 + " triangles");
                            Console.WriteLine();

                            // Add the group of models to a ModelVisual3D.
                            model_visual = new ModelVisual3D();
                            model_visual.Content = MainModel3Dgrou;

                            // Display the main visual in the viewportt.
                            MainViewport.Children.Add(model_visual);
                        }
                        // if (PointsAdd.Count > 0)
                        // Window_Loaded(sender, e);
                 

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (gr != null)
                {
                    if (gr.a != null)
                    {
                        if (gr.a._3DReady)
                        {


                            //list found of 3d PointsAdd
                   
                            if (GPU.IsChecked==true)
                            {

                                List<Point3D> PointsAddp0 = new List<Point3D>();
                                List<Point3D> PointsAddp1 = new List<Point3D>();
                                List<Point3D> PointsAddp = new List<Point3D>();
                                List<double[]> PointsAddp0Conected = new List<double[]>();
                                List<double[]> PointsAddpConected = new List<double[]>();
                                List<double[]> PointsAddp1Conected = new List<double[]>();

                                double minr = 0;
                                List<Point3D[]> d = new List<Point3D[]>();
                                List<Point3D> dd = new List<Point3D>();
                                double max = 0;

                                double minrp0 = 0, minrp1 = 0, minrp = 0;
                                List<Point3D> xxxp00 = new List<Point3D>();
                                List<double[]> xxxp00C = new List<double[]>();
                                List<Point3D> PointsAdd = null;

                                MeshGeometry3D mesh = new MeshGeometry3D();
                                Model3DGroup model_group = null;

                                DiffuseMaterial surface_material = null;
                                double thickness = 0.03;

                                MeshGeometry3D wireframe = null; ;
                                DiffuseMaterial wireframe_material = null;
                                MeshGeometry3D normals = null;
                                DiffuseMaterial normals_material = null;

                                ModelVisual3D model_visual = new ModelVisual3D();


                                MultiCL cl = new MultiCL();
                                //cl.ProgressChangedEvent += Cl_ProgressChangedEvent1;
                                cl.SetKernel(IsCreation3D, "Creation3D");
                                /*cl.SetKernel(IsCreation3D, "List");
                                cl.SetKernel(IsCreation3D, "PointsAddp0.Add");
                                cl.SetKernel(IsCreation3D, "PointsAddp1.Add");
                                cl.SetKernel(IsCreation3D, "List<Point3D>");
                                cl.SetKernel(IsCreation3D, "List<double[]>");
                                cl.SetKernel(IsCreation3D, "List<Point3D[]>");

                                cl.SetKernel(IsCreation3D, "PointsAddp0.Count");
                                cl.SetKernel(IsCreation3D, "PointsAddp1.Count");
                                 cl.SetKernel(IsCreation3D, "PointsAddp0Conected.Count");
                                cl.SetKernel(IsCreation3D, "d.Count");*/
                                cl.SetParameter(PointsAddp0, PointsAddp1, PointsAddp
                           , PointsAddp0Conected, PointsAddpConected, PointsAddp1Conected
                              , minrp0, minrp1, minrp, xxxp00, xxxp00C,
                           mesh, model_group, PointsAdd, surface_material,
                        thickness, wireframe,
                        wireframe_material, normals, normals_material, model_visual, minr, d, dd, max, System.Convert.ToInt32(gr.textBox1.Text), gr.Strong
                        , TheCamera, SurfaceModel,
             WireframeModel, MainModel3Dgroup, NormalsModel);
                                //cl.Invoke(0, Primes.Length, N
                            }
                            else
                            {/*
                                Creation3D(PointsAddp0, PointsAddp1, PointsAddp
                            , PointsAddp0Conected, PointsAddpConected, PointsAddp1Conected
                            , minrp0, minrp1, minrp, xxxp00, xxxp00C,
                            mesh, model_group, PointsAdd, surface_material,
                         thickness, wireframe,
                         wireframe_material, normals, normals_material, model_visual, minr, d, dd,max, System.Convert.ToInt32(gr.textBox1.Text), gr.Strong
                         , TheCamera, SurfaceModel,
             WireframeModel, MainModel3Dgroup, NormalsModel);*/
                                //creation of target
                                List<Point3D> PointsAddp0 = new List<Point3D>();
                                List<Point3D> PointsAddp1 = new List<Point3D>();
                                List<Point3D> PointsAddp = new List<Point3D>();
                                List<double[]> PointsAddp0Conected = new List<double[]>();
                                List<double[]> PointsAddpConected = new List<double[]>();
                                List<double[]> PointsAddp1Conected = new List<double[]>();

                                double minr = 0;
                                List<Point3D[]> d = new List<Point3D[]>();
                                List<Point3D> dd = new List<Point3D>();
                                double max = 0;

                                double minrp0 = 0, minrp1 = 0, minrp = 0;
                                List<Point3D> xxxp00 = new List<Point3D>();
                                List<double[]> xxxp00C = new List<double[]>();
                                List<Point3D> PointsAdd = null;

                                MeshGeometry3D mesh = new MeshGeometry3D();
                               
                                double thickness = 0.03;

                            
                           


                                CtreatPoints(ref PointsAddp0, PointsAddp1, ref PointsAddp0Conected, ref PointsAddp1Conected);



                                addlist(ref PointsAddp, ref PointsAddp0, ref PointsAddp0Conected, ref PointsAddpConected);




                                if (PointsAddp0.Count >= 3 || PointsAddp1.Count >= 3)
                                {
                                    //When is not strong
                                    if (!gr.Strong)
                                    {
                                        Strong(ref PointsAddp0, ref PointsAddp1,
                                ref PointsAddp
                               , ref PointsAddp0Conected, ref PointsAddpConected,
                                ref PointsAddp1Conected
                                , minrp0, minrp1, minrp, ref xxxp00, ref xxxp00C, System.Convert.ToInt32(gr.textBox1.Text));
                                    }//else is strong
                                    else
                                    {
                                        minrp = minraddpoints(PointsAddp0);

                                        makeListExpand(ref PointsAddp0, ref PointsAddp, ref PointsAddp0Conected, ref PointsAddpConected, (int)minrp * (System.Convert.ToInt32(gr.textBox1.Text))
                                            );

                                        makeListFittness(ref PointsAddp0);
                                        MessageBox.Show("begin draw! p0: " + PointsAddp0.Count + " points!");
                                    }
                                    // Give the camera its initial position.
                                    TheCamera = new PerspectiveCamera();
                                    TheCamera.FieldOfView = 60;
                                    MainViewport.Camera = TheCamera;
                                    PositionCamera();

                                    // Define lights.
                                    DefineLights();

                                    Model3DGroup model_group = MainModel3Dgroup;



                                    PointsAdd = PointsAddp0;

                                    makeListCenteralized(ref PointsAdd);

                                    minr = minraddpoints(PointsAdd);
                                    d = new List<Point3D[]>();
                                    dd = new List<Point3D>();
                                    max = PointsAdd.Count * PointsAdd.Count * PointsAdd.Count;




                                    //DrawTriangleParallel(PointsAdd, PointsAddp, max, PointsAddpConected, dd, d, mesh);

                                    DrawTriangle(PointsAdd, PointsAddp, max, PointsAddpConected, ref dd, ref d, ref mesh);






                                    // Make a mesh to hold the surface.
                                    Console.WriteLine("Surface: ");
                                    Console.WriteLine("    " + mesh.Positions.Count + " Points");
                                    Console.WriteLine("    " + mesh.TriangleIndices.Count / 3 + " triangles");
                                    Console.WriteLine();

                                    // Make the surface's material using a solid green brush.
                                    DiffuseMaterial surface_material = new DiffuseMaterial(Brushes.LightGreen);

                                    // Make the surface's model.
                                    SurfaceModel = new GeometryModel3D(mesh, surface_material);

                                    // Make the surface visible from both sides.
                                    SurfaceModel.BackMaterial = surface_material;

                                    // Add the model to the model groups.
                                    model_group.Children.Add(SurfaceModel);

                                    // Make a wireframe.

#if SURFACE2
            thickness = 0.01
#endif
                                    MeshGeometry3D wireframe = mesh.ToWireframe(thickness);
                                    DiffuseMaterial wireframe_material = new DiffuseMaterial(Brushes.Red);
                                    WireframeModel = new GeometryModel3D(wireframe, wireframe_material);
                                    model_group.Children.Add(WireframeModel);
                                    Console.WriteLine("Wireframe: ");
                                    Console.WriteLine("    " + wireframe.Positions.Count + " Points");
                                    Console.WriteLine("    " + wireframe.TriangleIndices.Count / 3 + " triangles");
                                    Console.WriteLine();

                                    // Make the normals.
                                    MeshGeometry3D normals = mesh.ToTriangleNormals(0.5, thickness);
                                    DiffuseMaterial normals_material = new DiffuseMaterial(Brushes.Blue);
                                    NormalsModel = new GeometryModel3D(normals, normals_material);
                                    model_group.Children.Add(NormalsModel);
                                    Console.WriteLine("Normals: ");
                                    Console.WriteLine("    " + normals.Positions.Count + " Points");
                                    Console.WriteLine("    " + normals.TriangleIndices.Count / 3 + " triangles");
                                    Console.WriteLine();

                                    // Add the group of models to a ModelVisual3D.
                                    ModelVisual3D model_visual =  new ModelVisual3D();
                                    model_visual.Content = MainModel3Dgroup;

                                    // Display the main visual in the viewportt.
                                    MainViewport.Children.Add(model_visual);
                                }
                                // if (PointsAdd.Count > 0)
                                // Window_Loaded(sender, e);


                            }
                        }
                    }
                }
            }
            catch (Exception t) { MessageBox.Show(t.ToString()); Log(t); }
        }

        public static void makeListCenteralized(ref List<Point3D> non)
        {
            double maxx = maxGetListX(non);
            double maxy = maxGetListY(non);
            double maxz = maxGetListZ(non);

            double minx = minGetListX(non);
            double miny = minGetListY(non);
            double minz = minGetListZ(non);

            double disx = minx + (maxx - minx) / 2;
            double disy = miny + (maxy - miny) / 2;
            double disz = minz + (maxz - minz) / 2;
            for (int i = 0; i < non.Count; i++)
            {
                non[i] = new Point3D(non[i].X - disx, non[i].Y - disy, non[i].Z - disz);
            }

        }
        public static void makeListFittness(ref List<Point3D> non)
        {
            /*  double maxx = maxGetListX(non);
              double maxy = maxGetListY(non);
              double maxz = maxGetListZ(non);

              double minx = minGetListX(non);
              double miny = minGetListY(non);
              double minz = minGetListZ(non);
            */
            double disx = 0.5;
            double disy = 0.5;
            double disz = 0.5;
            for (int i = 0; i < non.Count; i++)
            {
                non[i] = new Point3D(non[i].X * disx, non[i].Y * disy, non[i].Z * disz);
            }

        }
        static double getAlphaperStringOfIndependentvars(String ind, List<List<double[]>> p0, int c, int l, int i, int j, int k)
        {
            double a = 0;
            if (ind == "x")
            {
                a = (-1 *
                     (j * p0[c][l][1] + k * p0[c][l][2])) / p0[c][l][0];
            }
            if (ind == "y")
            {
                a = (-1 *
                     (i * p0[c][l][0] + k * p0[c][l][2])) / p0[c][l][1];

            }
            if (ind == "z")
            {
                a = (-1 *
                     (j * p0[c][l][1] + i * p0[c][l][0])) / p0[c][l][2];

            }
            return a;
        }
        static double[] SetneighboursSt(double i, double j, double minx, double miny, double maxx, double maxy, double minr, double amount)
        {
            double[] st = new double[18];

            if (i > minr && j > minr)
            {

                if (i < maxx - minr && j < maxy - minr)
                {


                    st[0] = i;
                    st[1] = j;
                    st[2] = amount;

                    st[3] = i - 1;
                    st[4] = j;
                    st[5] = amount;

                    st[6] = i + 1;
                    st[7] = j;
                    st[8] = amount;

                    st[9] = i;
                    st[10] = j - 1;
                    st[11] = amount;

                    st[12] = i;
                    st[13] = j + 1;
                    st[14] = amount;

                    st[15] = i - 1;
                    st[16] = j - 1;
                    st[17] = amount;

                    st[18] = i - 1;
                    st[19] = j + 1;
                    st[20] = amount;

                    st[21] = i + 1;
                    st[22] = j - 1;
                    st[23] = amount;

                    st[24] = i + 1;
                    st[25] = j + 1;
                    st[26] = amount;

                }
            }
            return st;
        }

        public static void makeListExpand(ref List<Point3D> non, ref List<Point3D> nonConst, ref List<double[]> nonCon, ref List<double[]> nonCons, int minr)
        {
            CurvedSystems addpoint0 = new CurvedSystems(non);
            List<List<double[]>> p0 = addpoint0.CreateQuficientofCurved();
            MessageBox.Show("queficients complete! p0: " + (p0 != null).ToString());
            double maxx = maxGetListX(non);
            double maxy = maxGetListY(non);
            double maxz = maxGetListZ(non);

            double minx = minGetListX(non);
            double miny = minGetListY(non);
            double minz = minGetListZ(non);

            double disx = -1 * (maxx - minx);
            double disy = -1 * (maxy - miny);
            double disz = -1 * (maxz - minz);

            MessageBox.Show("creation points: before non : " + non.Count.ToString());
            for (int c = 0; c < p0.Count; c++)
            {
                for (int l = 0; l < p0[c].Count; l++)
                {
                    for (int i = (int)disx; i < minx; i += minr)
                    {
                        for (int j = (int)disy; j < miny; j += minr)
                        {
                            for (int k = (int)disz; k < minz; k += minr)
                            {
                                Point3D x = new Point3D(getAlphaperStringOfIndependentvars("x", p0, c, l, i, j, k), getAlphaperStringOfIndependentvars("y", p0, c, l, i, j, k), getAlphaperStringOfIndependentvars("z", p0, c, l, i, j, k));
                                if ((!(x.X < minx || x.X > maxx)) && (!(x.Y < miny || x.Y > maxy)) && (!(x.Z < minz || x.Z > maxz))&&
                                    (!((new Triangle()).exist(x, nonConst))))
                                {
                                    //int f = non.IndexOf(addpoint0.qsystemlistaddpoints[c][l]);
                                    //nonCon.Add();(?)
                                    non.Add(x);
                                    nonConst.Add(x);
                                    nonCon.Add(SetneighboursSt(i, j, disx, disy, minx, miny, minr, x.Z));
                                    nonCons.Add(SetneighboursSt(i, j, disx, disy, minx, miny, minr, x.Z));

                                }

                            }

                        }
                    }
                }
            }

            /*for (int c = 0; c < p0.Count; c++)
             {
                 for (int l = 0; l < p0[c].Count; l++)
                 {
                     non.Add(new Point3D(p0[c][l][0] * addpoint0.qdddpointslist[c][l].X, p0[c][l][1] * addpoint0.qdddpointslist[c][l].Y, p0[c][l][2] * addpoint0.qdddpointslist[c][l].Z));
                 }
             }*/
            /* for (int c = 0; c < a.Count; c++)
             {
                 for (int l = 0; l < p0[c].Count; l++)
                 {
                     non.Add(new Point3D(p0[c][l][0] * addpoint0.qdddpointslist[c][l].X, p0[c][l][1] * addpoint0.qdddpointslist[c][l].Y, p0[c][l][2] * addpoint0.qdddpointslist[c][l].Z));
                 }
             }*/
            MessageBox.Show("add points complete! points: " + non.Count.ToString());
        }

        static double maxGetListX(List<Point3D> d)
        {
            int inex = -1;
            double max = float.MinValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (max < d[i].X)
                {
                    max = d[i].X;
                    inex = i;
                }
            }
            return d[inex].X;
        }
        static double maxGetListY(List<Point3D> d)
        {
            int inex = -1;
            double max = float.MinValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (max < d[i].Y)
                {
                    max = d[i].Y;
                    inex = i;
                }
            }
            return d[inex].Y;
        }
        static double maxGetListZ(List<Point3D> d)
        {
            int inex = -1;
            double max = float.MinValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (max < d[i].Z)
                {
                    max = d[i].Z;
                    inex = i;
                }
            }
            return d[inex].Z;
        }
        static double minGetListX(List<Point3D> d)
        {
            int inex = -1;
            double min = float.MaxValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (min > d[i].X)
                {
                    min = d[i].X;
                    inex = i;
                }
            }
            return d[inex].X;
        }
        static double minGetListY(List<Point3D> d)
        {
            int inex = -1;
            double min = float.MaxValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (min > d[i].X)
                {
                    min = d[i].X;
                    inex = i;
                }
            }
            return d[inex].Y;
        }
        static double minGetListZ(List<Point3D> d)
        {
            int inex = -1;
            double min = float.MaxValue;
            for (int i = 0; i < d.Count; i++)
            {
                if (min > d[i].Z)
                {
                    min = d[i].Z;
                    inex = i;
                }
            }
            return d[inex].Z;
        }
    }
}
