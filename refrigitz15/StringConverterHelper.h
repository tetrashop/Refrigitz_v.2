#pragma once
#include "stdafx.h"
#include <sstream>
//----------------------------------------------------------------------------------------
//	Copyright © 2004 - 2014 Tangible Software Solutions Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class is used to replace some conversions to or from strings.
//----------------------------------------------------------------------------------------


namespace RefrigtzDLL {
	class StringConverterHelper
	{
	public:
		template<typename T>
		static std::wstring toString(const T &subject)
		{
			std::wostringstream ss;
			ss << subject;
			return ss.str();
		}

		template<typename T>
		static T fromString(const std::wstring &subject)
		{
			std::wistringstream ss(subject);
			T target;
			ss >> target;
			return target;
		}
	};
}