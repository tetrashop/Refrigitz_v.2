#include "RulesQuantum.h"


namespace QuantumRefrigiz
{

	RulesQuantum::RulesQuantum(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int Ki, int A[][], int Ord, int i, int j) : ChessRules(CurrentAStarGredy, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, ArrangmentsChanged, Ki,A,Ord,i,j)
	{

		/*Modifications to existing chess rules
	
		A player is not required to move their king out of check and the game concludes when there is a 100% probability that one of the kings has been taken. As a result there is no checkmate.
		All promotions result in a queen as of 10/8/17, since underpromoting has not been implemented into the game.
	
	Movement
	
		All pieces move as usual in normal circumstances.
		On any given turn, the player can make one quantum move instead of a normal move.
	
	Quantum moves
	
		Quantum moves are notated with the ^ symbol. (e.g: N^d4)
		When quantum moving a piece, it can make up to two normal moves.
		The probability of the piece moving is equal to the probability that the piece has not moved, resulting in a superposition of multiple board states.
		A quantum move cannot be used to take a piece.
		Pawns cannot make quantum moves.
	
	Quantum move of Knight
	
	Superposition
	
		When any quantum move is made, that piece exists in multiple places simultaneously. This is represented by multiple copies of the piece displayed, with appropriate meters to show the probability of finding the piece in that square. There is only one piece, but it can exist in one of multiple places.
	
		If a piece "takes" one of the copies of another piece in superposition and has 100% probability of being available to take it, the piece is taken if it was in that square. Since there is a probability of the piece being in other squares, those copies of the piece remain, however there is now a chance that the piece has already been taken and is no longer on the board.
	
	Taking superposed pieces.
	
		If a piece "takes" one of the copies of another piece in superposition and it is not certain that the piece was available to take it, a measurement occurs. A measured piece will collapse onto one square using a random selection. The probability of it collapsing onto a particular square is the same as the probability that is was moved there. All pieces that are entangled with the measured piece will also be measured and may have their outcome influenced by the measurement of the piece(s) that they are entangled with.
	
	Measurement resulting from quantum capture.
	
		A pawn can be put into superposition if it takes a piece which is in superposition. If the piece was there, the pawn could take it. If not, moving diagonally was an illegal move. The probability of the pawn being on the new square is the same as the probability that a piece was there to be taken.
	
	Pawn superimposed by taking a piece in superposition.
	
		A pawn can also be superimposed by moving two spaces forward, through a square which may contain a piece. This results in entanglement.
	
	Pawn becoming entangled with a bishop.
	
	Entanglement
	
		Entanglement occurs when a piece attempts to move through an instance of a piece in superposition. The probability of the moved piece existing in its new square is the same as the probability that the obstruction was not there to b//lock it.
		If a piece is entangled with another piece and is measured, both pieces are affected by the results of the measurement accordingly.
	
	Special circumstances
	
	The following "rules" are combinations of rules from above, however they are worth mentioning as useful tactics:
	
	Quantum Trading
	
		It is possible to trade probabilities of pieces, leading to complex trading. For example, it is possible to trade knights in a way which leaves one player with a 2/3 chance of having a knight, and the other with a 1/3 chance of having a knight. The first player is more likely to have benefited from this trade, however it is uncertain until measured.
	
	Schrödinger's King
	
		If the king is in superposition and one of the instances is taken, the probability that that player has lost is equal to the probability that the king was in that square. Since it is not certain that they have lost, play continues.
		This means that it is possible for a player to win a game with a probability that they have already lost by fully capturing the opposing king.
	
	Using quantum moves to escape checkmate.
	
	Ghost capture
	
		This is a result of a pawn taking a piece in superposition. If there is one other state of the taken piece still on the board and a piece attacking it, ghost capture can take place. If the attacking piece must move through the square where the pawn would be if it hadn't moved in order to attack the superimposed piece, two outcomes can occur:
	The measurement confirms that the piece had not moved, so an attack is impossible and the opposing player gains "half a piece".
	The measurement shows that the piece has moved and has already been taken, so the opposing player loses "half a piece".
	
	Attempted ghost capture of opposing queen using rook.
	
	Quantum Castling
	
		If there is a probability that a piece is between the king and rook, the probability of castling is equal to the probability that the piece was not there. A measurement may take place if two pieces end up on the same square.
		If there is a probability that the rook may have moved, castling can occur with the probability that the rook is available to castle. The king and rook are now entangled since the castling move depends on whether the rook was on the correct square.
	
	Double Castling
	
		After a quantum castle, the king can castle the other way if the rook is available, with the probability of castling being the probability that the king is there.
	In this example, both sides have castled both ways:
	*/
	}

	RulesQuantum::RulesQuantum(int CurrentAStarGredy, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged, int oRDER) : ChessRules(CurrentAStarGredy, oRDER, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, ArrangmentsChanged)

	{
		/*Modifications to existing chess rules
	
		A player is not required to move their king out of check and the game concludes when there is a 100% probability that one of the kings has been taken. As a result there is no checkmate.
		All promotions result in a queen as of 10/8/17, since underpromoting has not been implemented into the game.
	
	Movement
	
		All pieces move as usual in normal circumstances.
		On any given turn, the player can make one quantum move instead of a normal move.
	
	Quantum moves
	
		Quantum moves are notated with the ^ symbol. (e.g: N^d4)
		When quantum moving a piece, it can make up to two normal moves.
		The probability of the piece moving is equal to the probability that the piece has not moved, resulting in a superposition of multiple board states.
		A quantum move cannot be used to take a piece.
		Pawns cannot make quantum moves.
	
	Quantum move of Knight
	
	Superposition
	
		When any quantum move is made, that piece exists in multiple places simultaneously. This is represented by multiple copies of the piece displayed, with appropriate meters to show the probability of finding the piece in that square. There is only one piece, but it can exist in one of multiple places.
	
		If a piece "takes" one of the copies of another piece in superposition and has 100% probability of being available to take it, the piece is taken if it was in that square. Since there is a probability of the piece being in other squares, those copies of the piece remain, however there is now a chance that the piece has already been taken and is no longer on the board.
	
	Taking superposed pieces.
	
		If a piece "takes" one of the copies of another piece in superposition and it is not certain that the piece was available to take it, a measurement occurs. A measured piece will collapse onto one square using a random selection. The probability of it collapsing onto a particular square is the same as the probability that is was moved there. All pieces that are entangled with the measured piece will also be measured and may have their outcome influenced by the measurement of the piece(s) that they are entangled with.
	
	Measurement resulting from quantum capture.
	
		A pawn can be put into superposition if it takes a piece which is in superposition. If the piece was there, the pawn could take it. If not, moving diagonally was an illegal move. The probability of the pawn being on the new square is the same as the probability that a piece was there to be taken.
	
	Pawn superimposed by taking a piece in superposition.
	
		A pawn can also be superimposed by moving two spaces forward, through a square which may contain a piece. This results in entanglement.
	
	Pawn becoming entangled with a bishop.
	
	Entanglement
	
		Entanglement occurs when a piece attempts to move through an instance of a piece in superposition. The probability of the moved piece existing in its new square is the same as the probability that the obstruction was not there to b//lock it.
		If a piece is entangled with another piece and is measured, both pieces are affected by the results of the measurement accordingly.
	
	Special circumstances
	
	The following "rules" are combinations of rules from above, however they are worth mentioning as useful tactics:
	
	Quantum Trading
	
		It is possible to trade probabilities of pieces, leading to complex trading. For example, it is possible to trade knights in a way which leaves one player with a 2/3 chance of having a knight, and the other with a 1/3 chance of having a knight. The first player is more likely to have benefited from this trade, however it is uncertain until measured.
	
	Schrödinger's King
	
		If the king is in superposition and one of the instances is taken, the probability that that player has lost is equal to the probability that the king was in that square. Since it is not certain that they have lost, play continues.
		This means that it is possible for a player to win a game with a probability that they have already lost by fully capturing the opposing king.
	
	Using quantum moves to escape checkmate.
	
	Ghost capture
	
		This is a result of a pawn taking a piece in superposition. If there is one other state of the taken piece still on the board and a piece attacking it, ghost capture can take place. If the attacking piece must move through the square where the pawn would be if it hadn't moved in order to attack the superimposed piece, two outcomes can occur:
	The measurement confirms that the piece had not moved, so an attack is impossible and the opposing player gains "half a piece".
	The measurement shows that the piece has moved and has already been taken, so the opposing player loses "half a piece".
	
	Attempted ghost capture of opposing queen using rook.
	
	Quantum Castling
	
		If there is a probability that a piece is between the king and rook, the probability of castling is equal to the probability that the piece was not there. A measurement may take place if two pieces end up on the same square.
		If there is a probability that the rook may have moved, castling can occur with the probability that the rook is available to castle. The king and rook are now entangled since the castling move depends on whether the rook was on the correct square.
	
	Double Castling
	
		After a quantum castle, the king can castle the other way if the rook is available, with the probability of castling being the probability that the king is there.
	In this example, both sides have castled both ways:
	*/
	}

	RulesQuantum::RulesQuantum(int CurrentAStarGredy, int oRDER, bool MovementsAStarGreedyHuristicTFou, bool IgnoreSelfObject, bool UsePenaltyRegardMechnisa, bool BestMovment, bool PredictHurist, bool OnlySel, bool AStarGreedyHuris, bool ArrangmentsChanged) : ChessRules(CurrentAStarGredy,oRDER, MovementsAStarGreedyHuristicTFou, IgnoreSelfObject, UsePenaltyRegardMechnisa, BestMovment, PredictHurist, OnlySel, AStarGreedyHuris, ArrangmentsChanged)
	{
		/*Modifications to existing chess rules
	
	A player is not required to move their king out of check and the game concludes when there is a 100% probability that one of the kings has been taken. As a result there is no checkmate.
	All promotions result in a queen as of 10/8/17, since underpromoting has not been implemented into the game.
	
		Movement
	
	All pieces move as usual in normal circumstances.
	On any given turn, the player can make one quantum move instead of a normal move.
	
		Quantum moves
	
	Quantum moves are notated with the ^ symbol. (e.g: N^d4)
	When quantum moving a piece, it can make up to two normal moves.
	The probability of the piece moving is equal to the probability that the piece has not moved, resulting in a superposition of multiple board states.
	A quantum move cannot be used to take a piece.
	Pawns cannot make quantum moves.
	
		Quantum move of Knight
	
		Superposition
	
	When any quantum move is made, that piece exists in multiple places simultaneously. This is represented by multiple copies of the piece displayed, with appropriate meters to show the probability of finding the piece in that square. There is only one piece, but it can exist in one of multiple places.
	
	If a piece "takes" one of the copies of another piece in superposition and has 100% probability of being available to take it, the piece is taken if it was in that square. Since there is a probability of the piece being in other squares, those copies of the piece remain, however there is now a chance that the piece has already been taken and is no longer on the board.
	
		Taking superposed pieces.
	
	If a piece "takes" one of the copies of another piece in superposition and it is not certain that the piece was available to take it, a measurement occurs. A measured piece will collapse onto one square using a random selection. The probability of it collapsing onto a particular square is the same as the probability that is was moved there. All pieces that are entangled with the measured piece will also be measured and may have their outcome influenced by the measurement of the piece(s) that they are entangled with.
	
		Measurement resulting from quantum capture.
	
	A pawn can be put into superposition if it takes a piece which is in superposition. If the piece was there, the pawn could take it. If not, moving diagonally was an illegal move. The probability of the pawn being on the new square is the same as the probability that a piece was there to be taken.
	
		Pawn superimposed by taking a piece in superposition.
	
	A pawn can also be superimposed by moving two spaces forward, through a square which may contain a piece. This results in entanglement.
	
		Pawn becoming entangled with a bishop.
	
		Entanglement
	
	Entanglement occurs when a piece attempts to move through an instance of a piece in superposition. The probability of the moved piece existing in its new square is the same as the probability that the obstruction was not there to b//lock it.
	If a piece is entangled with another piece and is measured, both pieces are affected by the results of the measurement accordingly.
	
		Special circumstances
	
		The following "rules" are combinations of rules from above, however they are worth mentioning as useful tactics:
	
		Quantum Trading
	
	It is possible to trade probabilities of pieces, leading to complex trading. For example, it is possible to trade knights in a way which leaves one player with a 2/3 chance of having a knight, and the other with a 1/3 chance of having a knight. The first player is more likely to have benefited from this trade, however it is uncertain until measured.
	
		Schrödinger's King
	
	If the king is in superposition and one of the instances is taken, the probability that that player has lost is equal to the probability that the king was in that square. Since it is not certain that they have lost, play continues.
	This means that it is possible for a player to win a game with a probability that they have already lost by fully capturing the opposing king.
	
		Using quantum moves to escape checkmate.
	
		Ghost capture
	
	This is a result of a pawn taking a piece in superposition. If there is one other state of the taken piece still on the board and a piece attacking it, ghost capture can take place. If the attacking piece must move through the square where the pawn would be if it hadn't moved in order to attack the superimposed piece, two outcomes can occur:
		The measurement confirms that the piece had not moved, so an attack is impossible and the opposing player gains "half a piece".
		The measurement shows that the piece has moved and has already been taken, so the opposing player loses "half a piece".
	
		Attempted ghost capture of opposing queen using rook.
	
		Quantum Castling
	
	If there is a probability that a piece is between the king and rook, the probability of castling is equal to the probability that the piece was not there. A measurement may take place if two pieces end up on the same square.
	If there is a probability that the rook may have moved, castling can occur with the probability that the rook is available to castle. The king and rook are now entangled since the castling move depends on whether the rook was on the correct square.
	
		Double Castling
	
	After a quantum castle, the king can castle the other way if the rook is available, with the probability of castling being the probability that the king is there.
		In this example, both sides have castled both ways:
		*/
	}

	bool RulesQuantum::Rules(int RowFirst, int ColumnFirst, int RowSecond, int ColumnSecond, Color color, int Ki, bool SelfHomeStatCP = true)
	{
		//autoO = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O)
		{
			if (!SelfHomeStatCP)
			{
				IgnoreSelfObject = true;
			}
			else
			{
				IgnoreSelfObject = false;
			}
		}
		//Initaite Global Varibales.
		//autoO1 = new Object();
//C# TO C++ CONVERTER TODO TASK: There is no built-in support for multithreading in native C++:
		//lock (O1)
		{
			CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporter = false;
			CheckObjectDangourIgnoreSelfThingBetweenTowEnemyKingHaveSupporterNumber = 0;
		}
		//When Order is Non Detectable Continue Traversal Back.
		//if (Order != CurrentOrder)
		//  return false;
		//Found Location of Tow Gray and Brown Kings. 
		int RowB = 0, ColumnB = 0;
		int RowG = 0, ColumnG = 0;
		FindBrownKing(Table, RowB, ColumnB);
		FindGrayKing(Table, RowG, ColumnG);

		//Gray Order.
		if ((Order == 1))
		{
			if (Table[RowFirst][ColumnFirst] == 6)
			{
				if (abs(RowB - RowSecond) <= 1 && abs(ColumnB - ColumnSecond) <= 1)
				{
					return false;
				}
			}
			//Illegal King Foundation.
			if (abs(RowB - RowG) <= 1 && abs(ColumnB - ColumnG) <= 1)
			{
				return false;
			}
		} //Brown Order.
		else
		{
			if (Table[RowFirst][ColumnFirst] == -6)
			{
				if (abs(RowG - RowSecond) <= 1 && abs(ColumnG - ColumnSecond) <= 1)
				{
					return false;
				}
			}
			//Ilegal Kings Foundation.
			if (abs(RowB - RowG) <= 1 && abs(ColumnB - ColumnG) <= 1)
			{
				return false;
			}

		}
		//Determination of Enemy in the Destionation Home.
		bool ExistInDestinationEnemy = bool();
		if (((Table[RowFirst][ColumnFirst] > 0) && (Table[RowSecond][ColumnSecond] < 0) && (Order == 1)))
		{
			ExistInDestinationEnemy = true;
		}
		else
		{
			if (((Table[RowFirst][ColumnFirst] < 0) && (Table[RowSecond][ColumnSecond] > 0) && (Order == -1)))
			{
			ExistInDestinationEnemy = true;
			}
		}

		//If There is A Source of Soldier.
		if (abs(Kind) == 1)
		{
			if (!(ArrangmentsBoard))
			{
				//Solders of Gray at Begining.
				if (ColumnFirst == 1 && (Order == 1))
				{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
				}
				else //Solder of Brown At Begining.
				{
					if (ColumnFirst == 6 && (Order == -1))
					{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
					}
				else //Another Solder Movments.
				{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
				}
				}
			}
			else
			{
				//Solders of Gray at Begining.
				if (ColumnFirst == 6 && (Order == 1))
				{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
				}
				else //Solder of Brown At Begining.
				{
					if (ColumnFirst == 1 && (Order == -1))
					{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, true, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
					}
				else //Another Solder Movments.
				{
					return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
				}
				}

			}
		}
		else //For another Kind of Objects.
		{
			return Rule(RowFirst, ColumnFirst, RowSecond, ColumnSecond, false, color, ExistInDestinationEnemy, Ki, SelfHomeStatCP);
		}

	}
}
