using System;
using System.Threading;
using System.Threading.Tasks;
namespace h_w22
{
    class Program
    {
        class Snake
        {
            static int snakeX;
            static int snakeY;

            static int[] tailX;
            static int[] tailY;
            static int tail_n;
            static int tail_nMax;

            static int fruitX;
            static int fruitY;

            static char Key;

            static int Score;

            static bool gameOver;

            const int length = 60;
            const int heigh = 30;

            static void Drow()
            {

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for (int i = 0; i < length; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 0; i < heigh; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (j == 0 || j == length - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("|");
                            Console.ResetColor();
                        }
                        if (i == snakeY && j == snakeX)
                        {
                            Console.Write('0');
                        }
                        else if (i == fruitY && j == fruitX)
                        {
                            Console.Write('@');
                        }
                        else
                        {
                            bool isPrint = true;

                            for (int n = 0; n <= tail_n; n++)
                            {
                                if (tailX[n] == j && tailY[n] == i)
                                {
                                    Console.Write('>');
                                    isPrint = false;
                                }
                            }

                            if (isPrint)
                            {
                                Console.Write(' ');
                            }

                        }

                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                for (int i = 0; i < length; i++)
                {
                    Console.Write("-");
                }
                Console.ResetColor();
                Console.WriteLine($"\nScore: {Score} ");
                Thread.Sleep(10);
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
