#include "CustomerMemmorry.h"


namespace GalleryStudio
{

const std::wstring CustomerMemmorry::S = L"Customers.txt";
GalleryStudio::CustomerMemmorry *CustomerMemmorry::Node = new CustomerMemmorry();

	void CustomerMemmorry::Load()
	{
		if (Node == nullptr)
		{
			Node = new CustomerMemmorry();
		}
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
		delete Node->getCustomersNextAccess();
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
		delete Node->getCustomersCurrentAccess();
		try
		{
			FileStream *DummyFileStream = new FileStream(S, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::ReadWrite);
			BinaryFormatter *Formatters = new BinaryFormatter();
			GalleryStudio::Customers *Dummy = new Customers();
			GalleryStudio::CustomerMemmorry *Last = nullptr;
			std::cout << std::wstring(L"Loading...") << std::endl;
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			while (DummyFileStream->Position < DummyFileStream->Length)
			{
				Dummy = static_cast<Customers*>(Formatters->Deserialize(DummyFileStream));
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
					CustomerMemmorry *New = new CustomerMemmorry();
					New->Current = Dummy;
					Last->setCustomersNextAccess(New);
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

	void CustomerMemmorry::DeleteObject(CustomerMemmorry *p)
	{
		CustomerMemmorry *t = new CustomerMemmorry();
		t = Node;
		if (static_cast < t::getCustomersCurrentAccess()::getCustomersName()*>(!) = (p->getCustomersCurrentAccess()->getCustomersName()))
		{
			if (t != nullptr)
			{
				while (static_cast < t::getCustomersNextAccess()::getCustomersCurrentAccess()::getCustomersName()*>(!) = (p->getCustomersCurrentAccess()->getCustomersName()))
				{
					if (t->getCustomersNextAccess() != nullptr)
					{
						t = t->getCustomersNextAccess();
					}
					else
					{
					if (static_cast < t::getCustomersCurrentAccess()::getCustomersName()*>(!) = (p->getCustomersCurrentAccess()->getCustomersName()))
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
				if (t->getCustomersNextAccess() != nullptr)
				{
					t->setCustomersNextAccess(t->getCustomersNextAccess()->getCustomersNextAccess());
				}

				else
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete t->getCustomersNextAccess();
				}
			}

		}
		else
		{
			t = t->getCustomersNextAccess();
			Node = t;
		}
	}

	void CustomerMemmorry::AddObject(CustomerMemmorry *p)
	{
		CustomerMemmorry *t = new CustomerMemmorry();
		t = p->getCustomersNodeAccess();
		while (t->getCustomersNextAccess() != nullptr)
		{
			t = t->getCustomersNextAccess();
		}
		 if (t->getCustomersCurrentAccess() == nullptr)
		 {
			t->setCustomersCurrentAccess(p->getCustomersCurrentAccess());
		 }
		 else
		 {
		 t->setCustomersNextAccess(p);
		 }
	}

	CustomerMemmorry *CustomerMemmorry::getCustomersNodeAccess() const
	{
		return Node;
	}

	void CustomerMemmorry::setCustomersNodeAccess(CustomerMemmorry *value)
	{
		Node = value;
	}

	Customers *CustomerMemmorry::getCustomersCurrentAccess() const
	{
		return Current;
	}

	void CustomerMemmorry::setCustomersCurrentAccess(Customers *value)
	{
		Current = value;
	}

	CustomerMemmorry *CustomerMemmorry::getCustomersNextAccess() const
	{
		return Next;
	}

	void CustomerMemmorry::setCustomersNextAccess(CustomerMemmorry *value)
	{
		Next = value;
	}

	void CustomerMemmorry::InitializeInstanceFields()
	{
		Current = new Customers();
		Next = 0;
	}
}
