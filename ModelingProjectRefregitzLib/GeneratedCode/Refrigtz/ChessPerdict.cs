﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Refrigtz
{
	using RefrigtzAll;
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Text;

	internal class ChessPerdict
	{
		public List<AllDraw> A;

		private ChessPerdict APredict;

		public int AStarGreedyGreedy;

		private IEnumerable<int> AStarGreedyIndex;

		public static int BridgeValue;

		public IEnumerable<DrawBridge> BridgesOnTable;

		private int CL;

		private static List<int> ClList;

		public static int ElefantValue;

		public IEnumerable<DrawElefant> ElephantOnTable;

		public static int HourseValue;

		public IEnumerable<DrawHourse> HoursesOnTable;

		private int Ki;

		private static List<int> KiList;

		public IEnumerable<DrawKing> KingOnTable;

		public static int KingValue;

		public static int LoopHuristicIndex;

		public IEnumerable<DrawMinister> MinisterOnTable;

		public static int MinisterValue;

		public static int MouseClick;

		public int Move;

		private int OrderDummy;

		private int RW;

		private static List<int> RWList;

		public static int SodierValue;

		public IEnumerable<DrawSoldier> SolderesOnTable;

		private FormRefrigtz THIS;

		public List<int> TableList;

		public static List<int> TableListAction;

		private static void Log(Exception ex)
		{
			throw new System.NotImplementedException();
		}

		public ChessPerdict(ref FormRefrigtz Th)
		{
		}

		public virtual bool AllCurrentAStarGreedyThinkingFinished(AllDraw Dum, int i, int j, int Kind)
		{
			throw new System.NotImplementedException();
		}

		public virtual IEnumerable<int> HuristicKish(List<AllDraw> A, Color a, int ij, ref Double Less, int Order)
		{
			throw new System.NotImplementedException();
		}

		public virtual void InitiateForEveryKindThingHome(AllDraw DummyHA, int ii, int jj, Color a, IEnumerable<int> Table, int Order, bool TB, int IN)
		{
			throw new System.NotImplementedException();
		}

		public virtual IEnumerable<int> InitiatePerdictKish(int ii, int jj, Color a, IEnumerable<int> Table, int Order, bool TB)
		{
			throw new System.NotImplementedException();
		}

		public virtual bool InitiatePerdictKishEnemy(int ii, int jj, Color a, IEnumerable<int> Table, int Order, bool TB)
		{
			throw new System.NotImplementedException();
		}

		public virtual void SetRowColumn(int index)
		{
			throw new System.NotImplementedException();
		}

		private void Wait(AllDraw Dum, int i, int j, int Kind)
		{
			throw new System.NotImplementedException();
		}

	}
}

