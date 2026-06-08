#include "TakeImageMemmorry.h"


namespace GalleryStudio
{

const std::wstring TakeImageMemmorry::S = L"TakeImages.txt";
GalleryStudio::TakeImageMemmorry *TakeImageMemmorry::Node = new TakeImageMemmorry();

	void TakeImageMemmorry::Load()
	{
		try
		{
			if (Node == nullptr)
			{
				Node = new TakeImageMemmorry();
			}
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
			delete Node->getTakeImagesNextAccess();
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
			delete Node->getTakeImagesCurrentAccess();

			FileStream *DummyFileStream = new FileStream(S, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::ReadWrite);
			BinaryFormatter *Formatters = new BinaryFormatter();
			GalleryStudio::TakeImage *Dummy = new TakeImage(0, nullptr);
			GalleryStudio::TakeImageMemmorry *Last = nullptr;
			std::cout << std::wstring(L"Loading...") << std::endl;
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			while (DummyFileStream->Position < DummyFileStream->Length)
			{

				Dummy = static_cast<TakeImage*>(Formatters->Deserialize(DummyFileStream));
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
					TakeImageMemmorry *New = new TakeImageMemmorry();
					New->Current = Dummy;
					Last->setTakeImagesNextAccess(New);
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

	void TakeImageMemmorry::DeleteObject(TakeImageMemmorry *p)
	{
		TakeImageMemmorry *t = new TakeImageMemmorry();
		t = Node;
		try
		{
			if (static_cast < t::getTakeImagesCurrentAccess()::getCustomersAcess()*>(!) = (p->getTakeImagesCurrentAccess()->getCustomersAcess()))
			{
				if (t != nullptr)
				{
					while (static_cast < t::getTakeImagesNextAccess()::getTakeImagesCurrentAccess()::getCustomersAcess()*>(!) = (p->getTakeImagesCurrentAccess()->getCustomersAcess()))
					{
						if (t->getTakeImagesNextAccess() != nullptr)
						{
							t = t->getTakeImagesNextAccess();
						}
						else
						{
							if (static_cast < t::getTakeImagesCurrentAccess()::getCustomersAcess()*>(!) = (p->getTakeImagesCurrentAccess()->getCustomersAcess()))
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
					if (t->getTakeImagesNextAccess() != nullptr)
					{
						t->setTakeImagesNextAccess(t->getTakeImagesNextAccess()->getTakeImagesNextAccess());
					}

					else
					{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
						delete t->getTakeImagesNextAccess();
					}
				}

			}
			else
			{
				t = t->getTakeImagesNextAccess();
				Node = t;
			}
		}
		catch (NullReferenceException q)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << q->Message->ToString() << std::endl;

		}
	}

	void TakeImageMemmorry::AddObject(TakeImageMemmorry *p)
	{
		//p.TakeImagesNextAccess = null;
		TakeImageMemmorry *t = new TakeImageMemmorry();
		t = p->getTakeImagesNodeAccess();
		while (t->getTakeImagesNextAccess() != nullptr)
		{
			t = t->getTakeImagesNextAccess();
		}
		 if (t->getTakeImagesCurrentAccess() == nullptr)
		 {
			t->setTakeImagesCurrentAccess(p->getTakeImagesCurrentAccess());
		 }
		 else
		 {
		 t->setTakeImagesNextAccess(p);
		 }

	}

	TakeImageMemmorry *TakeImageMemmorry::getTakeImagesNodeAccess() const
	{
		return Node;
	}

	void TakeImageMemmorry::setTakeImagesNodeAccess(TakeImageMemmorry *value)
	{
		Node = value;
	}

	TakeImage *TakeImageMemmorry::getTakeImagesCurrentAccess() const
	{
		return Current;
	}

	void TakeImageMemmorry::setTakeImagesCurrentAccess(TakeImage *value)
	{
		Current = value;
	}

	TakeImageMemmorry *TakeImageMemmorry::getTakeImagesNextAccess() const
	{
		return Next;
	}

	void TakeImageMemmorry::setTakeImagesNextAccess(TakeImageMemmorry *value)
	{
		Next = value;
	}

	void TakeImageMemmorry::InitializeInstanceFields()
	{
		Current = new TakeImage(0,nullptr);
		Next = 0;
	}
}
