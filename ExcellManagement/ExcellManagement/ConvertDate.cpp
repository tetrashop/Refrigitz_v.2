// Date:2005 / 5 / 30
// Programmer : Behzad Bahjat Manesh Ardakan (Iranian)
// ConvertDate.cpp
//===================================================
#include "stdafx.h"



#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif


CConvertDate::CConvertDate()
{

}
CConvertDate::~CConvertDate()
{

}

//===============================================//

int CConvertDate::OutDateGregorian(int D,int M,int Y,int what)//what ==> 0Day 1Month 2Year 
{

	
			int inty=Y;
			int xxx=1379,i=0;
			BOOL m_ok;

			do
			{
					i++;

					if(inty==xxx)
					{m_ok=TRUE;
					break;
					}
					else
					{
					m_ok=FALSE;
					xxx=xxx+4;//----------”«· ﬂ»Ì”Â Â— çÂ«— ”«· Ìﬂ»«—-----
					}

			}while(i<30);

if(m_ok==TRUE) 
{return OutDateGregorian_k( D, M, Y, what);}


int m,r;
int R;
R=D;

if(M==1 && R<12)
{
	m=3;
	r=R+20;
}
else if(M==1 && R>=12)
{
	m=4;
	r=R-11;
}


if(M==2 && R<11)
{

	m=4;
	r=R+20;
}
else if( M==2 && R>=11)
{
	m=5;
	r=R-10;
}


if(M==3 && R<11)
{
	m=5;
	r=R+21;
}
else if( M==3 && R>=11)
{
	m=6;
	r=R-10;
}





if(M==4 && R<10)
{
	m=6;
	r=R+21;
}
else if(M==4 && R>=10)
{
	m=7;
	r=R-9;
}


if(M==5 && R<10)
{
	m=7;
	r=R+22;
}
else if(M==5 && R>=10)
{
	m=8;
	r=R-9;
}






if(M==6 && R<10)
{
	m=8;
	r=R+22;
}
else if(M==6 && R>=10)
{
	m=9;
	r=R-9;
}




if(M==7 && R<9)
{
	m=9;
	r=R+22;
}
else if( M==7 && R>=9)
{
	m=10;
	r=R-8;
}





//This Section is Corrected Until "***" By Ramin Edjlal. 1392/09/29
//Instead of m=11 we replace m=10 and instead of m=12 we replace m=11

if(M==8 && R<10)
{
	m=10;
	r=R+22;
}
else if(M==8 && R>=10)
{
	m=11;
	r=R-9;
}


//"***"

if(M==9 && R<10)
{
	m=11;
	r=R+21;
}
else if(M==9 && R>=10)
{
	m=12;
	r=R-9;
}


//-----------

Y=Y+621;

if(M==10 && R<11 )
{
	m=12;
	r=R+21;
	//Y++;
}
else if(M==10 && R>=11)
{
	m=1;
	r=R-10;
	Y++;
}




if(M==11 && R<12)
{
	m=1;
	r=R+20;
	Y++;
}
else if(M==11 && R>=12)
{
	m=2;
	r=R-11;
	Y++;
}





if(M==12 && R<10)
{
	m=2;
	r=R+19;
	Y++;
}
else if(M==12 && R>=10)
{
	m=3;
	r=R-9;
	Y++;
}


if(what==0)
return r;//return Day
else if(what==1) return m;//return month
else if(what==2) return Y;//return Year

return 3;//return error
	 
}



int CConvertDate::OutDateGregorian_k(int D,int M,int Y,int what)//<< input Year Kabiseh >> what ==> 0Day 1Month 2Year 
{

		//***********************
int m,r;
int R;
R=D;


if(M==1 && R<13)
{
	m=3;
	r=R+19;
}
else if(M==1 && R>=13)
{
	m=4;
	r=R-12;
}


if(M==2 && R<12)
{

	m=4;
	r=R+19;
}
else if( M==2 && R>=12)
{
	m=5;
	r=R-11;
}


if(M==3 && R<12)
{
	m=5;
	r=R+20;
}
else if( M==3 && R>=12)
{
	m=6;
	r=R-11;
}





if(M==4 && R<11)
{
	m=6;
	r=R+20;
}
else if(M==4 && R>=11)
{
	m=7;
	r=R-10;
}


if(M==5 && R<11)
{
	m=7;
	r=R+21;
}
else if(M==5 && R>=11)
{
	m=8;
	r=R-10;
}






if(M==6 && R<11)
{
	m=8;
	r=R+21;
}
else if(M==6 && R>=11)
{
	m=9;
	r=R-10;
}




if(M==7 && R<10)
{
	m=9;
	r=R+21;
}
else if( M==7 && R>=10)
{
	m=10;
	r=R-9;
}







if(M==8 && R<11)
{
	m=11;
	r=R+21;
}
else if(M==8 && R>=11)
{
	m=12;
	r=R-10;
}




if(M==9 && R<11)
{
	m=11;
	r=R+20;
}
else if(M==9 && R>=11)
{
	m=12;
	r=R-10;
}


//-----------

Y=Y+621;

if(M==10 && R<12 )
{
	m=12;
	r=R+20;
	//Y++;
}
else if(M==10 && R>=12)
{
	m=1;
	r=R-11;
	Y++;
}




if(M==11 && R<13)
{
	m=1;
	r=R+19;
	Y++;
}
else if(M==11 && R>=13)
{
	m=2;
	r=R-12;
	Y++;
}





if(M==12 && R<11)
{
	m=2;
	r=R+18;
	Y++;
}
else if(M==12 && R>=11)
{
	m=3;
	r=R-10;
	Y++;
}


if(what==0)
return r;//return Day
else if(what==1) return m;//return month
else if(what==2) return Y;//return Year

return 3;//return error


}











int CConvertDate::OutDateLeap(int D,int M,int Y,int what)
{

int R;
R=D;

	//--R M Y----------------------------------
int inty;

		
				int x12=0;

				if(M==1||M==2)
				{
					x12=622;
				}
				else if(M==3&&R<20)//31k
				{
					x12=622;
				}
				else
				x12=621;

				inty=Y-x12;

			int xxx=1379,i=0;
			BOOL m_ok;

			do
			{
					i++;

					if(inty==xxx)
					{m_ok=TRUE;
					break;
					}
					else
					{
					m_ok=FALSE;
					xxx=xxx+4;//----------”«· ﬂ»Ì”Â Â— çÂ«— ”«· Ìﬂ»«—-----
					}


			}while(i<30);

if(m_ok==TRUE)//”«· ﬂ»Ì”Â Â” 
{

	if(R<31 && M==1)
	{

		R++;

	}
	else if(R<28 && M==2)
	{
		R++;

	}
	else if(R<31 && M==3)
	{
		R++;
	}
	
	else if(R<30 && M==4)
	{
		R++;

	}
	else if(R<31 && M==5)
	{
		R++;
	}
	else if(R<30 && M==6)
	{
		R++;

	}
	else if(R<31 && M==7)
	{
		R++;
	}
	
	else if(R<31 && M==8)
	{
		R++;

	}
	else if(R<30 && M==9)
	{
		R++;
	}
	else if(R<31 && M==10)
	{
		R++;
	}
	else if(R<30 && M==11)
	{
		R++;
	}
	else if(R<31 && M==12)
	{
		R++;
	}
	else
	{
		R=1;
		M++;
	}
	
	

}//---------end if cabise


int r,m;

if(M==1&&R<21)
{
	r=R+10;
	m=10;
}
else if(M==1&&R>=21)
{
r=R-20;
m=11;
}




if(M==2&&R<20)
{
	r=R+11;
	m=11;
}
else if(M==2&&R>=20)
{
r=R-19;
m=12;
}


////////////////////////////

if(M==3&&R<21)
{
	/*r=R+9;
	m=12;
	*/
	//r=R+9;
	r=R+10;

	m=12;

}
else if(M==3&&R>=21)
{
r=R-20;
m=1;
}




if(M==4&&R<21)
{
	r=R+11;
	m=1;
}
else if(M==4&&R>=21)
{
r=R-20;
m=2;
}





if(M==5&&R<22)
{
	r=R+10;
	m=2;
}
else if(M==5&&R>=22)
{
r=R-21;
m=3;
}




if(M==6&&R<22)
{
	r=R+10;
	m=3;
}
else if(M==6&&R>=22)
{
r=R-21;
m=4;
}




if(M==7&&R<23)
{
	r=R+9;
	m=4;
}
else if(M==7&&R>=23)
{
r=R-22;
m=5;
}



if(M==8&&R<23)
{
	r=R+9;
	m=5;
}
else if(M==8&&R>=23)
{
r=R-22;
m=6;
}



if(M==9&&R<23)
{
	r=R+9;
	m=6;
}
else if(M==9&&R>=23)
{
r=R-22;
m=7;
}




if(M==10&&R<23)
{
	r=R+8;
	m=7;
}
else if(M==10&&R>=23)
{
r=R-22;
m=8;
}




if(M==11&&R<22)
{
	r=R+9;
	m=8;
}
else if(M==11&&R>=22)
{
r=R-21;
m=9;
}




if(M==12&&R<22)
{
	r=R+9;
	m=9;
}
else if(M==12&&R>=22)
{
r=R-21;
m=10;
}





int x=0;

if(M==1||M==2)
{
	x=622;
}
else if(M==3&&R<=20)//31
{
	x=622;
}
else
x=621;
Y=Y-x;




if(what==0)
return r;//return Day
else if(what==1) return m;//return month
else if(what==2) return Y;//return Year

return 3;//return error

}
//Created by Ramin Edjlal. 1392/09/28
int CConvertDate::OutDateGerogianAll(int D,int M,int Y,int what)
{
	if(((Y-1391)%4)==0)
		return OutDateGregorian_k(D,M,Y,what);
	return OutDateGregorian(D,M,Y,what);
}