#pragma once

#include "CustomerMemmorry.h"
#include "Customers.h"
#include "Photo.h"
#include "TakeImage.h"
#include "PhotoMemmorry.h"
#include "TakeImageMemmorry.h"
#include <string>
#include <iostream>
#include "stringconverter.h"


namespace GalleryStudio
{
	class Operator final
	{
	private:
		static std::wstring SCustomer;
		static std::wstring SPhoto;
		static std::wstring STakeImage;
	public:
		static void RewriteCusomers(CustomerMemmorry *p);
		static Customers *GetCustumer(int No);
		static Photo *GetPhoto(int No);
		static TakeImage *GetTakeImage(int No);

		static void RewritePhotos(PhotoMemmorry *p);
		static void RewriteTakeImage(TakeImageMemmorry *p);

		static void PrintCustomers(std::wstring& Dummy[]);
		static void PrintPhotos(std::wstring& Dummy[]);
		static void PrintTakeImage(const std::wstring &Dummy);
		static void PCustomersRemark();
		static void PCustomers();
		static void PhPhotoRemark();
		static void PPhoto();
		static void PTakeImage();
		static Photo *GetPhotoFromDateFromTakeImageMemory(std::wstring& Date[], int &Total);
		static Customers *GetCustomersFromDate(std::wstring& Date[], int &Total);
		static Photo *GetPhotoFromCustomerID(int CustomerNumber, int &Total);
		static Photo *GetPhotoFromPhotoNumberOfDate(int PhotoNumber, int &Total);
		static Customers *GetCustomerFromPhotoNumberOfDate(int PhotoNumber, int &Total);

	private:
		static Photo *GetPhotoFromPhotoFile(int PhotNumber, int &Dimenstion);
	};

}
