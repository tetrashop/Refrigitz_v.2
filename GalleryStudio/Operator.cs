using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace GalleryStudio
{
    static public class Operator
    {
        static string SCustomer = "Customers.txt";
        static string SPhoto = "Photos.txt";
        static string STakeImage = "TakeImages.txt";
        static public void RewriteCusomers(CustomerMemmorry p)
        {
            FileStream DummyFileStream = null;
            try
            {
                CustomerMemmorry t = p.CustomersNodeAccess;
                FileInfo DummyFileInfo = new FileInfo(SCustomer);
                DummyFileInfo.Delete();
                DummyFileStream = new FileStream(SCustomer, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (t != null)
                {
                    Formatters.Serialize(DummyFileStream, t.CustomersCurrentAccess);
                    t = t.CustomersNextAccess;
                }
                DummyFileStream.Close();
            }
            catch (NullReferenceException o)
            {
                Console.WriteLine(o.Message.ToString());
            }
            catch (IOException o)
            {
                Console.WriteLine(o.Message.ToString());
            }
            
        }
        static public Customers GetCustumer(int No)
        {
            FileStream DummyFileStream = null;
            DummyFileStream = new FileStream(SCustomer, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            int p = 0;
            Customers Dummy = null;
            BinaryFormatter Formatters = new BinaryFormatter();
            DummyFileStream.Seek(0,SeekOrigin.Begin);
            try
            {
                while (p <= No)
                {
                    if (DummyFileStream.Length >= DummyFileStream.Position)
                        Dummy = (Customers)Formatters.Deserialize(DummyFileStream);
                    else
                        Dummy = null;
                    p++;
                }
                DummyFileStream.Flush(); DummyFileStream.Close();
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
                Dummy = null;
            }
            return Dummy;
            }
        static public Photo GetPhoto(int No)
        {
            FileStream DummyFileStream = null;
            DummyFileStream = new FileStream(SPhoto, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            int p = 0;
            Photo Dummy = null;
            BinaryFormatter Formatters = new BinaryFormatter();
            DummyFileStream.Seek(0, SeekOrigin.Begin);
            try
            {
                while (p <= No)
                {
                    if (DummyFileStream.Length > DummyFileStream.Position)
                        Dummy = (Photo)Formatters.Deserialize(DummyFileStream);
                    else
                    {
                        Dummy = null;
                        break;
                    }
                    p++;
                }
                DummyFileStream.Flush(); DummyFileStream.Close();
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            return Dummy;
        }
        static public TakeImage GetTakeImage(int No)
        {
            FileStream DummyFileStream = null;
            DummyFileStream = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            int p = 0;
            TakeImage Dummy = null;
            BinaryFormatter Formatters = new BinaryFormatter();
            DummyFileStream.Seek(0, SeekOrigin.Begin);
            try
            {
                while (p <= No)
                {
                    if (DummyFileStream.Length >= DummyFileStream.Position)
                        Dummy = (TakeImage)Formatters.Deserialize(DummyFileStream);
                    else
                        Dummy = null;
                    p++;
                }
                DummyFileStream.Flush(); DummyFileStream.Close();
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            return Dummy;
        }
        
        static public void RewritePhotos(PhotoMemmorry p)
        {
            FileStream DummyFileStream = null;
            try
            {
                PhotoMemmorry t = p.PhotosNodeAccess;
                FileInfo DummyFileInfo = new FileInfo(SPhoto);
                DummyFileInfo.Delete();
                DummyFileStream = new FileStream(SPhoto, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (t != null)
                {
                    Formatters.Serialize(DummyFileStream, t.PhotosCurrentAccess);
                    t = t.PhotosNextAccess;
                }
                DummyFileStream.Close();
            }
            catch (NullReferenceException o)
            {
                Console.WriteLine(o.Message.ToString());
            }
            catch (IOException o)
            {
                Console.WriteLine(o.Message.ToString());
            }

        }
        static public void RewriteTakeImage(TakeImageMemmorry p)
        {
            FileStream DummyFileStream = null;
            try
            {
                TakeImageMemmorry t = p.TakeImagesNodeAccess;
                FileInfo DummyFileInfo = new FileInfo(STakeImage);
                DummyFileInfo.Delete();
                DummyFileStream = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (t != null)
                {
                    Formatters.Serialize(DummyFileStream, t.TakeImagesCurrentAccess);
                    t = t.TakeImagesNextAccess;
                }
                DummyFileStream.Close();
            }
            catch (NullReferenceException o)
            {
                Console.WriteLine(o.Message.ToString());
            }
            catch (IOException o)
            {
                Console.WriteLine(o.Message.ToString());
            }
            
        }

        static public void PrintCustomers(string[] Dummy)
        {

            int k = 0;
            while (k < 15)
            {
                if (Dummy[0].Length > k)
                    Console.Write(Dummy[0].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[1].Length > k)
                    Console.Write(Dummy[1].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[2].Length > k)
                    Console.Write(Dummy[2].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[3].Length > k)
                    Console.Write(Dummy[3].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[4].Length > k)
                    Console.Write(Dummy[4].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }

            Console.WriteLine("");
        }
        static public void PrintPhotos(string[] Dummy)
        {

            int k = 0;
            while (k < 15)
            {
                if (Dummy[0].Length > k)
                    Console.Write(Dummy[0].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[1].Length > k)
                    Console.Write(Dummy[1].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[2].Length > k)
                    Console.Write(Dummy[2].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }
            Console.WriteLine("");
        }
        static public void PrintTakeImage(string Dummy)
        {

            int k = 0;
            while (k < 15)
            {
                if (Dummy.Length > k)
                    Console.Write(Dummy.ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            Console.WriteLine("");
        }
        static public void PCustomersRemark()
        {
            Console.WriteLine("Customers:");

            string[] Dummy = new string[]{
                "CustomerID",
                "Name",
                "FamilyName",
                "Address",
                "TelephonNumber"
            };
            int k = 0;
            while (k < 15)
            {
                if (Dummy[0].Length > k)
                    Console.Write(Dummy[0].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[1].Length > k)
                    Console.Write(Dummy[1].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[2].Length > k)
                    Console.Write(Dummy[2].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[3].Length > k)
                    Console.Write(Dummy[3].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[4].Length > k)
                    Console.Write(Dummy[4].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }

            Console.WriteLine("");
        }
        static public void PCustomers()
        {
            Operator.PCustomersRemark();
            Customers DummyOutput = new Customers();
            FileStream Customer = new FileStream(SCustomer, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            BinaryFormatter formatters = new BinaryFormatter();
            
            Customer.Seek(0, SeekOrigin.Begin);
            while (Customer.Position < Customer.Length)
            {
                DummyOutput = (Customers)formatters.Deserialize(Customer);
                string[] DummyString = new string[]{
              DummyOutput.CustomersCustomerID.ToString(),
              DummyOutput.CustomersName.ToString(),
              DummyOutput.CustomersFamilyName.ToString(),
              DummyOutput.CustomersAddress.ToString(),
              DummyOutput.CustomersTellefon.ToString()
              };
                Operator.PrintCustomers(DummyString);
            }
            Customer.Flush();
            Customer.Close();
        }
        static public void PhPhotoRemark()
        {
            Console.WriteLine("Photo:");
            string[] Dummy = new string[]{
                "PhotoNumber",
                "PhotoName",
                "PhotoType"
            };
            int k = 0;
            while (k < 15)
            {
                if (Dummy[0].Length > k)
                    Console.Write(Dummy[0].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[1].Length > k)
                    Console.Write(Dummy[1].ToCharArray(k, 1));
                else
                    Console.Write(' ');
                k++;
            }
            k = 0;
            while (k < 15)
            {
                if (Dummy[2].Length > k)
                    Console.Write(Dummy[2].ToCharArray(k, 1));
                else
                    Console.Write(' ');

                k++;
            }
            Console.WriteLine("");        
        }
        static public void PPhoto()
        {
            Operator.PhPhotoRemark();
            Photo DummyOutput = new Photo();
            FileStream Photo = new FileStream(SPhoto, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            BinaryFormatter formatters = new BinaryFormatter();
            
            Photo.Seek(0, SeekOrigin.Begin);
            while (Photo.Position < Photo.Length)
            {
                DummyOutput = (Photo)formatters.Deserialize(Photo);
              string[] DummyString = new string[]{
              DummyOutput.PhotoNumberAccsess.ToString(),
              DummyOutput.PhotoNameAccess.ToString(),              
              "\0"
              };
                if (DummyOutput.PhotoTypeAccess)
                    DummyString[2] = "Color";
                else
                    DummyString[2] = "BlackWhite";
                Operator.PrintPhotos(DummyString);
            }
            Photo.Flush();
            Photo.Close();
        }
        static public void PTakeImage()
        {
            Console.WriteLine("TakeIamge:");

            TakeImage DummyOutput = new TakeImage(0,null);
            FileStream TakeImage = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            BinaryFormatter formatters = new BinaryFormatter();
            
            TakeImage.Seek(0, SeekOrigin.Begin);
            while (TakeImage.Position < TakeImage.Length)
            {
              DummyOutput = (TakeImage)formatters.Deserialize(TakeImage);
              string DummyString =DummyOutput.PhotoNumberAccess.ToString();
              string[] Dummy=new string[]{
                DummyOutput.CustomersAcess.CustomersCustomerID.ToString(),
                DummyOutput.CustomersAcess.CustomersName.ToString(),
                DummyOutput.CustomersAcess.CustomersFamilyName.ToString(),
                DummyOutput.CustomersAcess.CustomersAddress.ToString(),
                DummyOutput.CustomersAcess.CustomersTellefon.ToString()
               };
                Console.WriteLine("Customer:");
              Operator.PrintCustomers(Dummy);
              Console.WriteLine("PhotoNumber:");
              Operator.PrintTakeImage(DummyString);
              Console.Write("The Date is:");
              Console.WriteLine(DummyOutput.YearAccess.ToString()+":"+DummyOutput.MonthAccess.ToString()+":"+DummyOutput.DayAccess.ToString());
              for (int i = 0; i < 50; i++)
                  Console.Write("=");
              Console.WriteLine("");
            }
            TakeImage.Flush();
            TakeImage.Close();
        }
        static public Photo[] GetPhotoFromDateFromTakeImageMemory(string[] Date, ref int Total)
        {

            TakeImage DummyOutput = new TakeImage(0, null);
            FileStream TakeImage = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            BinaryFormatter formatters = new BinaryFormatter();
            Photo[] Dummy = null;
            Photo[] DummyPhoto = new Photo[1000];
            TakeImage.Seek(0, SeekOrigin.Begin);
            Total = 0;
            int Dimention = -1;
            try
            {
                while (TakeImage.Position < TakeImage.Length)
                {
                    DummyOutput = (TakeImage)formatters.Deserialize(TakeImage);

                    if (DummyOutput.YearAccess.ToString() == Date[0])
                        if (DummyOutput.MonthAccess.ToString() == Date[1])
                            if (DummyOutput.DayAccess.ToString() == Date[2])
                            {
                                Dummy = Operator.GetPhotoFromPhotoNumberOfDate(DummyOutput.PhotoNumberAccess, ref Dimention);
                            }
                    if (Dimention > -1)
                    {
                        for (int i = Total; i < Total + Dimention; i++)
                            DummyPhoto[i] = Dummy[i - Total];
                        Total = Total + Dimention;
                    }
                    Dimention = -1;
                }
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            TakeImage.Flush();
            TakeImage.Close();
            return DummyPhoto;
        }
        static public Customers[] GetCustomersFromDate(string[] Date, ref int Total)
        {

            TakeImage DummyOutput = new TakeImage(0, null);
            FileStream TakeImage = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            BinaryFormatter formatters = new BinaryFormatter();
            Customers[] Dummy = null;
            Customers[] DummyPhoto = new Customers[1000];
            TakeImage.Seek(0, SeekOrigin.Begin);
            Total = 0;
            int Dimention = -1;
            try
            {
                while (TakeImage.Position < TakeImage.Length)
                {
                    DummyOutput = (TakeImage)formatters.Deserialize(TakeImage);

                    if (DummyOutput.YearAccess.ToString() == Date[0])
                        if (DummyOutput.MonthAccess.ToString() == Date[1])
                            if (DummyOutput.DayAccess.ToString() == Date[2])
                            {
                                Dummy = Operator.GetCustomerFromPhotoNumberOfDate(DummyOutput.PhotoNumberAccess, ref Dimention);
                            }
                    if (Dimention > -1)
                    {
                        for (int i = Total; i < Total + Dimention; i++)
                            DummyPhoto[i] = Dummy[i - Total];
                        Total = Total + Dimention;
                    }
                    Dimention = -1;
                }
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            TakeImage.Flush();
            TakeImage.Close();
            return DummyPhoto;
        }
        static public Photo[] GetPhotoFromCustomerID(int CustomerNumber, ref int Total)
        { 
            FileStream DummyFileStream = null;
            Photo[] PhotoDummy = null;
            Photo[] TotalPhotoDummy = new Photo[1000];
            Total = 0;
            int Dimension = -1;
            try
            {               
                PhotoMemmorry t = new PhotoMemmorry();
                DummyFileStream = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0,SeekOrigin.Begin);
                        TakeImage DummyOutput = null;
                        while (DummyFileStream.Position < DummyFileStream.Length)
                        {
                            DummyOutput = (TakeImage)Formatters.Deserialize(DummyFileStream);
                            if (DummyOutput.CustomersAcess.CustomersCustomerID == CustomerNumber)
                            {
                                PhotoDummy = Operator.GetPhotoFromPhotoFile(DummyOutput.PhotoNumberAccess,ref Dimension);
                                if(Dimension>-1)
                                {
                                    for (int i = Total; i <= Total + Dimension; i++)
                                    {
                                        TotalPhotoDummy[i] = new Photo();
                                        TotalPhotoDummy[i] = PhotoDummy[i - Total];
                                    }
                                Total=Total+Dimension+1;
                                Dimension = -1;
                                }
                            }
                        }            
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            DummyFileStream.Flush(); DummyFileStream.Close();
            return TotalPhotoDummy;
                
        }
        static public Photo[] GetPhotoFromPhotoNumberOfDate(int PhotoNumber, ref int Total)
        {
            FileStream DummyFileStream = null;
            Photo[] PhotoDummy = null;
            Photo[] TotalPhotoDummy = new Photo[1000];
            Total = 0;
            int Dimension = -1;
            try
            {
                PhotoMemmorry t = new PhotoMemmorry();
                DummyFileStream = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                TakeImage DummyOutput = null;
                while (DummyFileStream.Position < DummyFileStream.Length)
                {
                    DummyOutput = (TakeImage)Formatters.Deserialize(DummyFileStream);
                    if (DummyOutput.PhotoNumberAccess == PhotoNumber)
                    {
                        PhotoDummy = Operator.GetPhotoFromPhotoFile(DummyOutput.PhotoNumberAccess, ref Dimension);
                        if (Dimension > -1)
                        {
                            for (int i = Total; i <= Total + Dimension; i++)
                            {
                                TotalPhotoDummy[i] = new Photo();
                                TotalPhotoDummy[i] = PhotoDummy[i - Total];
                            }
                            Total = Total + Dimension + 1;
                            Dimension = -1;
                        }
                    }
                }
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            DummyFileStream.Flush(); DummyFileStream.Close();
            return TotalPhotoDummy;

        }
        static public Customers[] GetCustomerFromPhotoNumberOfDate(int PhotoNumber, ref int Total)
        {
            FileStream DummyFileStream = null;
            Customers CustomersDummy = null;
            Customers[] TotalCustomersDummy = new Customers[1000];
            Total = 0;
            //int Dimension = -1;
            try
            {
                PhotoMemmorry t = new PhotoMemmorry();
                DummyFileStream = new FileStream(STakeImage, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                TakeImage DummyOutput = null;
                while (DummyFileStream.Position < DummyFileStream.Length)
                {
                    DummyOutput = (TakeImage)Formatters.Deserialize(DummyFileStream);
                    if (DummyOutput.PhotoNumberAccess == PhotoNumber)
                    {
                        CustomersDummy = DummyOutput.CustomersAcess;
                        TotalCustomersDummy[Total] = CustomersDummy;
                        Total++;                    
                    }
                }
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            DummyFileStream.Flush(); DummyFileStream.Close();
            return TotalCustomersDummy;

        }
        
        static Photo[] GetPhotoFromPhotoFile(int PhotNumber,ref int Dimenstion)
        {
            FileStream DummyFileStream = null;
            Photo[] PhotoDummy = new Photo[1000];
            try
            {
                Dimenstion = -1;
                PhotoMemmorry t = new PhotoMemmorry();
                DummyFileStream = new FileStream(SPhoto, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                Photo DummyOutput = null;
                while (DummyFileStream.Position < DummyFileStream.Length)
                {
                    DummyOutput = (Photo)Formatters.Deserialize(DummyFileStream);

                    if (DummyOutput.PhotoNumberAccsess == PhotNumber)
                    {
                        Dimenstion++;
                        PhotoDummy[Dimenstion] = new Photo();
                        PhotoDummy[Dimenstion] = DummyOutput;
                    }
                }
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
            return PhotoDummy;
        }
    }

}
