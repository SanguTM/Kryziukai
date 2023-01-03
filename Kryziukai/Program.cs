using System;
using System.Threading;

namespace Kryziukai
{
    public class Program
    {


        //making array and
        //by default I am providing 0-9 where no use of zero
        static string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };
        //static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static string player = "O"; //By default player 1 is set
        static int choice; //This holds the choice at which position user want to mark
        // The flag variable checks who has won if it's value is 1 then someone has won the match
        //if -1 then Match has Draw if 0 then match is still running
        static int flag = 0;
        private static int choise;
        int boardSize = 3;

        static void Main(string[] args)
        {

            int boardSize = ChooseBoard();

            GameStart(boardSize);

        }
        // Board method which creats board
        public static void Board(int boardSize)
        {
            if (boardSize == 3)
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
            }

            if (boardSize == 4)
            {
                Console.WriteLine("     |     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[1], arr[2], arr[3], arr[10]);
                Console.WriteLine("_____|_____|_____|_____ ");
                Console.WriteLine("     |     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[4], arr[5], arr[6], arr[11]);
                Console.WriteLine("_____|_____|_____|_____ ");
                Console.WriteLine("     |     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}", arr[7], arr[8], arr[9], arr[12]);
                Console.WriteLine("_____|_____|_____|_____ ");
                Console.WriteLine("     |     |     |      ");
                Console.WriteLine(" {0}  | {1}  | {2}  | {3}", arr[13], arr[14], arr[15], arr[16]);
                Console.WriteLine("     |     |     |      ");
            }
            if (boardSize == 5)
            {
                Console.WriteLine("     |     |     |     |     |     ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3} |  {4}  |", arr[1], arr[2], arr[3], arr[10], arr[17]);
                Console.WriteLine("_____|_____|_____|__________| ");
                Console.WriteLine("     |     |     |     |       |");
                Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[4], arr[5], arr[6], arr[11], arr[18]);
                Console.WriteLine("_____|_____|_____|_____|_____| ");
                Console.WriteLine("     |     |     |     |     |");
                Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", arr[7], arr[8], arr[9], arr[12], arr[19]);
                Console.WriteLine("_____|_____|_____|_____|_____| ");
                Console.WriteLine("     |     |     |     |     | ");
                Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[13], arr[14], arr[15], arr[16], arr[20]);
                Console.WriteLine("_____|_____|_____|_____|_____| ");
                Console.WriteLine("     |     |     |     |     | ");
                Console.WriteLine(" {0}  | {1}  | {2}  | {3}  |  {4}  |", arr[21], arr[22], arr[23], arr[24], arr[25]);
                Console.WriteLine("     |     |     |     |     |      ");
            }

        }
        //Checking that any player has won or not
        public static int CheckWin(int v)
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            if (arr[2] == arr[3] && arr[3] == arr[10])
            {
                return 1;
            }
            if (arr[3] == arr[10] && arr[10] == arr[17])
            {
                return 1;
            }

            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[5] == arr[6] && arr[6] == arr[11])
            {
                return 1;
            }
            else if (arr[6] == arr[11] && arr[11] == arr[18])
            {
                return 1;
            }

            //Winning Condition For Third Row
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            else if (arr[8] == arr[9] && arr[9] == arr[12])
            {
                return 1;
            }
            else if (arr[9] == arr[12] && arr[12] == arr[19])
            {
                return 1;
            }

            //Winning Condition For Fourth Row
            else if (arr[13] == arr[14] && arr[14] == arr[15])
            {
                return 1;
            }
            else if (arr[14] == arr[15] && arr[15] == arr[16])
            {
                return 1;
            }
            else if (arr[15] == arr[16] && arr[16] == arr[20])
            {
                return 1;
            }
            //Winning Condition For Fifth Row
            else if (arr[21] == arr[22] && arr[22] == arr[23])
            {
                return 1;
            }
            else if (arr[22] == arr[23] && arr[23] == arr[24])
            {
                return 1;
            }
            else if (arr[23] == arr[24] && arr[24] == arr[25])
            {
                return 1;
            }

            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[4] == arr[7] && arr[7] == arr[13])
            {
                return 1;
            }
            else if (arr[7] == arr[13] && arr[13] == arr[21])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[5] == arr[8] && arr[8] == arr[14])
            {
                return 1;
            }
            else if (arr[8] == arr[14] && arr[14] == arr[22])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[6] == arr[9] && arr[9] == arr[12])
            {
                return 1;
            }
            else if (arr[9] == arr[15] && arr[15] == arr[23])
            {
                return 1;
            }
            //Winning Condition For Fourth Column
            else if (arr[10] == arr[11] && arr[11] == arr[12])
            {
                return 1;
            }
            else if (arr[11] == arr[12] && arr[12] == arr[16])
            {
                return 1;
            }
            else if (arr[12] == arr[16] && arr[16] == arr[24])
            {
                return 1;
            }
            //Winning Condition For Fourth Column
            else if (arr[17] == arr[18] && arr[18] == arr[19])
            {
                return 1;
            }
            else if (arr[18] == arr[19] && arr[19] == arr[20])
            {
                return 1;
            }
            else if (arr[19] == arr[20] && arr[20] == arr[25])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[5] == arr[9] && arr[9] == arr[16])
            {
                return 1;
            }
            else if (arr[2] == arr[6] && arr[6] == arr[12])
            {
                return 1;
            }
            else if (arr[4] == arr[8] && arr[8] == arr[15])
            {
                return 1;
            }
            else if (arr[10] == arr[6] && arr[6] == arr[8])
            {
                return 1;
            }
            else if (arr[6] == arr[8] && arr[8] == arr[13])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[11] == arr[9] && arr[9] == arr[14])
            {
                return 1;
            }
            else if (arr[17] == arr[11] && arr[11] == arr[9])
            {
                return 1;
            }
            else if (arr[11] == arr[9] && arr[9] == arr[14])
            {
                return 1;
            }
            else if (arr[9] == arr[14] && arr[14] == arr[21])
            {
                return 1;
            }
            else if (arr[18] == arr[12] && arr[12] == arr[15])
            {
                return 1;
            }
            else if (arr[12] == arr[15] && arr[15] == arr[22])
            {
                return 1;
            }
            else if (arr[19] == arr[16] && arr[16] == arr[23])
            {
                return 1;
            }
            else if (arr[3] == arr[11] && arr[11] == arr[19])
            {
                return 1;
            }
            else if (arr[6] == arr[12] && arr[12] == arr[20])
            {
                return 1;
            }
            else if (arr[9] == arr[16] && arr[16] == arr[25])
            {
                return 1;
            }
            else if (arr[8] == arr[15] && arr[15] == arr[24])
            {
                return 1;
            }
            else if (arr[7] == arr[14] && arr[14] == arr[23])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (v == 3 && arr[1] != "1" && arr[2] != "2" && arr[3] != "3" && arr[4] != "4" && arr[5] != "5" && arr[6] != "6" && arr[7] != "7" && arr[8] != "8" && arr[9] != "9")
            {
                return -1;
            }
            else if (v == 4 && arr[1] != "1" && arr[2] != "2" && arr[3] != "3" && arr[4] != "4" && arr[5] != "5" && arr[6] != "6" && arr[7] != "7" && arr[8] != "8" && arr[9] != "9"
                && arr[10] != "10" && arr[11] != "11" && arr[12] != "12" && arr[13] != "13" && arr[14] != "14" && arr[15] != "15" && arr[16] != "16")
            {
                return -1;
            }
            else if (v == 5 && arr[1] != "1" && arr[2] != "2" && arr[3] != "3" && arr[4] != "4" && arr[5] != "5" && arr[6] != "6" && arr[7] != "7" && arr[8] != "8" && arr[9] != "9"
                && arr[10] != "10" && arr[11] != "11" && arr[12] != "12" && arr[13] != "13" && arr[14] != "14" && arr[15] != "15" && arr[16] != "16" && arr[17] != "17" && arr[18] != "18"
                && arr[19] != "19" && arr[20] != "20" && arr[21] != "21" && arr[22] != "22" && arr[23] != "23" && arr[24] != "24" && arr[25] != "25")
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
        public static int ChooseBoard()
        {
            int boardSize;
            int c;

            Console.WriteLine("Please choose board size/n");
            Console.WriteLine("Type 1 for 3x3;/n");
            Console.WriteLine("Type 2 for 4x4;/n");
            Console.WriteLine("Type 3 for 5x5;/n");
            c = int.Parse(Console.ReadLine());

            if (c == 2)
            {
                return boardSize = 4;
            }
            else if (c == 3)
            {
                return boardSize = 5;
            }
            else
            {
                return boardSize = 3;
            }
        }

        public static bool IsFieldFree()
        {
            choice = int.Parse(Console.ReadLine());//Taking users choice

            // checking that position where user want to run is marked (with X or O) or not
            if (arr[choice] != "X" && arr[choice] != "O")
            {
                return true;
            }
            else
            //If there is any possition where user want to run
            //and that is already marked then show message and load board again
            {
                Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait 2 second board is loading again.....");
                Thread.Sleep(2000);

                return false;
            }
        }

        public static void Score(int flag, string player, int score)
        {
            int ScoreX = score;
            int ScoreO = score;
            if (flag == 1 && player == "X")
            {
                ScoreX = ScoreX + 1;
            }
            if (flag == 1 && player == "O")
            {
                ScoreO = ScoreO + 1;
            }
            Console.WriteLine("Player X: {0}; Player Y: {1}", ScoreX, ScoreO);
        }

        public static void GameStart(int boardSize)
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player == "X")//checking the chance of the player
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Board(boardSize);// calling the board Function

                bool Free = IsFieldFree();

                if (Free == true)
                {
                    if (player == "X") //if chance is of player 2 then mark O else mark X
                    {
                        arr[choice] = "O";
                        player = "O";
                    }
                    else
                    {
                        arr[choice] = "X";
                        player = "X";
                    }
                }

                int v = boardSize;

                flag = CheckWin(v);// calling of check win
            }
            while (flag != 1 && flag != -1);
            // This loop will be run until all cell of the grid is not marked
            //with X and O or some player is not win
            Console.Clear();// clearing the console
            Board(boardSize);// getting filled board again
            if (flag == 1)
            // if flag value is 1 then someone has win or
            //means who played marked last time which has win
            {
                Score(flag, player, 1);
                Console.WriteLine("Player {0} has won", player);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

       public static void InitArr(string[] _arr)
        {
            //static const arr;
            arr = _arr;
        }
    }
}
