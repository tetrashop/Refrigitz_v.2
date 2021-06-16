#pragma once

#include <string>
#include <vector>
#include <iostream>
#include <stdexcept>

/**************************************************************************************************************
 * Ramin Edjlal Copyright 1397/04/20 **************************************************************************
 * 1397/04/26:Problem in Seirlization Recurisvely of linked list for refrigitz.********************************
 * ************************************************************************************************************
 */
using namespace RefrigtzDLL;
namespace GalleryStudio
{

//C# TO C++ CONVERTER NOTE: The following .NET attribute has no direct equivalent in native C++:
//ORIGINAL LINE: [Serializable] public class RefregizMemmory
	class RefregizMemmory //:AllDraw
	{
	public:
		int iii, jjj;
		bool MovementsAStarGreedyHuristicFoundT;
		bool IgnoreSelfObjectsT;
		bool UsePenaltyRegardMechnisamT;
		bool BestMovmentsT;
		bool PredictHuristicT;
		bool OnlySelfT;
		bool AStarGreedyHuristicT;
		bool ArrangmentsT;
	private:
		static const std::wstring SAllDraw;
	public:
		int Kind;
	private:
		static GalleryStudio::RefregizMemmory *Node;
		RefrigtzDLL::AllDraw *Current;
		QuantumRefrigiz::AllDraw *CurrentQ;
	public:
		std::vector<GalleryStudio::RefregizMemmory*> NextS;
		std::vector<GalleryStudio::RefregizMemmory*> NextE;
		std::vector<GalleryStudio::RefregizMemmory*> NextH;
		std::vector<GalleryStudio::RefregizMemmory*> NextC;
		std::vector<GalleryStudio::RefregizMemmory*> NextM;
		std::vector<GalleryStudio::RefregizMemmory*> NextK;
	private:
		bool NewListOfNextBegins;


		static void Log(std::exception &ex);
	public:
		RefregizMemmory(bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments); //) : base(MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, Arrangments
		//async 
	private:
		void RewriteAllDrawRec(BinaryFormatter *Formatters, FileStream *DummyFileStream, int Order);
		void RewriteAllDrawRecQ(BinaryFormatter *Formatters, FileStream *DummyFileStream, int Order);
	public:
		RefregizMemmory *CloneSphycose(RefregizMemmory *t);
		void RewriteAllDraw(int Order);
		void RewriteAllDrawQ(int Order);
		AllDraw *Load(bool Quantum, int Order);
		QuantumRefrigiz::AllDraw *LoadQ(bool Quantum, int Order);
		AllDraw *LoadrEC(bool Quantum, int Order, GalleryStudio::RefregizMemmory *Last, FileStream *DummyFileStream, BinaryFormatter *Formatters);
		QuantumRefrigiz::AllDraw *LoadrECQ(bool Quantum, int Order, GalleryStudio::RefregizMemmory *Last, FileStream *DummyFileStream, BinaryFormatter *Formatters);
	private:
		AllDraw *CreateAllDrawFromMemmory(RefregizMemmory *t, AllDraw *Last, int Order);

/* public void DeleteObject(RefregizMemmory p)
 {
     RefregizMemmory t = new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT);
     t = Node;
     if ((t.c) != (p.AllDrawCurrentAccess.RefrigtzDLL.AllDrawName))
     {
         if (t != null)
             while ((t.AllDrawNextAccess.AllDrawCurrentAccess.RefrigtzDLL.AllDrawName) != (p.AllDrawCurrentAccess.RefrigtzDLL.AllDrawName))
             {
                 if (t.AllDrawNextAccess != null)
                     t = t.AllDrawNextAccess;
                 else
                 if ((t.AllDrawCurrentAccess.RefrigtzDLL.AllDrawName) != (p.AllDrawCurrentAccess.RefrigtzDLL.AllDrawName))
                 {
                     t = null;
                     break;
                 }
             }
         if (t != null)
         {
             if (t.AllDrawNextAccess != null)
                 t.AllDrawNextAccess = t.AllDrawNextAccess.AllDrawNextAccess;

             else
                 t.AllDrawNextAccess = null;
         }

     }
     else
     {
         t = t.AllDrawNextAccess;
         Node = t;
     }
 }
 */
/*public void AddObject(RefregizMemmory p)
{
    RefregizMemmory t = new catch (IOException tt) {Log(tt);  }MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT
        );
    t = p.AllDrawNodeAccess;
    while (t.AllDrawNextAccess != null)
        t = t.AllDrawNextAccess;
    if (t.AllDrawCurrentAccess == null)
        t.AllDrawCurrentAccess = p.AllDrawCurrentAccess;
    else
        t.AllDrawNextAccess = p;
}*/
public:
		RefregizMemmory *getAllDrawNodeAccess() const;
		void setAllDrawNodeAccess(RefregizMemmory *value);
		AllDraw *getAllDrawCurrentAccess() const;
		void setAllDrawCurrentAccess(AllDraw *value);
		QuantumRefrigiz::AllDraw *getAllDrawCurrentAccessQ() const;
		void setAllDrawCurrentAccessQ(QuantumRefrigiz::AllDraw *value);
		const int &getOrderPlateCurrentAccess() const;
		void setOrderPlateCurrentAccess(const int &value);
		const int &getOrderPlateCurrentAccessQ() const;
		void setOrderPlateCurrentAccessQ(const int &value);
		RefregizMemmory *ReterunAstrarGreedysolder(int i, int j, RefregizMemmory *t);
		RefregizMemmory *ReterunAstrarGreedyelephant(int i, int j, RefregizMemmory *t);
		RefregizMemmory *ReterunAstrarGreedyHours(int i, int j, RefregizMemmory *t);
		RefregizMemmory *ReterunAstrarGreedyCastle(int i, int j, RefregizMemmory *t);
		RefregizMemmory *ReterunAstrarGreedyMinister(int i, int j, RefregizMemmory *t);
		RefregizMemmory *ReterunAstrarGreedyKing(int i, int j, RefregizMemmory *t);
		RefregizMemmory *AllDrawNextS(int i);
		RefregizMemmory *AllDrawNextE(int i);
		RefregizMemmory *AllDrawNextH(int i);
		RefregizMemmory *AllDrawNextC(int i);
		RefregizMemmory *AllDrawNextM(int i);
		RefregizMemmory *AllDrawNextK(int i);

		/*public RefregizMemmory AllDrawNextAccessS
		{
		    get
		    { return NextS; }
		    set
		    { NextS = value; }
		}
		public RefregizMemmory AllDrawNextAccessE
		{
		    get
		    { return NextE; }
		    set
		    { NextE = value; }
		}
		public RefregizMemmory AllDrawNextAccessH
		{
		    get
		    { return NextH; }
		    set
		    { NextH = value; }
		}
		public RefregizMemmory AllDrawNextAccessC
		{
		    get
		    { return NextC; }
		    set
		    { NextC = value; }
		}
		public RefregizMemmory AllDrawNextAccessM
		{
		    get
		    { return NextM; }
		    set
		    { NextM = value; }
		}
		public RefregizMemmory AllDrawNextAccessK
		{
		    get
		    { return NextK; }
		    set
		    { NextK = value; }
		}
		*/

	private:
		void InitializeInstanceFields();
	};
}
