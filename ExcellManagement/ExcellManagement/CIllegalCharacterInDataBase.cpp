//illegal characters cause to stop sql server operatio
//This class is parent of CMounth class.
//By Ramin Edjlal.Urmia.Iran.

#include "stdafx.h"
//Constructor.
CIllegalCharacterInDataBase::CIllegalCharacterInDataBase()
{}

//Predefined explained remover illegall character finder.
CString CIllegalCharacterInDataBase::RemoveChar(CString csChar)
{
//Used for ramin drive illegal character.
csChar.Replace(L"[",L"_");

csChar.Replace(L"]",L"_");

csChar.Replace(L"'",L"_");

csChar.Replace(L".",L"_");

//Unused predefined illegall charcter.

/*

csChar.Replace("$","_");

csChar.Replace("~","_");

csChar.Replace("!","_");

csChar.Replace("@","_");

csChar.Replace("%","_");

csChar.Replace("^","_");

csChar.Replace("&","_");

csChar.Replace(L"*","_");

csChar.Replace("(","_");

csChar.Replace(")","_");



csChar.Replace("+","_");

csChar.Replace("=","_");

csChar.Replace("\\","_");

csChar.Replace("|","_");

csChar.Replace("}","_");

csChar.Replace("{","_");

csChar.Replace(":","_");

csChar.Replace("\"","_");

csChar.Replace("?","_");

csChar.Replace(L".","_");

csChar.Replace(",","_");

csChar.Replace(">","_");

csChar.Replace("<","_");


*/
return csChar;
}

//Deconstructor.
CIllegalCharacterInDataBase::~CIllegalCharacterInDataBase()
{}