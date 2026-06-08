#include "Customers.h"


namespace GalleryStudio
{

int Customers::NumberOfObjects = 0;

	Customers::Customers()
	{

		InitializeInstanceFields();
	}

	const int &Customers::getCustomenrNumberOfObjectsAccess() const
	{
		return NumberOfObjects;
	}

	void Customers::setCustomenrNumberOfObjectsAccess(const int &value)
	{
		NumberOfObjects = value;
	}

	const int &Customers::getCustomersCustomerID() const
	{
		return CustomerID;
	}

	void Customers::setCustomersCustomerID(const int &value)
	{
		CustomerID = value;
	}

	const std::wstring &Customers::getCustomersName() const
	{
		return Name;
	}

	void Customers::setCustomersName(const std::wstring &value)
	{
		Name = value;
	}

	const std::wstring &Customers::getCustomersFamilyName() const
	{
		return FamilyName;
	}

	void Customers::setCustomersFamilyName(const std::wstring &value)
	{
		FamilyName = value;
	}

	const std::wstring &Customers::getCustomersAddress() const
	{
		return Address;
	}

	void Customers::setCustomersAddress(const std::wstring &value)
	{
		Address = value;
	}

	const int &Customers::getCustomersTellefon() const
	{
		return TelephonNumber;
	}

	void Customers::setCustomersTellefon(const int &value)
	{
		TelephonNumber = value;
	}

	void Customers::InitializeInstanceFields()
	{
		CustomerID = int();
		Name = std::wstring(NULL,20);
		FamilyName = std::wstring(NULL,20);
		Address = std::wstring(NULL,20);
		TelephonNumber = int();
	}
}
