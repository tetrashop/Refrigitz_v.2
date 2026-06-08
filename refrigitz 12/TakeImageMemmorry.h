#pragma once

#include "TakeImage.h"
#include <string>
#include <iostream>

namespace GalleryStudio
{

	class TakeImageMemmorry
	{
	private:
		static const std::wstring S;
		static GalleryStudio::TakeImageMemmorry *Node;
		GalleryStudio::TakeImage *Current;
		GalleryStudio::TakeImageMemmorry *Next;

	public:
		void Load();
		void DeleteObject(TakeImageMemmorry *p);
		void AddObject(TakeImageMemmorry *p);
		TakeImageMemmorry *getTakeImagesNodeAccess() const;
		void setTakeImagesNodeAccess(TakeImageMemmorry *value);
		TakeImage *getTakeImagesCurrentAccess() const;
		void setTakeImagesCurrentAccess(TakeImage *value);
		TakeImageMemmorry *getTakeImagesNextAccess() const;
		void setTakeImagesNextAccess(TakeImageMemmorry *value);

	private:
		void InitializeInstanceFields();

public:
		TakeImageMemmorry()
		{
			InitializeInstanceFields();
		}
	};
}
