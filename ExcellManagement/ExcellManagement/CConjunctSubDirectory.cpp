//A File Class Implementation for Conjuncting files and Use itselves to do.
//Ramin Edjlal. Urmia Irna.
#include "stdafx.h"

//Constructor.
CConjunctSubDirectory::CConjunctSubDirectory(INT SheetA)
{
	//Inizialize protected variable.
	LastFindGreatest=L"";
	Sheet=SheetA;
	SheetNeed=0;
}

//Retrun Greatest Subdirectory lenght. 
INT CConjunctSubDirectory::CFindGreatestSubDirectoryLenghtIfNotMarked(CStringArray &AllSubDirectoryP,INT *MarkedAllSubDirectoryP)
{
	//Inizialize variables.
	INT MAX=0;
	for(int i=0;i<AllSubDirectoryP.GetCount();i++)
	{
		if((AllSubDirectoryP.GetAt(i).GetLength()>AllSubDirectoryP.GetAt(MAX).GetLength())&&MarkedAllSubDirectoryP[i]==-1)
			MAX=i;
	}
	try{

	//If Number of Directories is greater than Maximum path return FALSE.
	if(MAX_PATH_THIS_PROJECT < AllSubDirectoryP.GetCount())
			return -1;
	
	//For Everey Subdirectory.
	for(int i=0;i<AllSubDirectoryP.GetCount();i++)
	{
		//Find Maimum Path that is sub set of index i.
		if((AllSubDirectoryP.GetAt(i).GetLength()<=AllSubDirectoryP.GetAt(MAX).GetLength())&&(AllSubDirectoryP.GetAt(MAX).Find(AllSubDirectoryP.GetAt(i),0)>=0||LastFindGreatest==L"")&&(MarkedAllSubDirectoryP[i]==-1))
			MAX=i;		
	}
	}
	catch(CException&e)
	{
		//RETURN eRROR.
		return -1;
	}

	//Store Maimum Path.
	LastFindGreatest=AllSubDirectoryP.GetAt(MAX);
	
	//Return minimum.
	return MAX;
}

//To Create Marked Arrray.		
BOOL CConjunctSubDirectory::CCreateMarkedArray(CStringArray &AllSubDirectoryP,INT *MarkedAllSubDirectory,INT *MarkedP,INT *FileNoNP)
{
	try{

	//If Number of Directories is greater than Maximum path return FALSE.
	if(MAX_PATH_THIS_PROJECT < AllSubDirectoryP.GetCount())
			return -1;

	//Inizialize variable.
	INT Index=-1;
	
	//For Everey Subdirectory.
	for(int i=0;i<AllSubDirectoryP.GetCount();i++)
	{
		//Retrive and Store Aximum Path.
		Index=CFindGreatestSubDirectoryLenghtIfNotMarked(AllSubDirectoryP,MarkedAllSubDirectory);

		//If Index is opposite of -1.
		if(Index!=-1)
			{

			//Retrive sum of Subdirectories Matked with Marked variable.
			INT Sum=SumOfMarked(MarkedAllSubDirectory,*MarkedP,FileNoNP);
			if(Sum!=-1)
				{
					//If Maimum FileNoN located in Index is Greater than condition Retrun Error sheet.
					if(FileNoNP[Index]>(Sheet*251))
					{

						CString SheetA;
				        SheetA.Format(L"%d",FileNoNP[Index]/251+1);
						SheetNeed=FileNoNP[Index]/251+1;
						MessageBox(0,L"Error SheetNumber! Increase Sheet Number. Require '"+SheetA+L"', Sheet(s). Operations Will be terminated.",0,0);
						return FALSE;
					}
					//If Not and Sum added to FileNon index is smaleer that contaied sheets do.
				if((Sum+FileNoNP[Index])<(Sheet*251))

					//Marke with Marked variable.
					MarkedAllSubDirectory[Index]=*MarkedP;
				else
				{
					//Make Emty LastFindDirectory and Increase Marked and Marked MarkedAllSubDirectory loacated in Index.
					LastFindGreatest=L"";
					(*MarkedP)++;
					MarkedAllSubDirectory[Index]=*MarkedP;
				}
			}
			else
			return FALSE;
	}
	}
    }
	catch(CException&e)
	{
		return FALSE;
	}
	return TRUE;
}

//To Find Sum Of AllSubDirectory.
INT CConjunctSubDirectory::SumOfMarked(INT *MarkedAllSubDirectoryP,INT Marked,INT *FileNoNP)
{
	INT SUM=0;
	try{

		//For Every location Marked with Marked varibale find sum.
		for(int i=0;i<MAX_PATH_THIS_PROJECT;i++)
		{
			if((MarkedAllSubDirectoryP[i]!=-1)&&(MarkedAllSubDirectoryP[i]==Marked))				
					SUM+=FileNoNP[i];
		}
	}catch(CException&e)
	{
		return -1;
	}
	return SUM;
}

//To retrive All SubString with marked E.
BOOL CConjunctSubDirectory::CRetriveMarkedWithE(INT Marked,INT* MarkedAllSubDirectoryP,CStringArray &AllSubDirectoryP,CStringArray &SubMarkedAllSubStringDirectory)
{
	
	try{
	
		//Make Empty.
		SubMarkedAllSubStringDirectory.RemoveAll();

		//For Every Subdirectory found.
		for(int i=0;i<AllSubDirectoryP.GetCount();i++)

			//if Marked with Marked variable.
			if(MarkedAllSubDirectoryP[i]==Marked)

				//Add to SubMarkedAllSubStringDirectory AllSubDFirectory located in i.
				SubMarkedAllSubStringDirectory.Add(AllSubDirectoryP.GetAt(i));
		}
		catch(CException&)
		{
			SubMarkedAllSubStringDirectory.RemoveAll();
			return FALSE;
		}
	return TRUE;
}

//To retrive smallest Subdirectory Marked with E. 
INT CConjunctSubDirectory::CFindSmallestSubDirectoryMarkedWithE(CStringArray &AllSubDirectoryP,INT *MarkedAllSubDirectoryP,INT MarkedP)
{

	//Inizialize varibale.
	INT MIN=0;
	try
	{

	//For every Subdirectory.
	for(int i=0;i<AllSubDirectoryP.GetCount();i++)
	{
		//Find first MIN.
		if(MarkedAllSubDirectoryP[i]==MarkedP)
		{
			MIN=i;
			break;
		}
	}
	
	//For every Subdirectory.
	for(int i=0;i<AllSubDirectoryP.GetCount();i++)

		//If Found Minmum less than Min location Store inMIN.
		if((MarkedAllSubDirectoryP[i]==MarkedP)&&(AllSubDirectoryP.GetAt(i).GetLength()<AllSubDirectoryP.GetAt(MIN).GetLength()))
					MIN=i;
	}catch(CException&e)
	{
		return -1;
	}
return MIN;
}

//Deconstructor.
CConjunctSubDirectory::~CConjunctSubDirectory()
{

}