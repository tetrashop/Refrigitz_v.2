using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
namespace GalleryStudio
{

    public class PhotoMemmorry
    {
        const string S = "Photos.txt";
        static GalleryStudio.PhotoMemmorry Node = new PhotoMemmorry();
        GalleryStudio.Photo Current = new Photo();
        GalleryStudio.PhotoMemmorry Next = null;

        public void Load()
        {
            if (Node == null) Node = new PhotoMemmorry();              
            Node.PhotosNextAccess = null;
            Node.PhotosCurrentAccess = null;               
            try
            {
                FileStream DummyFileStream = new FileStream(S, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                BinaryFormatter Formatters = new BinaryFormatter();
                GalleryStudio.Photo Dummy = new Photo();
                GalleryStudio.PhotoMemmorry Last = null;
                Console.WriteLine("Loading...");
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (DummyFileStream.Position < DummyFileStream.Length)
                {
                    Dummy = (Photo)Formatters.Deserialize(DummyFileStream);
                    if (Node.Current == null)
                    {
                        Node.Current = Dummy;
                    }
                    else
                    {
                        Last = Node;
                        while (Last.Next != null)
                            Last = Last.Next;
                        PhotoMemmorry New = new PhotoMemmorry();
                        New.Current = Dummy;
                        Last.PhotosNextAccess = New;
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
        public void DeleteObject(PhotoMemmorry p)
        {
            PhotoMemmorry t = new PhotoMemmorry();
            t = Node;
            if ((t.PhotosCurrentAccess.PhotoNameAccess) != (p.PhotosCurrentAccess.PhotoNameAccess))
            {
                if (t != null)
                    while ((t.PhotosNextAccess.PhotosCurrentAccess.PhotoNameAccess) != (p.PhotosCurrentAccess.PhotoNameAccess))
                    {
                        if (t.PhotosNextAccess != null)
                            t = t.PhotosNextAccess;
                        else
                        if ((t.PhotosCurrentAccess.PhotoNameAccess) != (p.PhotosCurrentAccess.PhotoNameAccess))
                        {
                            t = null;
                            break;
                        }
                    }
                if (t != null)
                {
                    if (t.PhotosNextAccess != null)
                        t.PhotosNextAccess = t.PhotosNextAccess.PhotosNextAccess;

                    else
                        t.PhotosNextAccess = null;
                }

            }
            else
            {
                t = t.PhotosNextAccess;
                Node=t;
            }
        }
        public void AddObject(PhotoMemmorry p)
        {
            //p.PhotosNextAccess = null;
            PhotoMemmorry t =new PhotoMemmorry();
            if (p.PhotosNodeAccess != null)
            {
                t = p.PhotosNodeAccess;
                while (t.PhotosNextAccess != null)
                    t = t.PhotosNextAccess;
                if (t.PhotosCurrentAccess == null)
                    t.PhotosCurrentAccess = p.PhotosCurrentAccess;
                else
                    t.PhotosNextAccess = p;
            }
            else
                Node = p;
        }
        public PhotoMemmorry PhotosNodeAccess
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
        public Photo PhotosCurrentAccess
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
        public PhotoMemmorry PhotosNextAccess
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
