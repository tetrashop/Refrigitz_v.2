#pragma once

#include <string>


namespace GalleryStudio
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class Customers
	class Customers
	{
	private:
		static int NumberOfObjects;
		static const wchar_t NULL = L'\0';

		int CustomerID;
		std::wstring Name;
		std::wstring FamilyName;
		std::wstring Address;
		int TelephonNumber;

	public:
		Customers();
		const int &getCustomenrNumberOfObjectsAccess() const;
		void setCustomenrNumberOfObjectsAccess(const int &value);
		const int &getCustomersCustomerID() const;
		void setCustomersCustomerID(const int &value);
		const std::wstring &getCustomersName() const;
		void setCustomersName(const std::wstring &value);
		const std::wstring &getCustomersFamilyName() const;
		void setCustomersFamilyName(const std::wstring &value);
		const std::wstring &getCustomersAddress() const;
		void setCustomersAddress(const std::wstring &value);
		const int &getCustomersTellefon() const;
		void setCustomersTellefon(const int &value);


	private:
		void InitializeInstanceFields();
	};
}
