//CCreateDates class is a call to inform ConvertDate calss and 
//use of CMounth class variables and derved from these calss.
//By Ramin Edjlal. Urmia Iran.
#include "stdafx.h"
#include <ctime>

//Constructor.
CCreateDates::CCreateDates(CString DaysD,CString FilesD,CString AllDaysD,INT SheetA):CConvertDate(),CMounth(SheetA)
{

	//Inizialize protected variables.
	this->Days=DaysD;
	this->Files=FilesD;
	this->AllDays=AllDaysD;
	Sheet=SheetA;
}
BOOL CCreateDates::CCreateGDates()
{
	
	try{
		
    //Pointer and construction.
	CConvertDate *CMC=new CConvertDate();

	//Find Day and Mounth and yesr and create and replace in GDays.
    GDays=Days;
	int Cur=0;
	while(Cur<Days.GetLength())
	{
	int Day=CMC->OutDateGerogianAll(_wtoi(Days.Mid(6+Cur,2)),_wtoi(Days.Mid(4+Cur,2)),_wtoi(Days.Mid(Cur,4)),0);
	int Mounth=CMC->OutDateGerogianAll(_wtoi(Days.Mid(6+Cur,2)),_wtoi(Days.Mid(4+Cur,2)),_wtoi(Days.Mid(Cur,4)),1);
	int Year=CMC->OutDateGerogianAll(_wtoi(Days.Mid(6+Cur,2)),_wtoi(Days.Mid(4+Cur,2)),_wtoi(Days.Mid(Cur,4)),2);
	CString GDay;
	CString GMounth;
	CString GYear;
	GDay.Format(L"%d",Day);
	if(GDay.GetLength()==1)
		GDay=L"0"+GDay;
	GMounth.Format(L"%d",Mounth);
	if(GMounth.GetLength()==1)
		GMounth=L"0"+GMounth;
	GYear.Format(L"%d",Year);
    GDays.Replace(GDays.Mid(Cur,8),GYear+GMounth+GDay);
	Cur+=9;
	}
	delete CMC;
	}
	catch(CException &e)
	{
	
	return FALSE;}
	return TRUE;

}
BOOL CCreateDates::CCreateHDates()
{

	return TRUE;
}

//Add One Day to Georgian Date.
CString CCreateDates::AddOneDayToDate(CString Date)
{
	CString AddedDate;
	CString AddedDay;
	CString AddedMounth;
	CString AddedYear;

	//A way to increase 24*3600 second to curend second date.  
	struct tm* date=new tm;
	try{
	int days=1;
	
	memset(date,0,sizeof(tm));
	date->tm_hour=0;
	date->tm_mday=_wtoi(Date.Mid(6,2));
	date->tm_min=0;
	date->tm_mon=_wtoi(Date.Mid(4,2))-1;
	date->tm_sec=0;
	date->tm_year=_wtoi(Date.Mid(0,4));
	date->tm_year-=1900;
   
	// Adjust date by a number of days +/-
   const time_t ONE_DAY = 24 * 60 * 60 ;

    // Seconds since start of epoch
    time_t date_seconds = mktime( date ) + (days * ONE_DAY) ;

    // Update caller's date
    // Use localtime because mktime converts to UTC so may change date
    *date = *localtime( &date_seconds ) ; 
	AddedDay.Format(L"%d",date->tm_mday);
	AddedMounth.Format(L"%d",date->tm_mon+1);
	AddedYear.Format(L"%d",date->tm_year+1900);
	if(AddedDay.GetLength()==1)
		AddedDay=L"0"+AddedDay;
	if(AddedMounth.GetLength()==1)
		AddedMounth=L"0"+AddedMounth;
	AddedDate=AddedYear+AddedMounth+AddedDay;
	}
	catch(CException&e)
	{
		return FALSE;
	}
	return AddedDate;
}

//Decrese One Day From Georgian Date.
CString CCreateDates::DecreaseOneDayFromDate(CString Date)
{   CString DecreaseDate;
	CString DecreaseDay;
	CString DecreaseMounth;
	CString DecreaseYear;
	struct tm* date=new tm;
	try{

    //A way to decrease 24*3600 second to curend second date.  
	int days=1;
	
	memset(date,0,sizeof(tm));
	date->tm_hour=0;
	date->tm_mday=_wtoi(Date.Mid(6,2));
	date->tm_min=0;
	date->tm_mon=_wtoi(Date.Mid(4,2))-1;
	date->tm_sec=0;
	date->tm_year=_wtoi(Date.Mid(0,4));
	date->tm_year-=1900;
// Adjust date by a number of days +/-
   const time_t ONE_DAY = 24 * 60 * 60 ;

    // Seconds since start of epoch
    time_t date_seconds = mktime( date ) - (days * ONE_DAY) ;

    // Update caller's date
    // Use localtime because mktime converts to UTC so may change date
    *date = *localtime( &date_seconds ) ; 
	DecreaseDay.Format(L"%d",date->tm_mday);
	DecreaseMounth.Format(L"%d",date->tm_mon+1);
	DecreaseYear.Format(L"%d",date->tm_year+1900);
	if(DecreaseDay.GetLength()==1)
		DecreaseDay=L"0"+DecreaseDay;
	if(DecreaseMounth.GetLength()==1)
		DecreaseMounth=L"0"+DecreaseMounth;
	DecreaseDate=DecreaseYear+DecreaseMounth+DecreaseDay;
	}
	catch(CException&e)
	{
		return FALSE;
	}
	return DecreaseDate;
}

//Create Excel Format Date.
CString CCreateDates::CCreateExcellFormat(CString File)
{
	CString Excell;
	Excell=File.Mid(0,4)+'-'+File.Mid(4,2)+'-'+File.Mid(6,2);
	return Excell;

}

//Create File Stored Date.
CString CCreateDates::CCreateFileFormat(CString Excell)
{
	CString File;
	File=Excell.Mid(0,4)+Excell.Mid(5,2)+Excell.Mid(8,2);
	return File;
}

//return GDay varibale.
CString CCreateDates::GetGDays()
{return GDays;}

//Deconstructor.
CCreateDates::~CCreateDates()
{
}