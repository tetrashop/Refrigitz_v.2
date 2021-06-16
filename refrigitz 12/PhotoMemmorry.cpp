#include "PhotoMemmorry.h"


namespace GalleryStudio
{

const std::wstring PhotoMemmorry::S = L"Photos.txt";
GalleryStudio::PhotoMemmorry *PhotoMemmorry::Node = new PhotoMemmorry();

	void PhotoMemmorry::Load()
	{
		if (Node == nullptr)
		{
			Node = new PhotoMemmorry();
		}
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
		delete Node->getPhotosNextAccess();
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
		delete Node->getPhotosCurrentAccess();
		try
		{
			FileStream *DummyFileStream = new FileStream(S, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::ReadWrite);
			BinaryFormatter *Formatters = new BinaryFormatter();
			GalleryStudio::Photo *Dummy = new Photo();
			GalleryStudio::PhotoMemmorry *Last = nullptr;
			std::cout << std::wstring(L"Loading...") << std::endl;
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			while (DummyFileStream->Position < DummyFileStream->Length)
			{
				Dummy = static_cast<Photo*>(Formatters->Deserialize(DummyFileStream));
				if (Node->Current == nullptr)
				{
					Node->Current = Dummy;
				}
				else
				{
					Last = Node;
					while (Last->Next != nullptr)
					{
						Last = Last->Next;
					}
					PhotoMemmorry *New = new PhotoMemmorry();
					New->Current = Dummy;
					Last->setPhotosNextAccess(New);
				}
			}
			DummyFileStream->Flush();
			DummyFileStream->Close();
		}
		catch (IOException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
	}

	void PhotoMemmorry::DeleteObject(PhotoMemmorry *p)
	{
		PhotoMemmorry *t = new PhotoMemmorry();
		t = Node;
		if (static_cast < t::getPhotosCurrentAccess()::getPhotoNameAccess()*>(!) = (p->getPhotosCurrentAccess()->getPhotoNameAccess()))
		{
			if (t != nullptr)
			{
				while (static_cast < t::getPhotosNextAccess()::getPhotosCurrentAccess()::getPhotoNameAccess()*>(!) = (p->getPhotosCurrentAccess()->getPhotoNameAccess()))
				{
					if (t->getPhotosNextAccess() != nullptr)
					{
						t = t->getPhotosNextAccess();
					}
					else
					{
					if (static_cast < t::getPhotosCurrentAccess()::getPhotoNameAccess()*>(!) = (p->getPhotosCurrentAccess()->getPhotoNameAccess()))
					{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
						delete t;
						break;
					}
					}
				}
			}
			if (t != nullptr)
			{
				if (t->getPhotosNextAccess() != nullptr)
				{
					t->setPhotosNextAccess(t->getPhotosNextAccess()->getPhotosNextAccess());
				}

				else
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete t->getPhotosNextAccess();
				}
			}

		}
		else
		{
			t = t->getPhotosNextAccess();
			Node = t;
		}
	}

	void PhotoMemmorry::AddObject(PhotoMemmorry *p)
	{
		//p.PhotosNextAccess = null;
		PhotoMemmorry *t = new PhotoMemmorry();
		if (p->getPhotosNodeAccess() != nullptr)
		{
			t = p->getPhotosNodeAccess();
			while (t->getPhotosNextAccess() != nullptr)
			{
				t = t->getPhotosNextAccess();
			}
			if (t->getPhotosCurrentAccess() == nullptr)
			{
				t->setPhotosCurrentAccess(p->getPhotosCurrentAccess());
			}
			else
			{
				t->setPhotosNextAccess(p);
			}
		}
		else
		{
			Node = p;
		}
	}

	PhotoMemmorry *PhotoMemmorry::getPhotosNodeAccess() const
	{
		return Node;
	}

	void PhotoMemmorry::setPhotosNodeAccess(PhotoMemmorry *value)
	{
		Node = value;
	}

	Photo *PhotoMemmorry::getPhotosCurrentAccess() const
	{
		return Current;
	}

	void PhotoMemmorry::setPhotosCurrentAccess(Photo *value)
	{
		Current = value;
	}

	PhotoMemmorry *PhotoMemmorry::getPhotosNextAccess() const
	{
		return Next;
	}

	void PhotoMemmorry::setPhotosNextAccess(PhotoMemmorry *value)
	{
		Next = value;
	}

	void PhotoMemmorry::InitializeInstanceFields()
	{
		Current = new Photo();
		Next = 0;
	}
}
