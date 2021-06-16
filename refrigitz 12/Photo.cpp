#include "Photo.h"


namespace GalleryStudio
{

	Photo::Photo()
	{
		InitializeInstanceFields();
	}

	const int &Photo::getPhotoNumberAccsess() const
	{
		return PhotoNumber;
	}

	void Photo::setPhotoNumberAccsess(const int &value)
	{
	PhotoNumber = value;
	}

	const std::wstring &Photo::getPhotoNameAccess() const
	{
		return PhotoName;

	}

	void Photo::setPhotoNameAccess(const std::wstring &value)
	{
		PhotoName = value;
	}

	const bool &Photo::getPhotoTypeAccess() const
	{
		return PhotoType;
	}

	void Photo::setPhotoTypeAccess(const bool &value)
	{
		PhotoType = value;
	}

	void Photo::InitializeInstanceFields()
	{
		PhotoNumber = int();
		PhotoName = L"";
		PhotoType = bool();
	}
}
