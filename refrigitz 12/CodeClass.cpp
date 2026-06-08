#include "CodeClass.h"


namespace RefrigtzDLL
{

	void CodeClass::SaveByCode(int Code, int LineCode, const std::wstring &File)
	{
		auto O = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		lock (O)
		{
			if (!System::IO::File::Exists(L"CodeLogEvent.log"))
			{
				System::IO::File::CreateText(L"CodeLogEvent.log");
			}
			System::IO::File::AppendAllText(L"CodeLogEvent.log", std::wstring(L"\r\nError by ") + Code + std::wstring(L"At ") + LineCode + std::wstring(L" LinCode of File ") + File);
		}
	}
}
