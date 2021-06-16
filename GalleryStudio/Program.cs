using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
namespace GalleryStudio
{
    class Program
    {       
        static void Main(string[] args)
        {
            //ststic member of customersdummy variable should be assigned firstly.            
            String Section = "\0";
            String Ch="\0";
            BinaryFormatter formatters = new BinaryFormatter();
            Customers CustomersDummy = new Customers();
            Photo PhotosDummy = new Photo();
            TakeImage TakeImageDummy = new TakeImage(0,null);
            CustomerMemmorry CustomerMemmoryDummy = new CustomerMemmorry();
            PhotoMemmorry PhotoMemmoryDummy = new PhotoMemmorry();
            TakeImageMemmorry TakeImageMemmorydummy = new TakeImageMemmorry();
            for (;;)
            {   Console.WriteLine("A or B?");
            try{Section = Console.ReadLine()[0].ToString();}
            catch (FormatException t){Console.WriteLine(t.Message.ToString());}
            catch (IndexOutOfRangeException t){Console.WriteLine(t.Message.ToString());}             
            if (Section.ToString().ToUpper() == "B"){
                try
                {
                    Console.WriteLine("CommandB:SearchSystemCommand(1-8)/>");
                    Ch = Console.ReadLine()[0].ToString();
                }
                catch (IndexOutOfRangeException t) { Console.WriteLine(t.Message.ToString());}
                TakeImageMemmorydummy = new TakeImageMemmorry();
               switch (Ch)
                    {case "1":   Operator.PCustomers();break;
                     case "2":   Console.WriteLine("Enter Customer ID:");
                     try{int Dummy = System.Convert.ToInt32(Console.ReadLine());int i = 0;
                     do{CustomersDummy = Operator.GetCustumer(i);
                        if(CustomersDummy!=null)
                            if (CustomersDummy.CustomersCustomerID == Dummy)break;
                            i++;
                       } while (CustomersDummy != null);
                     if (CustomersDummy != null){
                     string[] DummyString = new string[]{
                     CustomersDummy.CustomersCustomerID.ToString(),
                     CustomersDummy.CustomersName.ToString(),
                     CustomersDummy.CustomersFamilyName.ToString(),
                     CustomersDummy.CustomersAddress.ToString(),
                     CustomersDummy.CustomersTellefon.ToString()};
                     Console.WriteLine("The Customer is:");
                     Operator.PCustomersRemark();
                     Operator.PrintCustomers(DummyString);}
                     else  Console.WriteLine("There is not such Customee");
                        }catch (FormatException t){Console.WriteLine(t.Message.ToString());}break;
                     case "3":   Operator.PPhoto();  break;
                     case "4":   Console.WriteLine("Enter Photo Number:");
                            try{
                                int Dummy = System.Convert.ToInt32(Console.ReadLine());
                                int i = 0;
                                do{ PhotosDummy = Operator.GetPhoto(i);
                                if (PhotosDummy != null)   if (PhotosDummy.PhotoNumberAccsess == Dummy) break;
                                i++;}while (PhotosDummy != null);
                                if (PhotosDummy != null){
                                string[] DummyString = new string[]{
                                PhotosDummy.PhotoNumberAccsess.ToString(),
                                PhotosDummy.PhotoNameAccess.ToString(),
                                "\0"};
                                if (PhotosDummy.PhotoTypeAccess)     DummyString[2] = "Color";
                                else                                 DummyString[2] = "BlackWhite";
                                Console.WriteLine("The Photo is:");
                                Operator.PrintPhotos(DummyString);}
                                else Console.WriteLine("There is not such Photo.");}
                                catch (FormatException t){Console.WriteLine(t.Message.ToString());}break;
                        case "5":
                            try{
                                TakeImageMemmorydummy.Load();
                                Console.WriteLine("Enter Customer ID:");
                                int Dummy = System.Convert.ToInt32(Console.ReadLine());
                                Photo[] Photos = null;
                                int Dimension = -1;
                                Photos = Operator.GetPhotoFromCustomerID(Dummy, ref Dimension);
                                if (Dimension > 0){Console.WriteLine("Have This Photos:");Operator.PhPhotoRemark();
                                for (int k = 0; k < Dimension; k++){
                                string[] DummyString = new string[]{
                                Photos[k].PhotoNumberAccsess.ToString(),
                                Photos[k].PhotoNameAccess.ToString(),"\0" };
                                if (Photos[k].PhotoTypeAccess)  DummyString[2] = "Color";
                                else                            DummyString[2] = "BlackWhite";
                                Operator.PrintPhotos(DummyString);}}
                                else{Console.WriteLine("There Is not Any Photo");}}
                                catch (FormatException t){Console.WriteLine(t.Message.ToString());}break;
                        case "6":
                            try{
                                TakeImageMemmorydummy.Load();
                                Console.WriteLine("Enter Photo ID:");
                                int Dummy = System.Convert.ToInt32(Console.ReadLine());
                                Customers Customer = new Customers();
                                TakeImageMemmorydummy = TakeImageMemmorydummy.TakeImagesNodeAccess;
                                while(TakeImageMemmorydummy!=null){
                                    if (TakeImageMemmorydummy.TakeImagesCurrentAccess.PhotoNumberAccess == Dummy){
                                        Customer = TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess;break;}
                                        TakeImageMemmorydummy=TakeImageMemmorydummy.TakeImagesNextAccess;}
                                if (TakeImageMemmorydummy != null){
                                string[] DummyString = new string[]{
                                Customer.CustomersCustomerID.ToString(),
                                Customer.CustomersName.ToString(),
                                Customer.CustomersFamilyName.ToString(),
                                Customer.CustomersAddress.ToString(),
                                Customer.CustomersTellefon.ToString()};
                                Console.WriteLine("The Customer is:");Operator.PCustomersRemark();Operator.PrintCustomers(DummyString);}
                                else Console.WriteLine("There is not such Photo.");}
                                catch (FormatException t){Console.WriteLine(t.Message.ToString());}break;
                        case "7":
                            try{
                                
                                Console.WriteLine("The Take Photo Is: ");Operator.PTakeImage();
                                string[] Date = new string[3];Console.WriteLine("Year : ");
                                Date[0] = System.Console.ReadLine();Console.WriteLine("Month : ");
                                Date[1] = System.Console.ReadLine();Console.WriteLine("Day : ");
                                Date[2] = System.Console.ReadLine();
                                Photo[] Ph = new Photo[1000];Customers[] Cu = new Customers[1000];int PhDimention = -1; 
                                Ph = Operator.GetPhotoFromDateFromTakeImageMemory(Date, ref PhDimention);
                                TakeImageMemmorydummy.Load();TakeImageMemmorydummy = TakeImageMemmorydummy.TakeImagesNodeAccess;
                                while (TakeImageMemmorydummy!= null){int i = 0;
                                while(TakeImageMemmorydummy.TakeImagesCurrentAccess.PhotoNumberAccess!=Ph[i].PhotoNumberAccsess)i++;                                    
                                string[] DummyStringPhoto = new string[]{
                                Ph[i].PhotoNumberAccsess.ToString(),
                                Ph[i].PhotoNameAccess.ToString(),"\0"};
                                if (Ph[i].PhotoTypeAccess)     DummyStringPhoto[2] = "Color";
                                else                           DummyStringPhoto[2] = "BlackWhite";
                                for (int j = i; j < PhDimention - 1; j++)Ph[j] = Ph[j + 1];
                                string[] DummyStringCustomer = new string[]{
                                TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersCustomerID.ToString(),
                                TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersName.ToString(),
                                TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersFamilyName.ToString(),
                                TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersAddress.ToString(),
                                TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersTellefon.ToString()};
                                TakeImageMemmorydummy.DeleteObject(TakeImageMemmorydummy);
                                Console.WriteLine("The Photo :");Operator.PhPhotoRemark();Operator.PrintPhotos(DummyStringPhoto);
                                Console.WriteLine("Is For Customer :");Operator.PCustomersRemark();
                                Operator.PrintCustomers(DummyStringCustomer);
                                for (int j = 0; j < 50; j++)Console.Write("=");
                                Console.WriteLine("");
                                TakeImageMemmorydummy = TakeImageMemmorydummy.TakeImagesNodeAccess;}}
                                catch (FormatException t){Console.WriteLine(t.Message.ToString());}
                                catch (NullReferenceException t){Console.WriteLine(t.Message.ToString());}break;
                                case "8": Operator.PTakeImage();break;
                                default: 
                                   Console.WriteLine("Sorry.Invalid!");break;}}
                                else
                                if (Section.ToString().ToUpper() == "A"){
                                try{Console.WriteLine("CommandA:FileSection(1-3)/>");
                                Ch = Console.ReadLine()[0].ToString().ToUpper();
                                Console.WriteLine("CommandA:"+Ch+":Command(D Or A Or U)/>");
                                Ch = Ch+Console.ReadLine()[0].ToString().ToUpper();}
                                catch (NullReferenceException t) { Console.WriteLine(t.Message.ToString()); }
                                catch (IndexOutOfRangeException t) { Console.WriteLine(t.Message.ToString()); }
                                switch (Ch){                            
                            case "1D"://Deletion of Customer Objects"                        
                                try
                                {
                                if (CustomerMemmoryDummy == null) CustomerMemmoryDummy = new CustomerMemmorry(); CustomerMemmoryDummy.Load();                      
                                Operator.PCustomers();string DummyString = null;Console.WriteLine("Name?");
                                DummyString = Console.ReadLine();
                                CustomerMemmoryDummy = CustomerMemmoryDummy.CustomersNodeAccess;
                                while (CustomerMemmoryDummy != null){if (CustomerMemmoryDummy.CustomersCurrentAccess.CustomersName == DummyString)
                                {CustomerMemmoryDummy.DeleteObject(CustomerMemmoryDummy);break;}
                                else  CustomerMemmoryDummy = CustomerMemmoryDummy.CustomersNextAccess;   }
                                Operator.RewriteCusomers(CustomerMemmoryDummy); }
                                catch (IOException i) { Console.WriteLine(i.Message.ToString()); }
                                catch (NullReferenceException i) { Console.WriteLine(i.Message.ToString()); }break;
                                
                                case "1A": Again: //Add A customer.";
                                    try{
                                    if (CustomerMemmoryDummy == null) CustomerMemmoryDummy = new CustomerMemmorry(); CustomerMemmoryDummy.Load();
                                    if (CustomersDummy == null)CustomersDummy = new Customers();
                                    Console.WriteLine("ID?");
                                    CustomersDummy.CustomersCustomerID = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Name?");
                                    CustomersDummy.CustomersName = Console.ReadLine();
                                    Console.WriteLine("FamilyName?");
                                    CustomersDummy.CustomersFamilyName = Console.ReadLine();
                                    Console.WriteLine("Adress?");
                                    CustomersDummy.CustomersAddress = Console.ReadLine();
                                    Console.WriteLine("Telephone?");
                                    CustomersDummy.CustomersTellefon = Convert.ToInt32(Console.ReadLine()); }
                                    catch (FormatException t){Console.WriteLine(t.Message.ToString());
                                    CustomersDummy = null;goto Again;    }
                                    catch (OverflowException t) { Console.WriteLine(t.Message.ToString()); goto Again; }
                                    catch (NullReferenceException t) { Console.WriteLine(t.Message.ToString()); goto Again; }
                                    CustomerMemmorry DummyCustomers = new CustomerMemmorry();
                                    DummyCustomers.CustomersCurrentAccess = CustomersDummy;
                                    CustomerMemmoryDummy.AddObject(DummyCustomers);
                                    Operator.RewriteCusomers(CustomerMemmoryDummy);break;
                            case "1U":bool Deltted = false;
                                CustomerMemmorry DummyCustomre = new CustomerMemmorry();DummyCustomre.Load();
                                try{
                                    Console.WriteLine("customers:"); Operator.PCustomers();
                                    Console.WriteLine("Customer Nummber?");
                                    CustomerMemmoryDummy.CustomersCurrentAccess = Operator.GetCustumer(Convert.ToInt32(Console.ReadLine()));
                                    if (CustomerMemmoryDummy.CustomersCurrentAccess == null)
                                    Console.WriteLine("There Is Not Such Custoers!");
                                    else{
                                        DummyCustomre.DeleteObject(CustomerMemmoryDummy);
                                        Deltted = true;
                                        Console.WriteLine("CustomerID(0);Name(1);FamilyName(2);Address(3);TelephoneNumber(4)");
                                        Ch = Console.ReadLine()[0].ToString().ToUpper();
                                        Console.WriteLine("Enter new String:");
                                        string Dummy = Console.ReadLine();

                                        switch (Ch)
                                        {
                                            case "0": CustomerMemmoryDummy.CustomersCurrentAccess.CustomersCustomerID = System.Convert.ToInt32(Dummy); break;
                                            case "1": CustomerMemmoryDummy.CustomersCurrentAccess.CustomersName = Dummy; break;
                                            case "2": CustomerMemmoryDummy.CustomersCurrentAccess.CustomersFamilyName = Dummy; break;
                                            case "3": CustomerMemmoryDummy.CustomersCurrentAccess.CustomersAddress = Dummy; break;
                                            case "4": CustomerMemmoryDummy.CustomersCurrentAccess.CustomersTellefon = System.Convert.ToInt32(Dummy); break;
                                            default: Console.WriteLine("Sorry.Invalid!"); break;
                                        }                                        
                                        DummyCustomre.AddObject(CustomerMemmoryDummy);
                                        Operator.RewriteCusomers(DummyCustomre);
                                        Deltted = false;}}
                                catch (FormatException t){if (Deltted){
                                        DummyCustomre.AddObject(CustomerMemmoryDummy);
                                        Operator.RewriteCusomers(DummyCustomre);}
                                    Console.WriteLine(t.Message.ToString());}break;
                            case "2D":
                                 try{
                                    PhotoMemmoryDummy.Load();Operator.PPhoto();
                                    string DummyString = null;Console.WriteLine("Name?");
                                    DummyString = Console.ReadLine();
                                    PhotoMemmoryDummy = PhotoMemmoryDummy.PhotosNodeAccess;
                                    while (PhotoMemmoryDummy != null){if (PhotoMemmoryDummy.PhotosCurrentAccess.PhotoNameAccess == DummyString) {   PhotoMemmoryDummy.DeleteObject(PhotoMemmoryDummy);
                                    break;}else PhotoMemmoryDummy = PhotoMemmoryDummy.PhotosNextAccess;}
                                    Operator.RewritePhotos(PhotoMemmoryDummy);}
                                    catch (IOException i){ Console.WriteLine(i.Message.ToString()); }
                                    catch (NullReferenceException i){ Console.WriteLine(i.Message.ToString()); }break;
                            case "2A":   Again1:
                                try{PhotoMemmoryDummy.Load();
                                    if (PhotosDummy == null)  PhotosDummy = new Photo();
                                    Console.WriteLine("ID?");
                                    PhotosDummy.PhotoNumberAccsess = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Name?");
                                    PhotosDummy.PhotoNameAccess = Console.ReadLine();
                                    Console.WriteLine("PhotoType((0) Color ,(1) BlackWhite?");
                                    {Ch=Console.ReadLine()[0].ToString().ToUpper();
                                     if (Ch == "0") PhotosDummy.PhotoTypeAccess = true;
                                     else if (Ch == "1") PhotosDummy.PhotoTypeAccess = false;}                                }
                                 catch (FormatException t){Console.WriteLine(t.Message.ToString());
                                     PhotosDummy = null;goto Again1;}
                                catch (OverflowException t){Console.WriteLine(t.Message.ToString());
                                    goto Again1;}
                                PhotoMemmorry DummyPhotos = new PhotoMemmorry();
                                DummyPhotos.PhotosCurrentAccess = PhotosDummy;
                                PhotoMemmoryDummy.AddObject(DummyPhotos);
                                Operator.RewritePhotos(PhotoMemmoryDummy);break;
                            case "2U":Deltted = false;
                                PhotoMemmorry DummyPhoto = new PhotoMemmorry();
                                DummyPhoto.Load();
                                try{Console.WriteLine("Photo:"); Operator.PPhoto();
                                    Console.WriteLine("photo Nummber?");
                                    PhotoMemmoryDummy.PhotosCurrentAccess=Operator.GetPhoto(Convert.ToInt32(Console.ReadLine()));
                                    if (PhotoMemmoryDummy.PhotosCurrentAccess == null)
                                        Console.WriteLine("There Is Not Such Photos!");
                                    else{
                                        DummyPhoto.DeleteObject(PhotoMemmoryDummy);Deltted = true;
                                        Console.WriteLine("PhotNumber(0);PhotName(1);PhotoType(2)('0' Color,'1' BlackWhote)");
                                        Ch = Console.ReadLine()[0].ToString().ToUpper();
                                        Console.WriteLine("Enter new String:");
                                        string Dummy = Console.ReadLine();
                                        switch (Ch){
                                            case "0": PhotoMemmoryDummy.PhotosCurrentAccess.PhotoNumberAccsess= System.Convert.ToInt32(Dummy); break;
                                            case "1": PhotoMemmoryDummy.PhotosCurrentAccess.PhotoNameAccess = Dummy; break;
                                            case "2": if (Dummy == "0")
                                                    PhotoMemmoryDummy.PhotosCurrentAccess.PhotoTypeAccess = true;
                                            else    if (Dummy == "1")
                                                    PhotoMemmoryDummy.PhotosCurrentAccess.PhotoTypeAccess = false;break;
                                            default: Console.WriteLine("Sorry.Invalid!"); break;}
                                        DummyPhoto.AddObject(PhotoMemmoryDummy );
                                        Operator.RewritePhotos(DummyPhoto);Deltted = false;}}
                                catch (FormatException t){if (Deltted){
                                        DummyPhoto.AddObject(PhotoMemmoryDummy);
                                        Operator.RewritePhotos(DummyPhoto);}Console.WriteLine(t.Message.ToString());}break;
                                    case "3D": try{
                                    if (TakeImageMemmorydummy == null) TakeImageMemmorydummy = new TakeImageMemmorry(); TakeImageMemmorydummy.Load();                                    
                                    Operator.PTakeImage();int  DummyNumber = 0;
                                    Console.WriteLine("PhotoNumber?");
                                    DummyNumber = System.Convert.ToInt32(Console.ReadLine());
                                    TakeImageMemmorydummy = TakeImageMemmorydummy.TakeImagesNodeAccess;
                                    while (TakeImageMemmorydummy != null){
                                        if (TakeImageMemmorydummy.TakeImagesCurrentAccess.PhotoNumberAccess == DummyNumber){
                                            TakeImageMemmorydummy.DeleteObject(TakeImageMemmorydummy);break;}
                                        else TakeImageMemmorydummy = TakeImageMemmorydummy.TakeImagesNextAccess;                                    }
                                    Operator.RewriteTakeImage(TakeImageMemmorydummy);}
                                catch (IOException i){ Console.WriteLine(i.Message.ToString()); }
                                catch (NullReferenceException i){ Console.WriteLine(i.Message.ToString()); }break;
                            case "3A":Again2:
                                try{                                 
                                    TakeImageMemmorydummy.Load();
                                    if (TakeImageDummy == null) TakeImageDummy = new TakeImage(0,null);
                                    Console.WriteLine("Photos");Operator.PPhoto();
                                    Console.WriteLine("PhotoNumber?");
                                    TakeImageDummy.PhotoNumberAccess = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("The Customers is:");Operator.PCustomers();
                                    Console.WriteLine("Customer Nummber?");
                                    TakeImageDummy.CustomersAcess = Operator.GetCustumer(Convert.ToInt32(Console.ReadLine()));}
                                catch (FormatException t){Console.WriteLine(t.Message.ToString());
                                    CustomersDummy = null;goto Again2;}
                                catch (OverflowException t){Console.WriteLine(t.Message.ToString());goto Again2;}
                                if (TakeImageDummy.CustomersAcess == null)
                                    Console.WriteLine("There Is Not Such Custoers!");
                                else {
                                    TakeImageMemmorry DummyTakeImage = new TakeImageMemmorry();
                                    TakeImage TakeImageD = new TakeImage(TakeImageDummy.PhotoNumberAccess,TakeImageDummy.CustomersAcess);
                                    DummyTakeImage.TakeImagesCurrentAccess= TakeImageD;
                                    TakeImageMemmorydummy.AddObject(DummyTakeImage);
                                    Operator.RewriteTakeImage(TakeImageMemmorydummy);}break;
                            case "3U":Deltted = false;
                                TakeImageMemmorry DummyTakeImages = new TakeImageMemmorry();                                                                
                                try{DummyTakeImages.Load();
                                    Console.WriteLine("TakeImages:"); Operator.PTakeImage();
                                    Console.WriteLine("TakeImage Nummber?");                                    
                                    TakeImageMemmorydummy.TakeImagesCurrentAccess = Operator.GetTakeImage(Convert.ToInt32(Console.ReadLine()));
                                    if (TakeImageMemmorydummy.TakeImagesCurrentAccess == null)
                                       Console.WriteLine("There Is Not Such Photos!");
                                    else{DummyTakeImages.DeleteObject(TakeImageMemmorydummy);Deltted = true;
                                        Console.WriteLine("PhotNumber(0);Customer(1)");
                                        Ch = Console.ReadLine()[0].ToString().ToUpper();
                                        Console.WriteLine("CustomerID(0);Name(1);FamilyName(2);Address(3);TelephonNumber(4);");
                                        String Wh = Console.ReadLine()[0].ToString().ToUpper();
                                        Console.WriteLine("Enter new String:");
                                        string Dummy = Console.ReadLine();
                                        switch (Ch){
                                            case "0": TakeImageMemmorydummy.TakeImagesCurrentAccess.PhotoNumberAccess = System.Convert.ToInt32(Dummy); break;
                                            case "1":
                                                switch(Wh){
                                                case "0":TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersCustomerID = System.Convert.ToInt32(Dummy);break;
                                                case "1":TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersName = Dummy; break;
                                                case "2":TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersFamilyName= Dummy;break;
                                                case "3":TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersAddress = Dummy; break;
                                                case "4":TakeImageMemmorydummy.TakeImagesCurrentAccess.CustomersAcess.CustomersTellefon = System.Convert.ToInt32(Dummy);break;
                                                default: Console.WriteLine("Sorry.Invalid!"); break;
                                                }break;
                                            default: Console.WriteLine("Sorry.Invalid!"); break;
                                        }
                                        DummyTakeImages.AddObject(TakeImageMemmorydummy);
                                        Operator.RewriteTakeImage(DummyTakeImages);Deltted = false;}}
                                catch (FormatException t){if (Deltted){
                                        DummyTakeImages.AddObject(TakeImageMemmorydummy);
                                        Operator.RewriteTakeImage(DummyTakeImages);}
                                    Console.WriteLine(t.Message.ToString());}
                                catch (NullReferenceException t){Console.WriteLine(t.Message.ToString());}break;
                            default:Console.WriteLine("Sorry.Invalid!"); break;                        }
                    }}}}}