#pragma once

#include "AllDraw.h"


namespace RefrigtzDLL
{
//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public static class TakeRoot
	class TakeRoot final
	{
	private:
		static AllDraw *Node;
		//  POINTER IS THE MEMMERY LOCATION OF LAST MOVMENTS.
	public:
		static AllDraw *Pointer;

		static void CalculateRootGray(AllDraw *Curent);

	};
}
