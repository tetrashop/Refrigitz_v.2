#include "Resources.Designer.h"

namespace All
{
	namespace Properties
	{

		Resources::Resources()
		{
		}

		System::Resources::ResourceManager *Resources::getResourceManager() const
		{
			if (Object::ReferenceEquals(resourceMan, nullptr))
			{
				System::Resources::ResourceManager *temp = new System::Resources::ResourceManager(L"All.Properties.Resources", Resources::typeid->Assembly);
				resourceMan = temp;
			}
			return resourceMan;
		}

		System::Globalization::CultureInfo *Resources::getCulture() const
		{
			return resourceCulture;
		}

		void Resources::setCulture(System::Globalization::CultureInfo *value)
		{
			resourceCulture = value;
		}

		const std::wstring &Resources::getApp_xaml() const
		{
			return getResourceManager()->GetString(L"App_xaml", resourceCulture);
		}
	}
}
