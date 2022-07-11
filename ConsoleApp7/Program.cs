using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringss = { "n", "n", "n", "n", "n", "n", "n", "n", "n" };
            for (int k = 0; k < 10; k++)
            {
                Print(stringss);
                string turn = ChangeTurn( k);
                Console.WriteLine(turn);
                string newTurn = Test(k);
                k = CheckInput(stringss, newTurn, k);
                string winner = WinCheck(stringss,k);
                if (winner != "")
                {
                    Console.WriteLine(winner);
                    Print(stringss);
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                }
            }  
        }
        public static int CheckInput(string[] stringss, string whoseTurn, int k)
        {
            {
                Console.WriteLine("Pls Input The Number");
                int inputx = Convert.ToInt32(Console.ReadLine());
                switch (inputx)
                {
                    case 1:
                        {
                            if (stringss[0] == "X" || stringss[0] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[0] = whoseTurn;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (stringss[1] == "X" || stringss[1] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[1] = whoseTurn;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (stringss[2] == "X" || stringss[2] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[2] = whoseTurn;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (stringss[3] == "X" || stringss[3] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[3] = whoseTurn;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (stringss[4] == "X" || stringss[4] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[4] = whoseTurn;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (stringss[5] == "X" || stringss[5] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[5] = whoseTurn;
                            }
                            break;
                        }
                    case 7:
                        {
                            if (stringss[6] == "X" || stringss[6] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[6] = whoseTurn;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (stringss[7] == "X" || stringss[7] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[7] = whoseTurn;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (stringss[8] == "X" || stringss[8] == "Y")
                            {
                                Console.WriteLine("Sorry you can't place here. Try another place!");
                                k--;
                            }
                            else
                            {
                                stringss[8] = whoseTurn;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry you can't place here. Try another place!");
                            k--;
                            break;
                        }     
                }
                return k;
            }
        }
        public static string ChangeTurn(int k)
        {
            string turn = "";
            if (k % 2 == 0)
            { 
                turn = "Player 1 turn: ";
            }
            else
            {
                turn = "Player 2 turn: ";
            }
            return turn;
        }
        public static string Test(int k)
        {
            string whoseTurn;
            if (k % 2 == 0)
            {
                whoseTurn = "X";
            }
            else
            {
                whoseTurn = "Y";
            }
            return whoseTurn;  
        }
        public static string WinCheck(string[] stringss, int k)
        {
            string winner = "";
            if (
                    stringss[0] == "X" && stringss[1] == "X" && stringss[2] == "X" ||
                    stringss[3] == "X" && stringss[4] == "X" && stringss[5] == "X" ||
                    stringss[6] == "X" && stringss[7] == "X" && stringss[8] == "X" ||
                    stringss[0] == "X" && stringss[3] == "X" && stringss[6] == "X" ||
                    stringss[1] == "X" && stringss[4] == "X" && stringss[7] == "X" ||
                    stringss[2] == "X" && stringss[5] == "X" && stringss[8] == "X" ||
                    stringss[0] == "X" && stringss[4] == "X" && stringss[8] == "X" ||
                    stringss[6] == "X" && stringss[4] == "X" && stringss[2] == "X")
            {
                winner = "Win Player 1: ";
            }
            else if (
                stringss[0] == "Y" && stringss[1] == "Y" && stringss[2] == "Y" ||
                stringss[3] == "Y" && stringss[4] == "Y" && stringss[5] == "Y" ||
                stringss[6] == "Y" && stringss[7] == "Y" && stringss[8] == "Y" ||
                stringss[0] == "Y" && stringss[3] == "Y" && stringss[6] == "Y" ||
                stringss[1] == "Y" && stringss[4] == "Y" && stringss[7] == "Y" ||
                stringss[2] == "Y" && stringss[5] == "Y" && stringss[8] == "Y" ||
                stringss[0] == "Y" && stringss[4] == "Y" && stringss[8] == "Y" ||
                stringss[6] == "Y" && stringss[4] == "Y" && stringss[2] == "Y")
            {
                winner = "Win Player 2: ";
            }
            if (k == 9)
            {
                winner = "Draw";
            }
            return winner;
        }
        public static void Print(string[] stringss)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write($" {stringss[i]} ");
            }
            Console.WriteLine();
        }
    }
}