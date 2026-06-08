#pragma once

#include <string>


namespace GalleryStudio
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class Photo
	class Photo
	{
	private:
		int PhotoNumber;
		std::wstring PhotoName;
		bool PhotoType;
	public:
		Photo();
		const int &getPhotoNumberAccsess() const;
		void setPhotoNumberAccsess(const int &value);
		const std::wstring &getPhotoNameAccess() const;
		void setPhotoNameAccess(const std::wstring &value);
		const bool &getPhotoTypeAccess() const;
		void setPhotoTypeAccess(const bool &value);

	private:
		void InitializeInstanceFields();
	};
}
