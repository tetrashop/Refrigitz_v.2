using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
namespace GalleryStudio
{

    public class TakeImageMemmorry
    {
        const string S = "TakeImages.txt";
        static GalleryStudio.TakeImageMemmorry Node = new TakeImageMemmorry();
        GalleryStudio.TakeImage Current = new TakeImage(0,null);
        GalleryStudio.TakeImageMemmorry Next = null;

        public void Load()
        {
            try
            {
                if (Node == null)
                    Node = new TakeImageMemmorry();
                Node.TakeImagesNextAccess = null;
                Node.TakeImagesCurrentAccess = null;

                FileStream DummyFileStream = new FileStream(S, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                BinaryFormatter Formatters = new BinaryFormatter();
                GalleryStudio.TakeImage Dummy = new TakeImage(0, null);
                GalleryStudio.TakeImageMemmorry Last = null;
                Console.WriteLine("Loading...");
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (DummyFileStream.Position < DummyFileStream.Length)
                {

                    Dummy = (TakeImage)Formatters.Deserialize(DummyFileStream);
                    if (Node.Current == null)
                    {
                        Node.Current = Dummy;
                    }
                    else
                    {
                        Last = Node;
                        while (Last.Next != null)
                            Last = Last.Next;
                        TakeImageMemmorry New = new TakeImageMemmorry();
                        New.Current = Dummy;
                        Last.TakeImagesNextAccess = New;
                    }
                }
                DummyFileStream.Flush();
                DummyFileStream.Close();
            }
            catch (IOException t)
            {
                Console.WriteLine(t.Message.ToString());
            }
        }
        public void DeleteObject(TakeImageMemmorry p)
        {
            TakeImageMemmorry t = new TakeImageMemmorry();
            t = Node;
            try
            {
                if ((t.TakeImagesCurrentAccess.CustomersAcess) != (p.TakeImagesCurrentAccess.CustomersAcess))
                {
                    if (t != null)
                        while ((t.TakeImagesNextAccess.TakeImagesCurrentAccess.CustomersAcess) != (p.TakeImagesCurrentAccess.CustomersAcess))
                        {
                            if (t.TakeImagesNextAccess != null)
                                t = t.TakeImagesNextAccess;
                            else
                                if ((t.TakeImagesCurrentAccess.CustomersAcess) != (p.TakeImagesCurrentAccess.CustomersAcess))
                                {
                                    t = null;
                                    break;
                                }
                        }
                    if (t != null)
                    {
                        if (t.TakeImagesNextAccess != null)
                            t.TakeImagesNextAccess = t.TakeImagesNextAccess.TakeImagesNextAccess;

                        else
                            t.TakeImagesNextAccess = null;
                    }

                }
                else
                {
                    t = t.TakeImagesNextAccess;
                    Node = t;
                }
            }
            catch (NullReferenceException q)
            {
                Console.WriteLine(q.Message.ToString());
            
            }
        }
        public void AddObject(TakeImageMemmorry p)
        {
            //p.TakeImagesNextAccess = null;
            TakeImageMemmorry t =new TakeImageMemmorry();
            t = p.TakeImagesNodeAccess;
            while (t.TakeImagesNextAccess != null)
                t = t.TakeImagesNextAccess;
             if (t.TakeImagesCurrentAccess == null)
                t.TakeImagesCurrentAccess = p.TakeImagesCurrentAccess;
             else
             t.TakeImagesNextAccess = p;
        
        }
        public TakeImageMemmorry TakeImagesNodeAccess
        {
            get
            {
                return Node;
            }
            set
            {
                Node = value;
            }
        }
        public TakeImage TakeImagesCurrentAccess
        {
            get
            {
                return Current;
            }
            set
            {
                Current = value;
            }
        }
        public TakeImageMemmorry TakeImagesNextAccess
        {
            get
            {
                return Next;
            }
            set
            {
                Next = value;
            }
        }
    }
    }
