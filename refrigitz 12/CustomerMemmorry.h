#pragma once

#include "Customers.h"
#include <string>
#include <iostream>

namespace GalleryStudio
{

	class CustomerMemmorry
	{
	private:
		static const std::wstring S;
		static GalleryStudio::CustomerMemmorry *Node;
		GalleryStudio::Customers *Current;
		GalleryStudio::CustomerMemmorry *Next;
	public:
		void Load();
		void DeleteObject(CustomerMemmorry *p);
		void AddObject(CustomerMemmorry *p);
		CustomerMemmorry *getCustomersNodeAccess() const;
		void setCustomersNodeAccess(CustomerMemmorry *value);
		Customers *getCustomersCurrentAccess() const;
		void setCustomersCurrentAccess(Customers *value);
		CustomerMemmorry *getCustomersNextAccess() const;
		void setCustomersNextAccess(CustomerMemmorry *value);

	private:
		void InitializeInstanceFields();

public:
		CustomerMemmorry()
		{
			InitializeInstanceFields();
		}
	};
}
