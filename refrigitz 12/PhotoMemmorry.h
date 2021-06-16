#pragma once

#include "Photo.h"
#include <string>
#include <iostream>

namespace GalleryStudio
{

	class PhotoMemmorry
	{
	private:
		static const std::wstring S;
		static GalleryStudio::PhotoMemmorry *Node;
		GalleryStudio::Photo *Current;
		GalleryStudio::PhotoMemmorry *Next;

	public:
		void Load();
		void DeleteObject(PhotoMemmorry *p);
		void AddObject(PhotoMemmorry *p);
		PhotoMemmorry *getPhotosNodeAccess() const;
		void setPhotosNodeAccess(PhotoMemmorry *value);
		Photo *getPhotosCurrentAccess() const;
		void setPhotosCurrentAccess(Photo *value);
		PhotoMemmorry *getPhotosNextAccess() const;
		void setPhotosNextAccess(PhotoMemmorry *value);

	private:
		void InitializeInstanceFields();

public:
		PhotoMemmorry()
		{
			InitializeInstanceFields();
		}
	};
}
