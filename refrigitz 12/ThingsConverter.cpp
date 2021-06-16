
#include "AllDraw.h"
#include "ThingsConverter.h"


//namespace RefrigtzDLL
//{

bool ThingsConverter::LoadConvertTable = false;
int **ThingsConverter::TableConverted = nullptr;
bool ThingsConverter::ClickOcurred = false;
bool ThingsConverter::ActOfClickEqualTow = false;

	ThingsConverter::ThingsConverter()
	{
		InitializeInstanceFields();
	}
	//template< typename T >
	ThingsConverter::ThingsConverter(int Arrangments, int i, int j, int a, int **Tab, int Ord, bool TB, int Cur)
	{
		//Initite Global Variables with Local Parameter.
		//THIS = THI;
		InitializeInstanceFields();
		ArrangmentsChanged = Arrangments;
		Row = i;
		Column = j;
		color = a;
		Order = Ord;
		Current = Cur;


	}

	bool ThingsConverter::ConvertOperation(int i, int j, int a, int **Tab, int Ord, bool TB, int Cur)
	{
		//autoOOO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (OOO)
		{
			//Initiate Global variables with Local One.
			Row = i;
			Column = j;
			color = a;
			Order = Ord;
			Current = Cur;
			//If Convert is Act and click tow time occured
			if (!Convert && ActOfClickEqualTow)
			{
				//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					AllDraw::ConvertWait = true;
				}

				//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O1)
				{
					ClickOcurred = true;
				}
				//Set tow time click unclicked.
				//autoO2 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O2)
				{
					ActOfClickEqualTow = false;
				}
				if (!ArrangmentsChanged)
				{
					//Convert State Boolean Variable Consideration.
					if (Order == 1 && Column == 7)
					{
						Convert = true;
					}
					if (Order == -1 && Column == 0)
					{
						Convert = true;
					}
				}
				else
				{
					//Convert State Boolean Variable Consideration.
					if (Order == 1 && Column == 0)
					{
						Convert = true;
					}
					if (Order == -1 && Column == 7)
					{
						Convert = true;
					}
				}
				//If Converted is Occured the Operation od Set and table reference content occured.
				if (Convert)
				{
					bool ASS = false;
					//autoOOOAAA = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
					//lock (OOOAAA)
					{
						ASS = AllDraw::Blitz;
					}
					if (!ASS)
					{
						AllDraw::ConvertedKind = -1;
						AllDraw::SodierConversionOcuured = true;
						//Randomly Number of 4 kind Object.
						int Rand = -1;
						if (AllDraw::Person && AllDraw::StateCP && AllDraw::THISSecradioButtonGrayOrderChecked)
						{
							if (AllDraw::OrderPlate == 1)
							{
								while (AllDraw::ConvertedKind == -1)
								{
									//delay(100);
								}

								Rand = AllDraw::ConvertedKind;

								AllDraw::ConvertedKind = -2;

							}
						}
						else
						{
							if (AllDraw::Person && AllDraw::StateCP && AllDraw::THISSecradioButtonBrownOrderChecked)
							{
							if (AllDraw::OrderPlate == -1)
							{
								//(new FormُSelectItems()).ShowDialog();
								while (AllDraw::ConvertedKind == -1)
								{
									//delay(100);
								}

								Rand = AllDraw::ConvertedKind;

								AllDraw::ConvertedKind = -2;
							}
							}
						else
						{
							Rand = (rand() % 5);
						}
						}
						//If Rand is Equaled the Operation will cuased automaticcally Base on int..
						if (Rand == 0)
						{
							if (Order == 1)
							{
								// MinisterMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								//MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = 5;
							}
							else if (Order == -1)
							{
								//MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = -5;
							}
							ConvertedToMinister = true;
						}
						else if (Rand == 1)
						{
							if (Order == 1)
							{
								//CastleMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								//CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = 4;
							}
							else if (Order == -1)
							{
								//CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = -4;
							}
							ConvertedToCastle = true;
						}
						else if (Rand == 2)
						{
							if (Order == 1)
							{
								//HourseMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								//HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = 3;
							}
							else if (Order == -1)
							{
								//HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = -3;

							}
							ConvertedToHourse = true;
						}
						else
						{
							if (Order == 1)
							{
								//ElefantMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								//ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = 2;
							}
							else if (Order == -1)
							{
								//ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
								Tab[Row][Column] = -2;
							}
							ConvertedToElefant = true;
						}
					}
					else
					{
						if (AllDraw::OrderPlate == 1)
						{
							AllDraw::ConvertedKind = -1;
							AllDraw::SodierConversionOcuured = true;
							//Randomly Number of 4 kind Object.
							int Rand = -1;
							if (AllDraw::Person && AllDraw::StateCP && AllDraw::THISSecradioButtonGrayOrderChecked)
							{
								if (AllDraw::OrderPlate == 1)
								{
									while (AllDraw::ConvertedKind == -1)
									{
										//delay(100);
									}

									Rand = AllDraw::ConvertedKind;

									AllDraw::ConvertedKind = -2;
								}
							}
							else
							{
								if (AllDraw::Person && AllDraw::StateCP && AllDraw::THISSecradioButtonBrownOrderChecked)
								{
								if (AllDraw::OrderPlate == -1)
								{
									while (AllDraw::ConvertedKind == -1)
									{
										//delay(100);
									}

									Rand = AllDraw::ConvertedKind;

									AllDraw::ConvertedKind = -2;
								}
								}
							else
							{
								Rand = (rand() % 5);
							}
							}
							//If Rand is Equaled the Operation will cuased automaticcally Base on int..
							if (Rand == 0)
							{
								if (Order == 1)
								{
									//  MinisterMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 5;
								}
								else if (Order == -1)
								{
									//MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -5;
								}
								ConvertedToMinister = true;
							}
							else if (Rand == 1)
							{
								if (Order == 1)
								{
									//CastleMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 4;
								}
								else if (Order == -1)
								{
									//CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -4;
								}
								ConvertedToCastle = true;
							}
							else if (Rand == 2)
							{
								if (Order == 1)
								{
									//HourseMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 3;
								}
								else if (Order == -1)
								{
									//HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -3;

								}
								ConvertedToHourse = true;
							}
							else
							{
								if (Order == 1)
								{
									//ElefantMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 2;
								}
								else if (Order == -1)
								{
									//ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -2;
								}
								ConvertedToElefant = true;
							}
						}


						else
						{



							AllDraw::ConvertedKind = -1;
							AllDraw::SodierConversionOcuured = true;
							//Randomly Number of 4 kind Object.
							int Rand = -1;
							if (AllDraw::Person && AllDraw::StateCP && AllDraw::THISSecradioButtonGrayOrderChecked)
							{
								if (AllDraw::OrderPlate == 1)
								{
									while (AllDraw::ConvertedKind == -1)
									{
										//delay(100);
									}

									Rand = AllDraw::ConvertedKind;

									AllDraw::ConvertedKind = -2;
								}
							}
							else
							{
								if (AllDraw::Person && AllDraw::StateCP && AllDraw::THISSecradioButtonBrownOrderChecked)
								{
								if (AllDraw::OrderPlate == -1)
								{
									while (AllDraw::ConvertedKind == -1) // System.Threading.Thread.Sleep(100);
									{
									}

									Rand = AllDraw::ConvertedKind;

									AllDraw::ConvertedKind = -2;
								}
								}
							else
							{
								Rand = (rand() % 5);
							}
							}
							//If Rand is Equaled the Operation will cuased automaticcally Base on int..
							if (Rand == 0)
							{
								if (Order == 1)
								{
									//MinisterMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 5;
								}
								else if (Order == -1)
								{
									//MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -5;
								}
								ConvertedToMinister = true;
							}
							else if (Rand == 1)
							{
								if (Order == 1)
								{
									//CastleMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 4;
								}
								else if (Order == -1)
								{
									//CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -4;
								}
								ConvertedToCastle = true;
							}
							else if (Rand == 2)
							{
								if (Order == 1)
								{
									//HourseMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 3;
								}
								else if (Order == -1)
								{
									//HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -3;

								}
								ConvertedToHourse = true;
							}
							else
							{
								if (Order == 1)
								{
									//ElefantMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									//ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = 2;
								}
								else if (Order == -1)
								{
									//ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
									Tab[Row][Column] = -2;
								}
								ConvertedToElefant = true;
							}
						}
					}
					AllDraw::ConvertWait = false;

				}
			}
			AllDraw::ConvertWait = false;
			if (Convert)
			{
				//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O)
				{
					TableConverted = new int*[8]; for (int ii = 0; ii < 8; ii++)TableConverted[ii] =new  int[8];
					 
					for (int iii = 0; iii < 8; iii++)
					{
						for (int jjj = 0; jjj < 8; jjj++)
						{
							TableConverted[iii][jjj] = Tab[iii][jjj];
						}
					}
				}
				//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
				//lock (O1)
				{
					LoadConvertTable = true;
				}


			}
			//delay(100);
			//return Convert State.
			return Convert;
		}
	}

	void ThingsConverter::InitializeInstanceFields()
	{
		ArrangmentsChanged = false;
		Convert = false;
		ConvertedToMinister = false;
		ConvertedToCastle = false;
		ConvertedToElefant = false;
		ConvertedToHourse = false;
		Max = 0;
		Row = 0;
		Column = 0;
		Order = 0;
		Current = 0;
	}
//}
