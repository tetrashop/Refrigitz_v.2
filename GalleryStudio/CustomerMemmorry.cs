using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
namespace GalleryStudio
{

    public class CustomerMemmorry
    {
        const string S = "Customers.txt";
        static GalleryStudio.CustomerMemmorry Node = new CustomerMemmorry();
        GalleryStudio.Customers Current = new Customers();
        GalleryStudio.CustomerMemmorry Next = null;
        public void Load()
        {
            if (Node == null) Node = new CustomerMemmorry();              
            Node.CustomersNextAccess = null;
            Node.CustomersCurrentAccess = null;
            try
            {
                FileStream DummyFileStream = new FileStream(S, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                BinaryFormatter Formatters = new BinaryFormatter();
                GalleryStudio.Customers Dummy = new Customers();
                GalleryStudio.CustomerMemmorry Last = null;
                Console.WriteLine("Loading...");
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (DummyFileStream.Position < DummyFileStream.Length)
                {
                    Dummy = (Customers)Formatters.Deserialize(DummyFileStream);
                    if (Node.Current == null)                    
                        Node.Current = Dummy;                    
                    else
                    {
                        Last = Node;
                        while (Last.Next != null)
                            Last = Last.Next;
                        CustomerMemmorry New = new CustomerMemmorry();
                        New.Current = Dummy;
                        Last.CustomersNextAccess = New;
                    }
                }
                DummyFileStream.Flush();
                DummyFileStream.Close();
            }
            catch (IOException t){Console.WriteLine(t.Message.ToString());}
        }
        public void DeleteObject(CustomerMemmorry p)
        {
            CustomerMemmorry t = new CustomerMemmorry();
            t = Node;
            if ((t.CustomersCurrentAccess.CustomersName) != (p.CustomersCurrentAccess.CustomersName))
            {
                if (t != null)
                    while ((t.CustomersNextAccess.CustomersCurrentAccess.CustomersName) != (p.CustomersCurrentAccess.CustomersName))
                    {
                        if (t.CustomersNextAccess != null)
                            t = t.CustomersNextAccess;
                        else
                        if ((t.CustomersCurrentAccess.CustomersName) != (p.CustomersCurrentAccess.CustomersName))
                        {
                            t = null;
                            break;
                        }
                    }
                if (t != null)
                {
                    if (t.CustomersNextAccess != null)
                        t.CustomersNextAccess = t.CustomersNextAccess.CustomersNextAccess;

                    else
                        t.CustomersNextAccess = null;
                }

            }
            else
            {
                t = t.CustomersNextAccess;
                Node=t;
            }
        }
        public void AddObject(CustomerMemmorry p)
        {            
            CustomerMemmorry t =new CustomerMemmorry();
            t = p.CustomersNodeAccess;
            while (t.CustomersNextAccess != null)
                t = t.CustomersNextAccess;
             if (t.CustomersCurrentAccess == null)
                t.CustomersCurrentAccess = p.CustomersCurrentAccess;
             else
             t.CustomersNextAccess = p;        
        }
        public CustomerMemmorry CustomersNodeAccess
        {
            get
            { return Node;}
            set
            { Node = value;}
        }
        public Customers CustomersCurrentAccess
        {
            get
            {return Current;}
            set
            {Current = value;}
        }
        public CustomerMemmorry CustomersNextAccess
        {
            get
            {return Next;}
            set
            {Next = value;}
        }
    }
    }
