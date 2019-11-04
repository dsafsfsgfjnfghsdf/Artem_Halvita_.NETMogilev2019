using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Game
    {
        public bool gameOver;
        public const int width = 10;
        public const int height = 10;
        public const int numberMines = 10 + 1;
        public int heroX, heroY;
        public int princessX, princessY;
        public int health;
        public Tuple<int, int, int>[] mines = new Tuple<int, int, int>[numberMines];
        public enum eDirection { LEFT, RIGHT, UP, DOWN };
        eDirection dir;
        public void Setup()
        {
            gameOver = false;
            dir = 0;
            heroX = 0;
            heroY = 9;
            princessX = 9;
            princessY = 0;
            health = 10;

            Random rand = new Random();

            for (int i = 0; i < numberMines; i++)
            {
                mines[i] = new Tuple<int, int, int>(rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
            }

        }
        public void Draw()
        {
            Console.Clear();

            for (int i = 0; i < width + 2; i++)
                Console.Write("#");

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width + 2; j++)
                {
                    if (j == 0 || j == width)
                        Console.Write("#");
                    if (i == heroY && j == heroX)
                        Console.Write("H");
                    else if (i == princessY && j == princessX)
                        Console.Write("P");
                    else if (i == mines[0].Item2 && j == mines[0].Item1 ||
                        i == mines[1].Item2 && j == mines[1].Item1 ||
                        i == mines[2].Item2 && j == mines[2].Item1 ||
                        i == mines[3].Item2 && j == mines[3].Item1 ||
                        i == mines[4].Item2 && j == mines[4].Item1 ||
                        i == mines[5].Item2 && j == mines[5].Item1 ||
                        i == mines[6].Item2 && j == mines[6].Item1 ||
                        i == mines[7].Item2 && j == mines[7].Item1 ||
                        i == mines[8].Item2 && j == mines[8].Item1 ||
                        i == mines[9].Item2 && j == mines[9].Item1)
                        Console.Write("x");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < width + 2; i++)
                Console.Write("#");

            Console.WriteLine($"\nhealth: {health}");
        }
        public void Input()
        {
            var keyInfo = Console.ReadKey();
            switch (keyInfo.KeyChar)
            {
                case 'w':
                    dir = eDirection.UP;
                    break;
                case 'a':
                    dir = eDirection.LEFT;
                    break;
                case 's':
                    dir = eDirection.DOWN;
                    break;
                case 'd':
                    dir = eDirection.RIGHT;
                    break;
                case 'x':
                    gameOver = true;
                    break;
            }
        }
        public void Logic()
        {
            switch (dir)
            {
                case eDirection.UP:
                    heroY--;
                    break;
                case eDirection.LEFT:
                    heroX--;
                    break;
                case eDirection.DOWN:
                    heroY++;
                    break;
                case eDirection.RIGHT:
                    heroX++;
                    break;
            }

            for (int i = 0; i < numberMines; i++)
            {
                if (heroX == mines[i].Item1 && heroY == mines[i].Item2)
                {
                    health -= mines[i].Item3;
                }
            }

            if (heroX >= width || heroX < 0 ||
                heroY >= height || heroY < 0 ||
                health <= 0)
            {
                gameOver = true;
            }

            if (heroX == princessX && heroY == princessY)
            {
                gameOver = true;
                Console.WriteLine("\bWin!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            string answerUser = "yes";
            while (answerUser == "yes")
            {
                game.Setup();
                while (!game.gameOver)
                {
                    game.Draw();
                    game.Input();
                    game.Logic();
                }

                Console.Write("\bTry again (yes/no)? ");
                answerUser = Console.ReadLine();
            }
        }
    }
}