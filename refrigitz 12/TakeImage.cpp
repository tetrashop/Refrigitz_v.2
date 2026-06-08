#include "TakeImage.h"


namespace GalleryStudio
{

	TakeImage::TakeImage(int Senderint, Customers *SenderCustomer)
	{
		InitializeInstanceFields();
		if (Senderint != 0)
		{
			if (SenderCustomer != nullptr)
			{
				Day = DateTime::Today.Day;
				Month = DateTime::Today.Month;
				Year = DateTime::Today.Year;
				PhotoNumber = Senderint;
				CustomerObject = SenderCustomer;
			}
		}
	}

	const int &TakeImage::getDayAccess() const
	{
		return Day;
	}

	void TakeImage::setDayAccess(const int &value)
	{
		Day = value;
	}

	const int &TakeImage::getMonthAccess() const
	{
		return Month;
	}

	void TakeImage::setMonthAccess(const int &value)
	{
		Month = value;
	}

	const int &TakeImage::getYearAccess() const
	{
		return Year;
	}

	void TakeImage::setYearAccess(const int &value)
	{
		Year = value;
	}

	const int &TakeImage::getPhotoNumberAccess() const
	{
		return PhotoNumber;
	}

	void TakeImage::setPhotoNumberAccess(const int &value)
	{
		PhotoNumber = value;
	}

	Customers *TakeImage::getCustomersAcess() const
	{
		return CustomerObject;
	}

	void TakeImage::setCustomersAcess(Customers *value)
	{
		CustomerObject = value;
	}

	void TakeImage::InitializeInstanceFields()
	{
		Day = int();
		Month = int();
		Year = int();
		PhotoNumber = int();
		CustomerObject = new Customers();
	}
}
