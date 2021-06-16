#pragma once

#include "Customers.h"


namespace GalleryStudio
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class TakeImage
	class TakeImage
	{
	private:
		int Day;
		int Month;
		int Year;

		int PhotoNumber;

		Customers *CustomerObject;

	public:
		TakeImage(int Senderint, Customers *SenderCustomer);
		const int &getDayAccess() const;
		void setDayAccess(const int &value);
		const int &getMonthAccess() const;
		void setMonthAccess(const int &value);
		const int &getYearAccess() const;
		void setYearAccess(const int &value);
		const int &getPhotoNumberAccess() const;
		void setPhotoNumberAccess(const int &value);
		Customers *getCustomersAcess() const;
		void setCustomersAcess(Customers *value);

	private:
		void InitializeInstanceFields();
	};
}
