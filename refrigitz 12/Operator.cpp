#include "Operator.h"


namespace GalleryStudio
{

std::wstring Operator::SCustomer = L"Customers.txt";
std::wstring Operator::SPhoto = L"Photos.txt";
std::wstring Operator::STakeImage = L"TakeImages.txt";

	void Operator::RewriteCusomers(CustomerMemmorry *p)
	{
		FileStream *DummyFileStream = nullptr;
		try
		{
			CustomerMemmorry *t = p->getCustomersNodeAccess();
			FileInfo *DummyFileInfo = new FileInfo(SCustomer);
			DummyFileInfo->Delete();
			DummyFileStream = new FileStream(SCustomer, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Write);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			while (t != nullptr)
			{
				Formatters->Serialize(DummyFileStream, t->getCustomersCurrentAccess());
				t = t->getCustomersNextAccess();
			}
			DummyFileStream->Close();
		}
		catch (NullReferenceException o)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << o->Message->ToString() << std::endl;
		}
		catch (IOException o)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << o->Message->ToString() << std::endl;
		}

	}

	Customers *Operator::GetCustumer(int No)
	{
		FileStream *DummyFileStream = nullptr;
		DummyFileStream = new FileStream(SCustomer, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		int p = 0;
		Customers *Dummy = nullptr;
		BinaryFormatter *Formatters = new BinaryFormatter();
		DummyFileStream->Seek(0,SeekOrigin::Begin);
		try
		{
			while (p <= No)
			{
				if (DummyFileStream->Length >= DummyFileStream->Position)
				{
					Dummy = static_cast<Customers*>(Formatters->Deserialize(DummyFileStream));
				}
				else
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy;
				}
				p++;
			}
			DummyFileStream->Flush();
			DummyFileStream->Close();
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
			delete Dummy;
		}
		return Dummy;
	}

	Photo *Operator::GetPhoto(int No)
	{
		FileStream *DummyFileStream = nullptr;
		DummyFileStream = new FileStream(SPhoto, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		int p = 0;
		Photo *Dummy = nullptr;
		BinaryFormatter *Formatters = new BinaryFormatter();
		DummyFileStream->Seek(0, SeekOrigin::Begin);
		try
		{
			while (p <= No)
			{
				if (DummyFileStream->Length > DummyFileStream->Position)
				{
					Dummy = static_cast<Photo*>(Formatters->Deserialize(DummyFileStream));
				}
				else
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy;
					break;
				}
				p++;
			}
			DummyFileStream->Flush();
			DummyFileStream->Close();
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		return Dummy;
	}

	TakeImage *Operator::GetTakeImage(int No)
	{
		FileStream *DummyFileStream = nullptr;
		DummyFileStream = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		int p = 0;
		TakeImage *Dummy = nullptr;
		BinaryFormatter *Formatters = new BinaryFormatter();
		DummyFileStream->Seek(0, SeekOrigin::Begin);
		try
		{
			while (p <= No)
			{
				if (DummyFileStream->Length >= DummyFileStream->Position)
				{
					Dummy = static_cast<TakeImage*>(Formatters->Deserialize(DummyFileStream));
				}
				else
				{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
					delete Dummy;
				}
				p++;
			}
			DummyFileStream->Flush();
			DummyFileStream->Close();
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		return Dummy;
	}

	void Operator::RewritePhotos(PhotoMemmorry *p)
	{
		FileStream *DummyFileStream = nullptr;
		try
		{
			PhotoMemmorry *t = p->getPhotosNodeAccess();
			FileInfo *DummyFileInfo = new FileInfo(SPhoto);
			DummyFileInfo->Delete();
			DummyFileStream = new FileStream(SPhoto, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Write);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			while (t != nullptr)
			{
				Formatters->Serialize(DummyFileStream, t->getPhotosCurrentAccess());
				t = t->getPhotosNextAccess();
			}
			DummyFileStream->Close();
		}
		catch (NullReferenceException o)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << o->Message->ToString() << std::endl;
		}
		catch (IOException o)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << o->Message->ToString() << std::endl;
		}

	}

	void Operator::RewriteTakeImage(TakeImageMemmorry *p)
	{
		FileStream *DummyFileStream = nullptr;
		try
		{
			TakeImageMemmorry *t = p->getTakeImagesNodeAccess();
			FileInfo *DummyFileInfo = new FileInfo(STakeImage);
			DummyFileInfo->Delete();
			DummyFileStream = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Write);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			while (t != nullptr)
			{
				Formatters->Serialize(DummyFileStream, t->getTakeImagesCurrentAccess());
				t = t->getTakeImagesNextAccess();
			}
			DummyFileStream->Close();
		}
		catch (NullReferenceException o)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << o->Message->ToString() << std::endl;
		}
		catch (IOException o)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << o->Message->ToString() << std::endl;
		}

	}

	void Operator::PrintCustomers(std::wstring& Dummy[])
	{

		int k = 0;
		while (k < 15)
		{
			if (Dummy[0].length() > k)
			{
				std::cout << Dummy[0].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[1].length() > k)
			{
				std::cout << Dummy[1].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[2].length() > k)
			{
				std::cout << Dummy[2].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[3].length() > k)
			{
				std::cout << Dummy[3].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[4].length() > k)
			{
				std::cout << Dummy[4].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}

		std::cout << std::wstring(L"") << std::endl;
	}

	void Operator::PrintPhotos(std::wstring& Dummy[])
	{

		int k = 0;
		while (k < 15)
		{
			if (Dummy[0].length() > k)
			{
				std::cout << Dummy[0].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[1].length() > k)
			{
				std::cout << Dummy[1].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[2].length() > k)
			{
				std::cout << Dummy[2].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}
		std::cout << std::wstring(L"") << std::endl;
	}

	void Operator::PrintTakeImage(const std::wstring &Dummy)
	{

		int k = 0;
		while (k < 15)
		{
			if (Dummy.length() > k)
			{
				std::cout << Dummy.ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		std::cout << std::wstring(L"") << std::endl;
	}

	void Operator::PCustomersRemark()
	{
		std::cout << std::wstring(L"Customers:") << std::endl;

		std::wstring Dummy[5] = {L"CustomerID", L"Name", L"FamilyName", L"Address", L"TelephonNumber"};
		int k = 0;
		while (k < 15)
		{
			if (Dummy[0].length() > k)
			{
				std::cout << Dummy[0].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[1].length() > k)
			{
				std::cout << Dummy[1].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[2].length() > k)
			{
				std::cout << Dummy[2].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[3].length() > k)
			{
				std::cout << Dummy[3].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[4].length() > k)
			{
				std::cout << Dummy[4].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}

		std::cout << std::wstring(L"") << std::endl;
	}

	void Operator::PCustomers()
	{
		Operator::PCustomersRemark();
		Customers *DummyOutput = new Customers();
		FileStream *Customer = new FileStream(SCustomer, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		BinaryFormatter *formatters = new BinaryFormatter();

		Customer->Seek(0, SeekOrigin::Begin);
		while (Customer->Position < Customer->Length)
		{
			DummyOutput = static_cast<Customers*>(formatters->Deserialize(Customer));
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::wstring DummyString[5] = {StringConverterHelper::toString(DummyOutput->getCustomersCustomerID()), DummyOutput->getCustomersName().ToString(), DummyOutput->getCustomersFamilyName().ToString(), DummyOutput->getCustomersAddress().ToString(), StringConverterHelper::toString(DummyOutput->getCustomersTellefon())};
			Operator::PrintCustomers(DummyString);
		}
		Customer->Flush();
		Customer->Close();
	}

	void Operator::PhPhotoRemark()
	{
		std::cout << std::wstring(L"Photo:") << std::endl;
		std::wstring Dummy[3] = {L"PhotoNumber", L"PhotoName", L"PhotoType"};
		int k = 0;
		while (k < 15)
		{
			if (Dummy[0].length() > k)
			{
				std::cout << Dummy[0].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[1].length() > k)
			{
				std::cout << Dummy[1].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}
			k++;
		}
		k = 0;
		while (k < 15)
		{
			if (Dummy[2].length() > k)
			{
				std::cout << Dummy[2].ToCharArray(k, 1);
			}
			else
			{
				std::cout << L' ';
			}

			k++;
		}
		std::cout << std::wstring(L"") << std::endl;
	}

	void Operator::PPhoto()
	{
		Operator::PhPhotoRemark();
		Photo *DummyOutput = new Photo();
//C# TO C++ CONVERTER NOTE: The variable Photo was renamed since it is named the same as a user-defined type:
		FileStream *Photo_Renamed = new FileStream(SPhoto, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		BinaryFormatter *formatters = new BinaryFormatter();

		Photo_Renamed->Seek(0, SeekOrigin::Begin);
		while (Photo_Renamed->Position < Photo_Renamed->Length)
		{
			DummyOutput = static_cast<Photo*>(formatters->Deserialize(Photo_Renamed));
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
		  std::wstring DummyString[3] = {StringConverterHelper::toString(DummyOutput->getPhotoNumberAccsess()), DummyOutput->getPhotoNameAccess().ToString(), L"\0"};
			if (DummyOutput->getPhotoTypeAccess())
			{
				DummyString[2] = L"Color";
			}
			else
			{
				DummyString[2] = L"BlackWhite";
			}
			Operator::PrintPhotos(DummyString);
		}
		Photo_Renamed->Flush();
		Photo_Renamed->Close();
	}

	void Operator::PTakeImage()
	{
		std::cout << std::wstring(L"TakeIamge:") << std::endl;

		TakeImage *DummyOutput = new TakeImage(0,nullptr);
//C# TO C++ CONVERTER NOTE: The variable TakeImage was renamed since it is named the same as a user-defined type:
		FileStream *TakeImage_Renamed = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		BinaryFormatter *formatters = new BinaryFormatter();

		TakeImage_Renamed->Seek(0, SeekOrigin::Begin);
		while (TakeImage_Renamed->Position < TakeImage_Renamed->Length)
		{
		  DummyOutput = static_cast<TakeImage*>(formatters->Deserialize(TakeImage_Renamed));
		  std::wstring DummyString = StringConverterHelper::toString(DummyOutput->getPhotoNumberAccess());
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
		  std::wstring Dummy[5] = {StringConverterHelper::toString(DummyOutput->getCustomersAcess()->getCustomersCustomerID()), DummyOutput->getCustomersAcess()->getCustomersName().ToString(), DummyOutput->getCustomersAcess()->getCustomersFamilyName().ToString(), DummyOutput->getCustomersAcess()->getCustomersAddress().ToString(), StringConverterHelper::toString(DummyOutput->getCustomersAcess()->getCustomersTellefon())};
			std::cout << std::wstring(L"Customer:") << std::endl;
		  Operator::PrintCustomers(Dummy);
		  std::cout << std::wstring(L"PhotoNumber:") << std::endl;
		  Operator::PrintTakeImage(DummyString);
		  std::cout << std::wstring(L"The Date is:");
		  std::cout << StringConverterHelper::toString(DummyOutput->getYearAccess()) << std::wstring(L":") << StringConverterHelper::toString(DummyOutput->getMonthAccess()) << std::wstring(L":") << StringConverterHelper::toString(DummyOutput->getDayAccess()) << std::endl;
		  for (int i = 0; i < 50; i++)
		  {
			  std::cout << std::wstring(L"=");
		  }
		  std::cout << std::wstring(L"") << std::endl;
		}
		TakeImage_Renamed->Flush();
		TakeImage_Renamed->Close();
	}

	Photo *Operator::GetPhotoFromDateFromTakeImageMemory(std::wstring& Date[], int &Total)
	{

		TakeImage *DummyOutput = new TakeImage(0, nullptr);
//C# TO C++ CONVERTER NOTE: The variable TakeImage was renamed since it is named the same as a user-defined type:
		FileStream *TakeImage_Renamed = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		BinaryFormatter *formatters = new BinaryFormatter();
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: Photo[] Dummy = nullptr;
		Photo *Dummy = nullptr;
		Photo DummyPhoto[1000];
		TakeImage_Renamed->Seek(0, SeekOrigin::Begin);
		Total = 0;
		int Dimention = -1;
		try
		{
			while (TakeImage_Renamed->Position < TakeImage_Renamed->Length)
			{
				DummyOutput = static_cast<TakeImage*>(formatters->Deserialize(TakeImage_Renamed));

				if (StringConverterHelper::toString(DummyOutput->getYearAccess()) == Date[0])
				{
					if (StringConverterHelper::toString(DummyOutput->getMonthAccess()) == Date[1])
					{
						if (StringConverterHelper::toString(DummyOutput->getDayAccess()) == Date[2])
						{
							Dummy = Operator::GetPhotoFromPhotoNumberOfDate(DummyOutput->getPhotoNumberAccess(), Dimention);
						}
					}
				}
				if (Dimention > -1)
				{
					for (int i = Total; i < Total + Dimention; i++)
					{
						DummyPhoto[i] = Dummy[i - Total];
					}
					Total = Total + Dimention;
				}
				Dimention = -1;
			}
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		TakeImage_Renamed->Flush();
		TakeImage_Renamed->Close();
		return DummyPhoto;
	}

	Customers *Operator::GetCustomersFromDate(std::wstring& Date[], int &Total)
	{

		TakeImage *DummyOutput = new TakeImage(0, nullptr);
//C# TO C++ CONVERTER NOTE: The variable TakeImage was renamed since it is named the same as a user-defined type:
		FileStream *TakeImage_Renamed = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
		BinaryFormatter *formatters = new BinaryFormatter();
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: Customers[] Dummy = nullptr;
		Customers *Dummy = nullptr;
		Customers DummyPhoto[1000];
		TakeImage_Renamed->Seek(0, SeekOrigin::Begin);
		Total = 0;
		int Dimention = -1;
		try
		{
			while (TakeImage_Renamed->Position < TakeImage_Renamed->Length)
			{
				DummyOutput = static_cast<TakeImage*>(formatters->Deserialize(TakeImage_Renamed));

				if (StringConverterHelper::toString(DummyOutput->getYearAccess()) == Date[0])
				{
					if (StringConverterHelper::toString(DummyOutput->getMonthAccess()) == Date[1])
					{
						if (StringConverterHelper::toString(DummyOutput->getDayAccess()) == Date[2])
						{
							Dummy = Operator::GetCustomerFromPhotoNumberOfDate(DummyOutput->getPhotoNumberAccess(), Dimention);
						}
					}
				}
				if (Dimention > -1)
				{
					for (int i = Total; i < Total + Dimention; i++)
					{
						DummyPhoto[i] = Dummy[i - Total];
					}
					Total = Total + Dimention;
				}
				Dimention = -1;
			}
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		TakeImage_Renamed->Flush();
		TakeImage_Renamed->Close();
		return DummyPhoto;
	}

	Photo *Operator::GetPhotoFromCustomerID(int CustomerNumber, int &Total)
	{
		FileStream *DummyFileStream = nullptr;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: Photo[] PhotoDummy = nullptr;
		Photo *PhotoDummy = nullptr;
		Photo TotalPhotoDummy[1000];
		Total = 0;
		int Dimension = -1;
		try
		{
			PhotoMemmorry *t = new PhotoMemmorry();
			DummyFileStream = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0,SeekOrigin::Begin);
					TakeImage *DummyOutput = nullptr;
					while (DummyFileStream->Position < DummyFileStream->Length)
					{
						DummyOutput = static_cast<TakeImage*>(Formatters->Deserialize(DummyFileStream));
						if (DummyOutput->getCustomersAcess()->getCustomersCustomerID() == CustomerNumber)
						{
							PhotoDummy = Operator::GetPhotoFromPhotoFile(DummyOutput->getPhotoNumberAccess(),Dimension);
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
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		DummyFileStream->Flush();
		DummyFileStream->Close();
		return TotalPhotoDummy;

	}

	Photo *Operator::GetPhotoFromPhotoNumberOfDate(int PhotoNumber, int &Total)
	{
		FileStream *DummyFileStream = nullptr;
//C# TO C++ CONVERTER WARNING: Since the array size is not known in this declaration, C# to C++ Converter has converted this array to a pointer.  You will need to call 'delete[]' where appropriate:
//ORIGINAL LINE: Photo[] PhotoDummy = nullptr;
		Photo *PhotoDummy = nullptr;
		Photo TotalPhotoDummy[1000];
		Total = 0;
		int Dimension = -1;
		try
		{
			PhotoMemmorry *t = new PhotoMemmorry();
			DummyFileStream = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			TakeImage *DummyOutput = nullptr;
			while (DummyFileStream->Position < DummyFileStream->Length)
			{
				DummyOutput = static_cast<TakeImage*>(Formatters->Deserialize(DummyFileStream));
				if (DummyOutput->getPhotoNumberAccess() == PhotoNumber)
				{
					PhotoDummy = Operator::GetPhotoFromPhotoFile(DummyOutput->getPhotoNumberAccess(), Dimension);
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
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		DummyFileStream->Flush();
		DummyFileStream->Close();
		return TotalPhotoDummy;

	}

	Customers *Operator::GetCustomerFromPhotoNumberOfDate(int PhotoNumber, int &Total)
	{
		FileStream *DummyFileStream = nullptr;
		Customers *CustomersDummy = nullptr;
		Customers TotalCustomersDummy[1000];
		Total = 0;
		//int Dimension = -1;
		try
		{
			PhotoMemmorry *t = new PhotoMemmorry();
			DummyFileStream = new FileStream(STakeImage, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			TakeImage *DummyOutput = nullptr;
			while (DummyFileStream->Position < DummyFileStream->Length)
			{
				DummyOutput = static_cast<TakeImage*>(Formatters->Deserialize(DummyFileStream));
				if (DummyOutput->getPhotoNumberAccess() == PhotoNumber)
				{
					CustomersDummy = DummyOutput->getCustomersAcess();
					TotalCustomersDummy[Total] = CustomersDummy;
					Total++;
				}
			}
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		DummyFileStream->Flush();
		DummyFileStream->Close();
		return TotalCustomersDummy;

	}

	Photo *Operator::GetPhotoFromPhotoFile(int PhotNumber, int &Dimenstion)
	{
		FileStream *DummyFileStream = nullptr;
		Photo PhotoDummy[1000];
		try
		{
			Dimenstion = -1;
			PhotoMemmorry *t = new PhotoMemmorry();
			DummyFileStream = new FileStream(SPhoto, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			Photo *DummyOutput = nullptr;
			while (DummyFileStream->Position < DummyFileStream->Length)
			{
				DummyOutput = static_cast<Photo*>(Formatters->Deserialize(DummyFileStream));

				if (DummyOutput->getPhotoNumberAccsess() == PhotNumber)
				{
					Dimenstion++;
					PhotoDummy[Dimenstion] = new Photo();
					PhotoDummy[Dimenstion] = DummyOutput;
				}
			}
		}
		catch (SerializationException t)
		{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
			std::cout << t->Message->ToString() << std::endl;
		}
		return PhotoDummy;
	}
}
