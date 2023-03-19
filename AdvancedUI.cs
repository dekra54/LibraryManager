using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public static class AdvancedUI
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        public static void StartAdvancedUI()
        {
            //Import the windows dll to allow extra functions for the console. got this from stackoverflow


            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            int ConsoleWidth = Console.WindowWidth;
            int ConsoleHeight = Console.WindowHeight;

            bool ProgramRun = true; //Set this to true so the Programm closes
            char FunctionEntry = ' ';

            //Define the Characters for the Outlines
            char TopLeftCorner = '╔';
            char TopRightCorner = '╗';
            char BottomLeftCorner = '╚';
            char BottomRightCorner = '╝';
            char Horizontal = '═';
            char Vertical = '║';
            char LightFill = '░';


            Console.ForegroundColor = ConsoleColor.DarkYellow;


            //Heights are counted from the Top beginning at 0
            int ProgramTitleBoxHeight = 4;
            int MenuHeight = 6;


            //This is counted Backwards from the console Bottom
            int CreatorNamesPosition = ConsoleHeight - 2;
            int OutputLine = ConsoleHeight - 4;


            //Menu Items
            string MenuFunctions = " Menu: Type 1 for this │ 2 for abc │";

            //Calculate the Position of the Courser for Choosing the function
            string MenuText2 = "Type Number to choose function:";

            int NumberOfSpaces = ConsoleWidth - 5 - (MenuFunctions.Length + MenuText2.Length);
            for (int i = 0; i < NumberOfSpaces; i++)
            {
                MenuFunctions = MenuFunctions + " ";
            }
            string MenuString = MenuFunctions + MenuText2;


            // Save The Postition of the Cursor for later
            int[] MenuCursorPosition = { MenuString.Length + 1, MenuHeight - 1 };

            //DrawCorners


            Console.Write(TopLeftCorner);
            Console.SetCursorPosition(ConsoleWidth - 1, 0);
            Console.Write(TopRightCorner);
            Console.SetCursorPosition(ConsoleWidth - 1, ConsoleHeight - 1);
            Console.Write(BottomRightCorner);
            Console.SetCursorPosition(0, ConsoleHeight - 1);
            Console.Write(BottomLeftCorner);

            //Draw Horizontal Border Lines


            Console.SetCursorPosition(1, 0);
            for (int i = 0; i < ConsoleWidth - 2; i++)
            {

                Console.Write(Horizontal);
            }
            Console.SetCursorPosition(1, ConsoleHeight - 1);
            for (int i = 0; i < ConsoleWidth - 2; i++)
            {
                Console.Write(Horizontal);
            }

            //Draw Vertical Lines
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < ConsoleHeight - 1; i++)
            {

                Console.Write(Vertical);
                Console.SetCursorPosition(0, i + 1);
            }

            Console.SetCursorPosition(ConsoleWidth - 1, 1);
            for (int i = 0; i < ConsoleHeight - 1; i++)
            {
                Console.Write(Vertical);
                Console.SetCursorPosition(ConsoleWidth - 1, i + 1);
            }


            //Create Horizontal Line for Program Title
            WriteHorizontalLine(ProgramTitleBoxHeight, ConsoleWidth, Horizontal, true);

            /* Replaced by Method to not do it over and over
            Console.SetCursorPosition(1, ProgramTitleBoxHeight);
            for (int i = 0; i < ConsoleWidth - 2; i++)
            {
                Console.Write(Horizontal);
            }
            
            //Add "Ts" for Programmtitle Box
            Console.SetCursorPosition(0, ProgramTitleBoxHeight);
            Console.Write('╠');
            Console.SetCursorPosition(ConsoleWidth - 1, ProgramTitleBoxHeight);
            Console.Write('╣');
            */

            //Fill Programtitle Box before anything gets written in there  so we dont need to delete stuff
            Console.SetCursorPosition(1, 1);
            for (int i = 1; i < ProgramTitleBoxHeight; i++)
            {
                for (int j = 1; j < ConsoleWidth - 1; j++)
                {
                    Console.Write(LightFill);
                    Console.SetCursorPosition(j, i);
                }

            }
            Console.Write(LightFill);

            //Write the Programm name and Version
            string ProgramName = "LibraryManager Version 0.1";
            Console.SetCursorPosition(ConsoleWidth / 2 - ProgramName.Length / 2, 2);
            Console.Write(ProgramName);

            //Print the Menu

            Console.SetCursorPosition(MenuString.Length + 1, MenuHeight - 1);

            //Write Horizontal Line for the Menu
            WriteHorizontalLine(MenuHeight, ConsoleWidth, Horizontal, true);
            Console.SetCursorPosition(1, MenuHeight - 1);
            Console.Write(MenuString);

            WriteHorizontalLine(CreatorNamesPosition - 1, ConsoleWidth, Horizontal, true);



            string CreatorNames = "Created by: Ana ; Giovanna ; Lucas ; Marcos";

            Console.SetCursorPosition(ConsoleWidth / 2 - CreatorNames.Length / 2, CreatorNamesPosition);
            Console.Write(CreatorNames);




            


            //Main Program Loop
            while (ProgramRun)
            {

                Console.SetCursorPosition(MenuCursorPosition[0], MenuCursorPosition[1]); //Always set Cursor Postion back to the Menu end
                ConsoleKeyInfo

                key = Console.ReadKey();
                FunctionEntry = Convert.ToChar(key.KeyChar.ToString());

                if (char.IsAsciiDigit(FunctionEntry))
                {
                    WriteMessage(FunctionEntry.ToString(), OutputLine);
                }
                else
                {
                    //If we land here the entered key is most likely not a number so we delete the entry
                    Console.SetCursorPosition(MenuCursorPosition[0], MenuCursorPosition[1]); //Always set Cursor Postion back to the Menu end
                    Console.Write("_\b");

                    //Print an error
                    WriteMessage("Command not recognized!", OutputLine);

                }

            }

        

        //Function for drawing the Horizontal lines with or without the Ts

        }

        static void WriteHorizontalLine(int VerticalPosition, int ConsoleWidth, char CharacterForLine, bool AddT)
        {
            Console.SetCursorPosition(1, VerticalPosition);
            for (int i = 0; i < ConsoleWidth - 2; i++)
            {
                Console.Write(CharacterForLine);
            }
            if (AddT)
            {
                Console.SetCursorPosition(0, VerticalPosition);
                Console.Write('╠');
                Console.SetCursorPosition(ConsoleWidth - 1, VerticalPosition);
                Console.Write('╣');

            }
        }

        //Needs to be made Prettier only for debugging now
        /// <summary>
        /// Writes a String at the Specified Line
        /// </summary>
        /// <param name="Message">The String thats supposed to be Written</param>
        /// <param name="Line">The LineNumber where the Message should appear (Counted from the Top. Starting at 0</param>
        public static void WriteMessage(string Message, int Line)
        {
            Console.SetCursorPosition(1, Line);
            Console.Write(Message);
        }

        /// <summary>
        /// 
        /// <summary>
        /// Writes a String at the Specified Line
        /// </summary>
        /// <param name="Message">The String thats supposed to be Written</param>
        /// <param name="Line">The LineNumber where the Message should appear (Counted from the Top. Starting at 0</param>
        /// <param name="isError">If set to true the Text appears in red</param>
        public static void WriteMessage(string Message, int Line, bool isError)
        {
            Console.SetCursorPosition(1, Line);
            Console.Write(Message);
        }
    }
}
