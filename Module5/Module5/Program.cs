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
        public enum Direction { LEFT, RIGHT, UP, DOWN };
        Direction dir;
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
                    dir = Direction.UP;
                    break;
                case 'a':
                    dir = Direction.LEFT;
                    break;
                case 's':
                    dir = Direction.DOWN;
                    break;
                case 'd':
                    dir = Direction.RIGHT;
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
                case Direction.UP:
                    heroY--;
                    break;
                case Direction.LEFT:
                    heroX--;
                    break;
                case Direction.DOWN:
                    heroY++;
                    break;
                case Direction.RIGHT:
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
        static void Main()
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