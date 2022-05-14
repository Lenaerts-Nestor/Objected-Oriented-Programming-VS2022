using System;

namespace Pong_Game
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int leftpunt = 0;
            int rightpunt = 0;
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
            Console.CursorVisible = false;


            //Positie waar de balletje tonen
            int postX = Console.WindowHeight / 2; 
            int postY = Console.WindowWidth / 2;

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            //Volgende positie van de balletje
            int Xvector = Console.WindowHeight/2;
            int Yvector = Console.WindowWidth/2;

            //Borders
            int vX = 7;
            int vY = 2;
            while (true)
            {
                //wait
                Console.SetCursorPosition(Console.WindowWidth/2, 0);
                Console.WriteLine($"{leftpunt} / {rightpunt}");

                //updaten

                if (postX + vX < 0 || postX + vX >= Console.WindowWidth)
                {
                    if (vX>0)
                    {
                        leftpunt++;
                    }
                    else
                    {
                        rightpunt++;
                    }
                    vX = -vX;
                }
                
                if (postY + vY < 0 || postY + vY >= Console.WindowHeight)
                {
                    vY = -vY;
                }
                postX = postX + vX;
                postY = postY + vY;

                //Rendereren
                Console.SetCursorPosition(postX,postY);
                Console.WriteLine("O.*");

                System.Threading.Thread.Sleep(100); //50 miliseconde
                Console.Clear();
            }


        }
    }
}
