//illegal characters cuase to stop sql server operatio
//This class is paren of CMounth class.
//By Ramin Edjlal.Urmia.Iran.
#ifndef _CILLEGALCHARACTERINDATABASE_H
#define _CILLEGALCHARACTERINDATABASE_H

class CIllegalCharacterInDataBase
{
public:
	CIllegalCharacterInDataBase();//Constructor.
	CString RemoveChar(CString csChar);//remove Illegal character in a String
	~CIllegalCharacterInDataBase();//Deconstructor.


};
#endif