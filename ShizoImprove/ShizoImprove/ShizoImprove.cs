/**************************************************************************
 * CopyRight Ramin Edjlal 28 nov 2019 Tetra E-Commerce*********************
 * TetraShop.ir************************************************************
 * https://stackoverflow.com/questions/1701457/directory-delete-doesnt-work-access-denied-error-but-under-windows-explorer-it
 * ************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;

namespace ShizoImprove
{

    public class ShizoImprove
    {
        //Initiate All Files var
        public static List<string> AllFiles = new List<string>();
        //Al File Information
        FileInfo fi = null;
        DateTime created;
        DateTime Lastmodified;
        //for evry statistic files create info
        List<ShizoImprove> All = new List<ShizoImprove>();
        //retrive files and directories Constructor
        public ShizoImprove(String Root, bool Imp = false)
        {
            bool Do = false;
            if (AllFiles.Count == 0)
                Do = ParsePath(Root, Imp);
            if (Do && AllFiles.Count > 0)
            {
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    All.Add((new ShizoImprove(AllFiles[i])));
                    Do = All[i].FilesInfo(Root);
                    if (!Do)
                        return;
                }
            }
        }
        //retrive all files and sub directories in a list
        static bool ParsePath(string path, bool Imp)
        {
            try
            {

                //all subdirectories
                string[] SubDirs = Directory.GetDirectories(path);
                AllFiles.AddRange(SubDirs);

                if (Imp)
                {
                    for (int i = 0; i < AllFiles.Count; i++)
                    {
                        if (AllFiles[i].Contains("\\Improved"))
                        {
                            AllFiles.RemoveAt(i);
                        }
                    }
                }

                //Allfiles in path
                AllFiles.AddRange(Directory.GetFiles(path));
                //for each sub directory parse sub of subdirectories(recursive)
                foreach (string subdir in SubDirs)
                {
                    if (Imp && subdir.Contains("\\Improved"))
                        continue;
                    ParsePath(subdir, Imp);
                }
                return true;

            }
            catch (Exception t) { return false; }
            return true;
        }
        //retrive file information
        bool FilesInfo(String path)
        {
            try
            {
                fi = new FileInfo(path);
                created = fi.CreationTime;
                Lastmodified = fi.LastWriteTime;
            }
            catch (Exception t) { return false; }
            return true;
        }
        //When path is file return true
        bool IsFile(String Des)
        {
            //when contains
            if (Des.Contains("."))
            {
                //index
                int A = Des.IndexOf(".");
                //when exstence of remained
                if (A < Des.Length)
                {
                    //substring remained
                    string D = Des.Substring(A, Des.Length - A);
                    //when existence
                    if (D.Length > 0)
                        return true;
                }
            }
            return false;

        }
        //Imrove all date into one folder
        public bool FormShizoImprove(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicatore
                        progressBarWorking.Value = i;
                        //when contains project
                        if (AllFiles[i].Contains(Pro))
                        {
                            //index of to substring
                            String Des = AllFiles[i].Substring(AllFiles[i].IndexOf(Pro));
                            //create correct path
                            Des = "C:\\ShizoImprove\\" + Pro + "\\" + All[i].Lastmodified.ToLongDateString() + "\\" + Des;
                            //when
                            if (!IsFile(Des))
                            {
                                //create directory exitence condition
                                if (!Directory.Exists(Des))
                                    Directory.CreateDirectory(Des);
                            }
                            else
                            {
                                try
                                {
                                    //copy file
                                    //copy file when unexistence
                                    if (!File.Exists(AllFiles[i]))
                                        File.Copy(AllFiles[i], Des);
                                    else  //copy file on condition of Last modified
                                    {
                                        if ((new FileInfo(AllFiles[i])).LastWriteTime > (new FileInfo(Des)).LastWriteTime)
                                        {
                                            File.Delete(Des);
                                            File.Copy(AllFiles[i], Des);

                                        }

                                    }
                                }
                                catch (Exception t)
                                {
                                    // return false;
                                }
                            }
                        }


                    }
                    catch (Exception t) { }
                }

            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
        public bool FormShizoImproveActOnFileHistory(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicatore
                        progressBarWorking.Value = i;
                        //when contains project
                        if (AllFiles[i].Contains("("))
                        {
                            //index of to substring
                            String Des = AllFiles[i].Substring(0, AllFiles[i].IndexOf("("));
                            //create correct path
                            Des = "C:\\ShizoImprove\\" + Pro + "\\" + All[i].Lastmodified.ToLongDateString() + "\\" + Des;
                            //when
                            if (!IsFile(Des))
                            {
                                //create directory exitence condition
                                if (!Directory.Exists(Des))
                                    Directory.CreateDirectory(Des);
                            }
                            else
                            {
                                try
                                {
                                    //copy file when unexistence
                                    if (!File.Exists(AllFiles[i]))
                                        File.Copy(AllFiles[i], Des);
                                    else  //copy file on condition of Last modified
                                    {
                                        if ((new FileInfo(AllFiles[i])).LastWriteTime > (new FileInfo(Des)).LastWriteTime)
                                        {
                                            File.Delete(Des);
                                            File.Copy(AllFiles[i], Des);
                                            File.Delete(AllFiles[i]);
                                        }

                                    }
                                }
                                catch (Exception t)
                                {
                                    // return false;
                                }
                            }
                        }


                    }
                    catch (Exception t) { }
                }

            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
        void setAttributesNormal(DirectoryInfo dir)
        {
            foreach (var subDir in dir.GetDirectories())
                setAttributesNormal(subDir);
            foreach (var file in dir.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
            }
        }
        public bool FormShizoImproveClearCach(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicatore
                        progressBarWorking.Value = i;

                        if (!AllFiles[i].Contains("\\Improved"))
                        {
                            //when
                            if (!IsFile(AllFiles[i]))
                            {
                                //create directory exitence condition
                                try
                                {
                                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(AllFiles[i]);

                                    if (dir.Exists)
                                    {
                                        setAttributesNormal(dir);
                                        dir.Delete(true);
                                    }

                                }
                                catch (Exception t) { }
                            }
                            else
                            {
                                try
                                {
                                    //copy file
                                    if (File.Exists(AllFiles[i]))
                                        File.Delete(AllFiles[i]);
                                }
                                catch (Exception t)
                                {
                                    // return false;
                                }
                            }
                        }
                    }
                    catch (Exception t) { }
                }

            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
        //move date Last modified of set improved into improved folder
        public bool FormImprove(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all same same project path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicator
                        progressBarWorking.Value = i;
                        //when contains project
                        if (AllFiles[i].Contains(Pro))
                        {
                            //index of to substring
                            String Des = AllFiles[i].Substring(AllFiles[i].IndexOf(Pro));
                            //index of Last modified path and substring
                            for (int j = 1990; j <= DateTime.Now.Year; j++)
                            {
                                //when contains date
                                if (Des.Contains(j.ToString()))
                                {
                                    //substring
                                    int A = Des.IndexOf(j.ToString()) + 4;
                                    Des = Des.Substring(A, Des.Length - A);
                                }
                            }
                            //create correcte path
                            Des = "C:\\ShizoImprove\\Improved\\" + Pro + "\\" + Des;
                            //when
                            if (!IsFile(Des))
                            {
                                //create directory exitence condition
                                if (!Directory.Exists(Des))
                                    Directory.CreateDirectory(Des);
                            }
                            else
                            {
                                try
                                {
                                    //copy file when unexistence
                                    if (!File.Exists(Des))
                                        File.Copy(AllFiles[i], Des);
                                    else  //copy file on condition of Last modified
                                    {
                                        if ((new FileInfo(AllFiles[i])).LastWriteTime > (new FileInfo(Des)).LastWriteTime)
                                        {
                                            File.Delete(Des);
                                            File.Copy(AllFiles[i], Des);
                                        }

                                    }
                                }
                                catch (Exception t)
                                {
                                    //return false;
                                }
                            }
                        }
                    }
                    catch (Exception y)
                    {

                    }
                }
            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }


    }

    public class ShizoImproveFile
    {
        //Initiate All Files var
        public static List<string> AllFiles = new List<string>();
        //Al File Information
        FileInfo fi = null;
        DateTime created;
        DateTime Lastmodified;
        //for evry statistic files create info
        List<ShizoImproveFile> All = new List<ShizoImproveFile>();
        //retrive files and directories Constructor
        public ShizoImproveFile(String Root, bool Imp = false)
        {
            bool Do = false;
            if (AllFiles.Count == 0)
                Do = ParsePath(Root, Imp);
            if (Do && AllFiles.Count > 0)
            {
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    All.Add((new ShizoImproveFile(AllFiles[i])));
                    Do = All[i].FilesInfo(Root);
                    if (!Do)
                        return;
                }
            }
        }
        //retrive all files and sub directories in a list
        static bool ParsePath(string path, bool Imp)
        {
            try
            {

                //all subdirectories
                string[] SubDirs = Directory.GetDirectories(path);
                AllFiles.AddRange(SubDirs);

                if (Imp)
                {
                    for (int i = 0; i < AllFiles.Count; i++)
                    {
                        if (AllFiles[i].Contains("\\Improved"))
                        {
                            AllFiles.RemoveAt(i);
                        }
                    }
                }

                //Allfiles in path
                AllFiles.AddRange(Directory.GetFiles(path));
                //for each sub directory parse sub of subdirectories(recursive)
                foreach (string subdir in SubDirs)
                {
                    if (Imp && subdir.Contains("\\Improved"))
                        continue;
                    ParsePath(subdir, Imp);
                }
                return true;

            }
            catch (Exception t) { return false; }
            return true;
        }
        //retrive file information
        bool FilesInfo(String path)
        {
            try
            {
                fi = new FileInfo(path);
                created = fi.CreationTime;
                Lastmodified = fi.LastWriteTime;
            }
            catch (Exception t) { return false; }
            return true;
        }
        //When path is file return true
        bool IsFile(String Des)
        {
            //when contains
            if (Des.Contains("."))
            {
                //index
                int A = Des.IndexOf(".");
                //when exstence of remained
                if (A < Des.Length)
                {
                    //substring remained
                    string D = Des.Substring(A, Des.Length - A);
                    //when existence
                    if (D.Length > 0)
                        return true;
                }
            }
            return false;

        }
        String FileS(String A)
        {

            String f = "";
            do
            {
                f = f.Substring(f.IndexOf("\\"), f.Length - f.IndexOf("\\"));
            } while (f.IndexOf("\\") != -1);
            return f;

        }
        //Imrove all date into one folder
        public bool FormShizoImprove(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicatore
                        progressBarWorking.Value = i;
                        //when contains Suffixed
                        if (AllFiles[i].Contains("." + Pro))
                        {
                            //index of to substring
                            String Des = FileS(AllFiles[i]);
                            //create correct path
                            Des = "C:\\ShizoImprove\\" + Pro + "\\" + All[i].Lastmodified.ToLongDateString() + "\\" + Des;
                            //when
                            if (!IsFile(Des))
                            {
                                //create directory exitence condition
                                if (!Directory.Exists(Des))
                                    Directory.CreateDirectory(Des);
                            }
                            else
                            {
                                try
                                {
                                    //copy file
                                    //copy file when unexistence
                                    if (!File.Exists(AllFiles[i]))
                                        File.Copy(AllFiles[i], Des);
                                    else  //copy file on condition of Last modified
                                    {
                                        if ((new FileInfo(AllFiles[i])).LastWriteTime > (new FileInfo(Des)).LastWriteTime)
                                        {
                                            File.Delete(Des);
                                            File.Copy(AllFiles[i], Des);

                                        }

                                    }
                                }
                                catch (Exception t)
                                {
                                    // return false;
                                }
                            }
                        }


                    }
                    catch (Exception t) { }
                }

            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
        public bool FormShizoImproveActOnFileHistory(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicatore
                        progressBarWorking.Value = i;
                        //when contains project
                        if (AllFiles[i].Contains("("))
                        {
                            //index of to substring
                            String Des = AllFiles[i].Substring(0, AllFiles[i].IndexOf("("));
                            //create correct path
                            Des = "C:\\ShizoImprove\\" + Pro + "\\" + All[i].Lastmodified.ToLongDateString() + "\\" + Des;
                            //when
                            if (!IsFile(Des))
                            {
                                //create directory exitence condition
                                if (!Directory.Exists(Des))
                                    Directory.CreateDirectory(Des);
                            }
                            else
                            {
                                try
                                {
                                    //copy file when unexistence
                                    if (!File.Exists(AllFiles[i]))
                                        File.Copy(AllFiles[i], Des);
                                    else  //copy file on condition of Last modified
                                    {
                                        if ((new FileInfo(AllFiles[i])).LastWriteTime > (new FileInfo(Des)).LastWriteTime)
                                        {
                                            File.Delete(Des);
                                            File.Copy(AllFiles[i], Des);
                                            File.Delete(AllFiles[i]);
                                        }

                                    }
                                }
                                catch (Exception t)
                                {
                                    // return false;
                                }
                            }
                        }


                    }
                    catch (Exception t) { }
                }

            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
        void setAttributesNormal(DirectoryInfo dir)
        {
            foreach (var subDir in dir.GetDirectories())
                setAttributesNormal(subDir);
            foreach (var file in dir.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
            }
        }
        public bool FormShizoImproveClearCach(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicatore
                        progressBarWorking.Value = i;

                        if (!AllFiles[i].Contains("\\Improved"))
                        {
                            //when
                            if (!IsFile(AllFiles[i]))
                            {
                                //create directory exitence condition
                                try
                                {
                                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(AllFiles[i]);

                                    if (dir.Exists)
                                    {
                                        setAttributesNormal(dir);
                                        dir.Delete(true);
                                    }

                                }
                                catch (Exception t) { }
                            }
                            else
                            {
                                try
                                {
                                    //copy file
                                    if (File.Exists(AllFiles[i]))
                                        File.Delete(AllFiles[i]);
                                }
                                catch (Exception t)
                                {
                                    // return false;
                                }
                            }
                        }
                    }
                    catch (Exception t) { }
                }

            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
        //move date Last modified of set improved into improved folder
        public bool FormImprove(String Pro, ref System.Windows.Forms.ProgressBar progressBarWorking)
        {
            try
            {
                //for all same same project path
                for (int i = 0; i < AllFiles.Count; i++)
                {
                    try
                    {   //indicator
                        progressBarWorking.Value = i;
                        //when contains Suffixe
                        if (AllFiles[i].Contains("." + Pro))
                        {
                            //index of to substring
                            String Des = FileS(AllFiles[i]);
                            //index of Last modified path and substring
                            for (int j = 1990; j <= DateTime.Now.Year; j++)
                            {
                                //when contains date
                                if (Des.Contains(j.ToString()))
                                {
                                    //substring
                                    int A = Des.IndexOf(j.ToString()) + 4;
                                    Des = Des.Substring(A, Des.Length - A);
                                }
                            }
                            //create correcte path
                            Des = "C:\\ShizoImprove\\Improved\\" + Pro + "\\" + Des;
                            //when
                            if (!IsFile(Des))
                            {
                                //create directory exitence condition
                                if (!Directory.Exists(Des))
                                    Directory.CreateDirectory(Des);
                            }
                            else
                            {
                                try
                                {
                                    //copy file when unexistence
                                    if (!File.Exists(Des))
                                        File.Copy(AllFiles[i], Des);
                                    else  //copy file on condition of Last modified
                                    {
                                        if ((new FileInfo(AllFiles[i])).LastWriteTime > (new FileInfo(Des)).LastWriteTime)
                                        {
                                            File.Delete(Des);
                                            File.Copy(AllFiles[i], Des);
                                        }

                                    }
                                }
                                catch (Exception t)
                                {
                                    //return false;
                                }
                            }
                        }
                    }
                    catch (Exception y)
                    {

                    }
                }
            }
            catch (Exception y)
            {
                return false;
            }
            return true;



        }
    }
}
