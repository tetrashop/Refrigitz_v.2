#include "RefregitzOperator.h"


namespace GalleryStudio
{

std::wstring RefregitzOperator::Root = System::IO::Path::GetDirectoryName(Environment::GetCommandLineArgs()[0]);
const std::wstring RefregitzOperator::SAllDraw = L"AllDraw.asd";

	void RefregitzOperator::Log(std::exception &ex)
	{
		try
		{
			//autoa = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
			//lock (a)
			{
				std::wstring stackTrace = ex.what();
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				File::AppendAllText(Root + std::wstring(L"\\ErrorProgramRun.txt"), stackTrace + std::wstring(L": On") + DateTime::Now.ToString()); // path of file where stack trace will be stored.
			}
		}
		catch (std::exception &t)
		{
			Log(t);
		}
	}

	RefregitzOperator::RefregitzOperator(int Order, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool Arrangments)
	{
		InitializeInstanceFields();
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
			RefrigtzDLL::AllDraw *Current = new RefrigtzDLL::AllDraw(Order, MovementsAStarGreedyHuristicFoundT, IgnoreSelfObjectsT, UsePenaltyRegardMechnisamT, BestMovmentsT, PredictHuristicT, OnlySelfT, AStarGreedyHuristicT, ArrangmentsT);
		}
	}

	RefrigtzDLL::AllDraw *RefregitzOperator::GetRefregiz(int No)
	{
		//autoo = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (o)
		{

			FileStream *DummyFileStream = nullptr;
			DummyFileStream = new FileStream(SAllDraw, System::IO::FileMode::OpenOrCreate, System::IO::FileAccess::Read);
			int p = 0;
			RefrigtzDLL::AllDraw *Dummy = nullptr;
			BinaryFormatter *Formatters = new BinaryFormatter();
			DummyFileStream->Seek(0, SeekOrigin::Begin);
			try
			{
				while (p <= No)
				{
					if (DummyFileStream->Length >= DummyFileStream->Position)
					{
						Dummy = static_cast<RefrigtzDLL::AllDraw*>(Formatters->Deserialize(DummyFileStream));
					}
					else
					{
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
						delete Dummy;
					}
					p++;
				}
				DummyFileStream->Flush();
				DummyFileStream->Close();
			}
			catch (SerializationException t)
			{
//C# TO C++ CONVERTER TODO TASK: There is no native C++ equivalent to 'ToString':
				std::cout << t->Message->ToString() << std::endl;
//C# TO C++ CONVERTER WARNING: C# to C++ Converter converted the original 'null' assignment to a call to 'delete', but you should review memory allocation of all pointer variables in the converted code:
				delete Dummy;
			}
			return Dummy;
		}
	}

	void RefregitzOperator::InitializeInstanceFields()
	{
		MovementsAStarGreedyHuristicFoundT = false;
		IgnoreSelfObjectsT = false;
		UsePenaltyRegardMechnisamT = true;
		BestMovmentsT = false;
		PredictHuristicT = true;
		OnlySelfT = false;
		AStarGreedyHuristicT = false;
		ArrangmentsT = false;
	}
}
