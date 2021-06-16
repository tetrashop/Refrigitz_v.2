#include "RefregizMemmory.h"

using namespace RefrigtzDLL;

namespace GalleryStudio
{

const std::wstring RefregizMemmory::SAllDraw = L"AllDraw.asd";

	void RefregizMemmory::Log(std::exception &ex)
	{
		try
		{
			//autoa = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (a)
			{
				std::wstring stackTrace = ex.what();
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				File::AppendAllText(AllDraw::Root + std::wstring(L"\\ErrorProgramRun.txt"), stackTrace + std::wstring(L": On") + DateTime::Now.ToString()); // path of file where stack trace will be stored.
			}
		}
		catch (std::exception &t)
		{
			Log(t);
		}
	}

	RefregizMemmory::RefregizMemmory(bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		InitializeInstanceFields();
		NextS = std::vector<RefregizMemmory*>();
		NextE = std::vector<RefregizMemmory*>();
		NextH = std::vector<RefregizMemmory*>();
		NextC = std::vector<RefregizMemmory*>();
		NextM = std::vector<RefregizMemmory*>();
		NextK = std::vector<RefregizMemmory*>();

		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{
			MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicTFou;
			IgnoreSelfObjectsT = IgnoreSelfObject;
			UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisa;
			BestMovmentsT = BestMovment;
			PredictHuristicT = PredictHurist;
			OnlySelfT = OnlySel;
			AStarGreedyHuristicT = AStarGreedyHuris;
			ArrangmentsT = Arrangments;
		}

	}

	void RefregizMemmory::RewriteAllDrawRec(BinaryFormatter *Formatters, FileStream *DummyFileStream, int Order)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			try
			{

				if (Current != nullptr)
				{
					//Current.Clone(AllDrawCurrentAccess);
					Formatters->Serialize(DummyFileStream, this);
					//Kind = Kind;
					/*     if (Order == 1)
					     {
					         //if (Kind == 1)
					         {
					             for (int i = 0; i < Current.SodierMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                 try
					                 {
					                     for (int j = 0; j < Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedysolder(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 2)
					         {
					             for (int i = 0; i < Current.ElefantMidle; i++)
					             {
					                 try
					                 {
					                     //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                     for (int j = 0; j < Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyelephant(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 3)
					         {
					             for (int i = 0; i < Current.HourseMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyHours(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 4)
					         {
					             for (int i = 0; i < Current.CastleMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyCastle(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         // else if (Kind == 5)
					         {
					             for (int i = 0; i < Current.MinisterMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyMinister(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
	
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 6)
					         {
					             for (int i = 0; i < Current.KingMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.KingOnTable[i].KingThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyKing(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.KingOnTable[i].KingThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					     }
					     else
					     {
					         //if (Kind == 1)
					         {
					             for (int i = Current.SodierMidle; i < Current.SodierHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                 try
					                 {
					                     for (int j = 0; j < Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedysolder(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 2)
					         {
	
					             for (int i = Current.ElefantMidle; i < Current.ElefantHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                 try
					                 {
					                     for (int j = 0; j < Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyelephant(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 3)
					         {
	
					             for (int i = Current.HourseMidle; i < Current.HourseHight; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyHours(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 4)
					         {
	
					             for (int i = Current.CastleMidle; i < Current.CastleHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyCastle(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 5)
					         {
					             for (int i = Current.MinisterMidle; i < Current.MinisterHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyMinister(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
	
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         // else if (Kind == 6)
					         {
					             for (int i = Current.KingMidle; i < Current.MinisterHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.KingOnTable[i].KingThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyKing(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.KingOnTable[i].KingThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					     }*/
				}
			}
			catch (std::exception &tt)
			{
				Log(tt);
			}
			/*while (t != null)
			{
			    //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
			    t = AllDrawNextAccess;
			}*/
		}
	}

	void RefregizMemmory::RewriteAllDrawRecQ(BinaryFormatter *Formatters, FileStream *DummyFileStream, int Order)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			try
			{

				if (CurrentQ != nullptr)
				{
					//Current.Clone(AllDrawCurrentAccess);
					Formatters->Serialize(DummyFileStream, this);
					//Kind = Kind;
					/*     if (Order == 1)
					     {
					         //if (Kind == 1)
					         {
					             for (int i = 0; i < Current.SodierMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                 try
					                 {
					                     for (int j = 0; j < Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedysolder(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 2)
					         {
					             for (int i = 0; i < Current.ElefantMidle; i++)
					             {
					                 try
					                 {
					                     //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                     for (int j = 0; j < Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyelephant(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 3)
					         {
					             for (int i = 0; i < Current.HourseMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyHours(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 4)
					         {
					             for (int i = 0; i < Current.CastleMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyCastle(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         // else if (Kind == 5)
					         {
					             for (int i = 0; i < Current.MinisterMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyMinister(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
	
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 6)
					         {
					             for (int i = 0; i < Current.KingMidle; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.KingOnTable[i].KingThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyKing(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.KingOnTable[i].KingThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					     }
					     else
					     {
					         //if (Kind == 1)
					         {
					             for (int i = Current.SodierMidle; i < Current.SodierHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                 try
					                 {
					                     for (int j = 0; j < Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedysolder(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 2)
					         {
	
					             for (int i = Current.ElefantMidle; i < Current.ElefantHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
					                 try
					                 {
					                     for (int j = 0; j < Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyelephant(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 3)
					         {
	
					             for (int i = Current.HourseMidle; i < Current.HourseHight; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyHours(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 4)
					         {
	
					             for (int i = Current.CastleMidle; i < Current.CastleHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyCastle(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         //else if (Kind == 5)
					         {
					             for (int i = Current.MinisterMidle; i < Current.MinisterHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyMinister(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
	
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					         // else if (Kind == 6)
					         {
					             for (int i = Current.KingMidle; i < Current.MinisterHigh; i++)
					             {
					                 //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
	
					                 try
					                 {
					                     for (int j = 0; j < Current.KingOnTable[i].KingThinking[0].AStarGreedy.Count; j++)
					                     {
					                         Object O = new Object();
					                         //lock (O)
					                         {
					                             iii = i;
					                             jjj = j;
					                             RefregizMemmory tCurrent = ReterunAstrarGreedyKing(i, j, this);
					                             tCurrent.NewListOfNextBegins = false;
					                             tCurrent.RewriteAllDrawRec(Formatters, DummyFileStream,Current.KingOnTable[i].KingThinking[0].AStarGreedy[j], Order * -1);
					                         }
					                     }
					                 }
					                 catch (Exception ttt) { Log(ttt); }
					             }
					         }
					     }*/
				}
			}
			catch (std::exception &tt)
			{
				Log(tt);
			}
			/*while (t != null)
			{
			    //Formatters.Serialize(DummyFileStream, AllDrawCurrentAccess);
			    t = AllDrawNextAccess;
			}*/
		}
	}

	RefregizMemmory *RefregizMemmory::CloneSphycose(RefregizMemmory *t)
	{
		t = new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT);
		t->iii = iii;
		t->jjj = jjj;
		t->MovementsAStarGreedyHuristicFoundT = MovementsAStarGreedyHuristicFoundT;
		t->IgnoreSelfObjectsT = IgnoreSelfObjectsT;
	t->UsePenaltyRegardMechnisamT = UsePenaltyRegardMechnisamT;
	t->BestMovmentsT = BestMovmentsT;
	t->PredictHuristicT = PredictHuristicT;
	t->OnlySelfT = OnlySelfT;
	t->AStarGreedyHuristicT = AStarGreedyHuristicT;
	t->ArrangmentsT = ArrangmentsT;
		t->Kind = Kind;

		Current->Clone(t->Current);
		for (int i = 0; i < NextS.size(); i++)
		{
			t->NextS.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			NextS[i]->CloneSphycose(t->NextS[i]);
		}

		for (int i = 0; i < NextE.size(); i++)
		{
			t->NextE.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			NextE[i]->CloneSphycose(t->NextE[i]);
		}
		for (int i = 0; i < NextH.size(); i++)
		{
			t->NextH.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			NextH[i]->CloneSphycose(t->NextH[i]);
		}
		for (int i = 0; i < NextC.size(); i++)
		{
			t->NextC.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			NextC[i]->CloneSphycose(t->NextC[i]);
		}
		for (int i = 0; i < NextM.size(); i++)
		{
			t->NextM.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			NextM[i]->CloneSphycose(t->NextM[i]);
		}
		for (int i = 0; i < NextK.size(); i++)
		{
			t->NextK.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			NextK[i]->CloneSphycose(t->NextK[i]);
		}
		t->NewListOfNextBegins = NewListOfNextBegins;

		return t;
	}

	void RefregizMemmory::RewriteAllDraw(int Order)
	{
		//autooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{

			//Current = new RefrigtzDLL.AllDraw(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT);
			FileStream *DummyFileStream = nullptr;
			try
			{


				//RefregizMemmory t = p;

				FileInfo *DummyFileInfo = new FileInfo(SAllDraw);
				DummyFileInfo->Delete();
				DummyFileStream = new FileStream(SAllDraw, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Write);
				BinaryFormatter *Formatters = new BinaryFormatter();
				DummyFileStream->Seek(0, SeekOrigin::Begin);

				//Formatters.Serialize(DummyFileStream, t);
				RewriteAllDrawRec(Formatters, DummyFileStream, Order);


				DummyFileStream->Flush();
				DummyFileStream->Close();
			}
			catch (std::exception &o)
			{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				std::cout << o.what().ToString() << std::endl;
			}
		}
	}

	void RefregizMemmory::RewriteAllDrawQ(int Order)
	{
		//autooo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (oo)
		{

			//Current = new RefrigtzDLL.AllDraw(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT);
			FileStream *DummyFileStream = nullptr;
			try
			{


				//RefregizMemmory t = p;

				FileInfo *DummyFileInfo = new FileInfo(SAllDraw);
				DummyFileInfo->Delete();
				DummyFileStream = new FileStream(SAllDraw, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Write);
				BinaryFormatter *Formatters = new BinaryFormatter();
				DummyFileStream->Seek(0, SeekOrigin::Begin);

				//Formatters.Serialize(DummyFileStream, t);
				RewriteAllDrawRecQ(Formatters, DummyFileStream, Order);


				DummyFileStream->Flush();
				DummyFileStream->Close();
			}
			catch (std::exception &o)
			{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				std::cout << o.what().ToString() << std::endl;
			}
		}
	}

	RefrigtzDLL::AllDraw *RefregizMemmory::Load(bool Quantum, int Order)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			//Node.AllDrawNextAccessS = null;
			//Node.AllDrawNextAccessE = null;
			//Node.AllDrawNextAccessH = null;
			//Node.AllDrawNextAccessC = null;
			//Node.AllDrawNextAccessM = null;
			//Node.AllDrawNextAccessK = null;
			//Node.AllDrawCurrentAccess = null;
			AllDraw *t = nullptr;
			//QuantumRefrigiz.AllDraw tQ = null;
			try
			{
				FileStream *DummyFileStream = new FileStream(SAllDraw, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::ReadWrite);
				BinaryFormatter *Formatters = new BinaryFormatter();

				std::cout << std::wstring(L"Loading...") << std::endl;
				DummyFileStream->Seek(0, SeekOrigin::Begin);
			   t = LoadrEC(Quantum, Order, this, DummyFileStream, Formatters);

				DummyFileStream->Flush();
				DummyFileStream->Close();
			}
			catch (IOException tt)
			{
				Log(tt);
			}
			return t;
			//return Node.al;
		}
	}

	QuantumRefrigiz::AllDraw *RefregizMemmory::LoadQ(bool Quantum, int Order)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			 QuantumRefrigiz::AllDraw *tQ = nullptr;
			try
			{
				FileStream *DummyFileStream = new FileStream(SAllDraw, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::ReadWrite);
				BinaryFormatter *Formatters = new BinaryFormatter();

				std::cout << std::wstring(L"Loading...") << std::endl;
				DummyFileStream->Seek(0, SeekOrigin::Begin);
					tQ = LoadrECQ(Quantum, Order, this, DummyFileStream, Formatters);

				DummyFileStream->Flush();
				DummyFileStream->Close();
			}
			catch (IOException tt)
			{
				Log(tt);
			}
			return tQ;
			//return Node.al;
		}
	}

	RefrigtzDLL::AllDraw *RefregizMemmory::LoadrEC(bool Quantum, int Order, GalleryStudio::RefregizMemmory *Last, FileStream *DummyFileStream, BinaryFormatter *Formatters)
	{
		RefregizMemmory *Dummy = nullptr;
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			//Node.AllDrawNextAccessS = null;
			//Node.AllDrawNextAccessE = null;
			//Node.AllDrawNextAccessH = null;
			//Node.AllDrawNextAccessC = null;
			//Node.AllDrawNextAccessM = null;
			//Node.AllDrawNextAccessK = null;
			//Node.AllDrawCurrentAccess = null;

			try
			{


				//NEWNOD = Node.AllDrawCurrentAccess;
				while (DummyFileStream->Position < DummyFileStream->Length)
				{
					Dummy = static_cast<RefregizMemmory*>(Formatters->Deserialize(DummyFileStream));
					//Dummy.CloneSphycose(Last);
					/*{
					    //Last = Node;
					    if (Dummy.NextS.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextS.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextS.Count; i++)
					            Last.NextS[i].Load(Order * -1, Last.NextS[i]);
	
	
					    }
					    else
					    if (Dummy.NextE.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextE.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextE.Count; i++)
					            Last.NextE[i].Load(Order * -1, Last.NextE[i]);
	
					    }
					    else
					    if (Dummy.NextH.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextH.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextH.Count; i++)
					            Last.NextH[i].Load(Order * -1, Last.NextH[i]);
	
					    }
					    else
					    if (Dummy.NextC.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextC.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextC.Count; i++)
					            Last.NextC[i].Load(Order * -1, Last.NextC[i]);
	
					    }
					    else
					    if (Dummy.NextM.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextM.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextM.Count; i++)
					            Last.NextM[i].Load(Order * -1, Last.NextM[i]);
	
					    }
					    else
					    if (Dummy.NextK.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextK.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextK.Count; i++)
					            Last.NextK[i].Load(Order * -1, Last.NextK[i]);
					    }
					    
					    
					}
					*/
				}

			}
			catch (IOException tt)
			{
				Log(tt);
			}
			//return CreateAllDrawFromMemmory(Last, new AllDraw(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT), Order);
			return Dummy->Current;
			//return Node.al;
		}
	}

	QuantumRefrigiz::AllDraw *RefregizMemmory::LoadrECQ(bool Quantum, int Order, GalleryStudio::RefregizMemmory *Last, FileStream *DummyFileStream, BinaryFormatter *Formatters)
	{
		RefregizMemmory *Dummy = nullptr;
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			//Node.AllDrawNextAccessS = null;
			//Node.AllDrawNextAccessE = null;
			//Node.AllDrawNextAccessH = null;
			//Node.AllDrawNextAccessC = null;
			//Node.AllDrawNextAccessM = null;
			//Node.AllDrawNextAccessK = null;
			//Node.AllDrawCurrentAccess = null;

			try
			{


				//NEWNOD = Node.AllDrawCurrentAccess;
				while (DummyFileStream->Position < DummyFileStream->Length)
				{
					Dummy = static_cast<RefregizMemmory*>(Formatters->Deserialize(DummyFileStream));
					//Dummy.CloneSphycose(Last);
					/*{
					    //Last = Node;
					    if (Dummy.NextS.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextS.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextS.Count; i++)
					            Last.NextS[i].Load(Order * -1, Last.NextS[i]);
	
	
					    }
					    else
					    if (Dummy.NextE.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextE.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextE.Count; i++)
					            Last.NextE[i].Load(Order * -1, Last.NextE[i]);
	
					    }
					    else
					    if (Dummy.NextH.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextH.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextH.Count; i++)
					            Last.NextH[i].Load(Order * -1, Last.NextH[i]);
	
					    }
					    else
					    if (Dummy.NextC.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextC.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextC.Count; i++)
					            Last.NextC[i].Load(Order * -1, Last.NextC[i]);
	
					    }
					    else
					    if (Dummy.NextM.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextM.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextM.Count; i++)
					            Last.NextM[i].Load(Order * -1, Last.NextM[i]);
	
					    }
					    else
					    if (Dummy.NextK.Count > 0 && Dummy.NewListOfNextBegins)
					    {
					        do
					        {
	
					            
					            if (DummyFileStream.Position < DummyFileStream.Length)
					                Dummy = (RefregizMemmory)Formatters.Deserialize(DummyFileStream);
					            else
					                break;
					            Last.NextK.Add(Dummy);
					        } while (!Dummy.NewListOfNextBegins);
	
					        for (int i = 0; i < Last.NextK.Count; i++)
					            Last.NextK[i].Load(Order * -1, Last.NextK[i]);
					    }
					    
					    
					}
					*/
				}

			}
			catch (IOException tt)
			{
				Log(tt);
			}
			//return CreateAllDrawFromMemmory(Last, new AllDraw(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT), Order);
			return Dummy->CurrentQ;
			//return Node.al;
		}
	}

	RefrigtzDLL::AllDraw *RefregizMemmory::CreateAllDrawFromMemmory(RefregizMemmory *t, AllDraw *Last, int Order)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{


			if (t == nullptr)
			{
				return nullptr;
			}
			else
			{
				t->Current = Last;
			}
			try
			{
				/*if (t.NextS.Count > 0)
				{
				    for (int i = 0; i < t.NextS.Count; i++)
				    {
	
				        t.NextS[i].Current.Clone(Last.SolderesOnTable[t.iii].SoldierThinking[0].AStarGreedy[t.jjj]);
				        t.NextS[i].CreateAllDrawFromMemmory(t.NextS[i], Last.ElephantOnTable[t.iii].ElefantThinking[0].AStarGreedy[t.jjj], Order * -1);
				    }
				}
				else
				if (t.NextE.Count > 0)
				{
				    for (int i = 0; i < t.NextE.Count; i++)
				    {
	
				        t.NextE[i].Current.Clone(Last.ElephantOnTable[t.iii].ElefantThinking[0].AStarGreedy[t.jjj]);
				        t.NextE[i].CreateAllDrawFromMemmory(t.NextE[i], Last.ElephantOnTable[t.iii].ElefantThinking[0].AStarGreedy[t.jjj], Order * -1);
				    }
				}
				if (t.NextH.Count > 0)
				{
				    for (int i = 0; i < t.NextH.Count; i++)
				    {
	
				        t.NextH[i].Current.Clone(Last.HoursesOnTable[t.iii].HourseThinking[0].AStarGreedy[t.jjj]);
				        t.NextH[i].CreateAllDrawFromMemmory(t.NextH[i], Last.HoursesOnTable[t.iii].HourseThinking[0].AStarGreedy[t.jjj], Order * -1);
				    }
				}
				if (t.NextC.Count > 0)
				{
				    for (int i = 0; i < t.NextC.Count; i++)
				    {
	
				        t.NextC[i].Current.Clone(Last.CastlesOnTable[t.iii].CastleThinking[0].AStarGreedy[t.jjj]);
				        t.NextC[i].CreateAllDrawFromMemmory(t.NextC[i], Last.CastlesOnTable[t.iii].CastleThinking[0].AStarGreedy[t.jjj], Order * -1);
				    }
				}
				if (t.NextM.Count > 0)
				{
				    for (int i = 0; i < t.NextM.Count; i++)
				    {
	
				        t.NextM[i].Current.Clone(Last.MinisterOnTable[t.iii].MinisterThinking[0].AStarGreedy[t.jjj]);
				        t.NextM[i].CreateAllDrawFromMemmory(t.NextM[i], Last.MinisterOnTable[t.iii].MinisterThinking[0].AStarGreedy[t.jjj], Order * -1);
				    }
				}
				if (t.NextK.Count > 0)
				{
				    for (int i = 0; i < t.NextK.Count; i++)
				    {
	
				        t.NextK[i].Current.Clone(Last.KingOnTable[t.iii].KingThinking[0].AStarGreedy[t.jjj]);
				        t.NextK[i].CreateAllDrawFromMemmory(t.NextK[i], Last.KingOnTable[t.iii].KingThinking[0].AStarGreedy[t.jjj], Order * -1);
				    }
				}                 
	
			*/
			}
			catch (IOException tt)
			{
				Log(tt);
			}

			return t->Current;
		}
	}

	RefregizMemmory *RefregizMemmory::getAllDrawNodeAccess() const
	{
		return Node;
	}

	void RefregizMemmory::setAllDrawNodeAccess(RefregizMemmory *value)
	{
		Node = value;
	}

	RefrigtzDLL::AllDraw *RefregizMemmory::getAllDrawCurrentAccess() const
	{
		return Current;
	}

	void RefregizMemmory::setAllDrawCurrentAccess(AllDraw *value)
	{
		Current = value;
	}

	QuantumRefrigiz::AllDraw *RefregizMemmory::getAllDrawCurrentAccessQ() const
	{
		return CurrentQ;
	}

	void RefregizMemmory::setAllDrawCurrentAccessQ(QuantumRefrigiz::AllDraw *value)
	{
		CurrentQ = value;
	}

	const int &RefregizMemmory::getOrderPlateCurrentAccess() const
	{
		return Current->OrderP;
	}

	void RefregizMemmory::setOrderPlateCurrentAccess(const int &value)
	{
		Current->OrderP = value;
	}

	const int &RefregizMemmory::getOrderPlateCurrentAccessQ() const
	{
		return CurrentQ->OrderP;
	}

	void RefregizMemmory::setOrderPlateCurrentAccessQ(const int &value)
	{
		CurrentQ->OrderP = value;
	}

	RefregizMemmory *RefregizMemmory::ReterunAstrarGreedysolder(int i, int j, RefregizMemmory *t)
	{
		if (t->Current->SolderesOnTable[i]->SoldierThinking[0].AStarGreedy->Count > j && j > 0)
		{
			Kind = 1;
			t->NextS.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			t->Current->SolderesOnTable[i]->SoldierThinking[0].AStarGreedy[j]->Clone(t->NextS[j]->Current);
		}
		return t->AllDrawNextS(j);
	}

	RefregizMemmory *RefregizMemmory::ReterunAstrarGreedyelephant(int i, int j, RefregizMemmory *t)
	{
		if (t->Current->ElephantOnTable[i]->ElefantThinking[0].AStarGreedy->Count > j && j > 0)
		{
			Kind = 2;
			t->NextE.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			t->Current->ElephantOnTable[i]->ElefantThinking[0].AStarGreedy[j]->Clone(t->NextE[j]->Current);
		}
		return t->AllDrawNextE(j);
	}

	RefregizMemmory *RefregizMemmory::ReterunAstrarGreedyHours(int i, int j, RefregizMemmory *t)
	{
		if (t->Current->HoursesOnTable[i]->HourseThinking[0].AStarGreedy->Count > j && j > 0)
		{
			Kind = 3;
			t->NextH.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			t->Current->HoursesOnTable[i]->HourseThinking[0].AStarGreedy[j]->Clone(t->NextH[j]->Current);
		}
		return t->AllDrawNextH(j);
	}

	RefregizMemmory *RefregizMemmory::ReterunAstrarGreedyCastle(int i, int j, RefregizMemmory *t)
	{
		if (t->Current->CastlesOnTable[i]->CastleThinking[0].AStarGreedy->Count > j && j > 0)
		{
			Kind = 4;
			t->NextC.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			t->Current->CastlesOnTable[i]->CastleThinking[0].AStarGreedy[j]->Clone(t->NextC[j]->Current);
		}
		return t->AllDrawNextC(j);
	}

	RefregizMemmory *RefregizMemmory::ReterunAstrarGreedyMinister(int i, int j, RefregizMemmory *t)
	{
		if (t->Current->MinisterOnTable[i]->MinisterThinking[0].AStarGreedy->Count > j && j > 0)
		{
			Kind = 5;
			t->NextM.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			t->Current->MinisterOnTable[i]->MinisterThinking[0].AStarGreedy[j]->Clone(t->NextM[j]->Current);
		}
		return t->AllDrawNextM(j);
	}

	RefregizMemmory *RefregizMemmory::ReterunAstrarGreedyKing(int i, int j, RefregizMemmory *t)
	{
		if (t->Current->KingOnTable[i]->KingThinking[0].AStarGreedy->Count > j && j > 0)
		{
			Kind = 6;
			t->NextK.push_back(new RefregizMemmory(MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT));
			t->Current->KingOnTable[i]->KingThinking[0].AStarGreedy[j]->Clone(t->NextK[j]->Current);
		}
		return t->AllDrawNextK(j);
	}

	RefregizMemmory *RefregizMemmory::AllDrawNextS(int i)
	{
		return NextS[i];
	}

	RefregizMemmory *RefregizMemmory::AllDrawNextE(int i)
	{
		return NextE[i];
	}

	RefregizMemmory *RefregizMemmory::AllDrawNextH(int i)
	{
		return NextH[i];
	}

	RefregizMemmory *RefregizMemmory::AllDrawNextC(int i)
	{
		return NextC[i];
	}

	RefregizMemmory *RefregizMemmory::AllDrawNextM(int i)
	{
		return NextM[i];
	}

	RefregizMemmory *RefregizMemmory::AllDrawNextK(int i)
	{
		return NextK[i];
	}

	void RefregizMemmory::InitializeInstanceFields()
	{
		iii = 0;
		jjj = 0;
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		ArrangmentsT = false;
		Kind = 0;
		Current = 0;
		CurrentQ = 0;
		NextS = 0;
		NextE = 0;
		NextH = 0;
		NextC = 0;
		NextM = 0;
		NextK = 0;
		NewListOfNextBegins = true;
	}
}
