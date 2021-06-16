using System;
/*****************************************************************************
 * "1" Boundry Heuristic Founding.
 * "2" Search in Thinking Tree to found Max or Min Heuristic.
 **/
namespace ChessFirst
{
    class CodeClass
    {

        public static void SaveByCode(int Code, int LineCode, String File)
        {
            Object O = new Object();
            lock (O)
            {
                if (!System.IO.File.Exists("CodeLogEvent.log"))
                    System.IO.File.CreateText("CodeLogEvent.log");
                System.IO.File.AppendAllText("CodeLogEvent.log", "\r\nError by " + Code + "At " + LineCode + " LinCode of File " + File);
            }
        }
    }
}


