using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        public string[] row = new string[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public int choice;
        static int player = 1;
        public static object arr;

        



        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Rigby()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(28, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("VS");







            Console.SetCursorPosition(2, 19);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Rigby:X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);





        }


        public void Mordecai()
        {

            Console.SetCursorPosition(28, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("VS");
            Console.SetCursorPosition(2, 25);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Mordecai:O");


            Console.SetCursorPosition(2, 26);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 28);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
        }





        public bool coordinateWin()
        {
            for (int x = 1; x < player; ++x)
            {
               
            }

            Console.WriteLine("\n");

            if (player % 1 == 0)

            {

                Console.WriteLine("Mordecai Chance");

            }

            else

            {

                Console.WriteLine("Rigby Chance");

            }
            Console.WriteLine("\n");
            if (row[0] == "O" && row[1] == "O" && row[2] == "O") 
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }
            else if (row[0] == "O" && row[1] == "O" && row[2] == "O")
            {
                return true;
            }

            if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {
                return true;
            }
            else if (row[0] == "X" && row[1] == "X" && row[2] == "X")
            {

            }
            return false;
        }
     





    }


 }
























