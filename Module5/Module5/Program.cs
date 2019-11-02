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
        public int heroX, heroY;
        public enum eDirection { STOP = 0, LEFT, RIGHT, UP, DOWN };
        eDirection dir;

        public void Setup()
        {
            gameOver = false;
            dir = eDirection.STOP;
            heroX = width / 2;
            heroY = height / 2; 
        }
        public void Draw()
        {
            Console.Clear();
            
            for(int i = 0; i < width + 2; i++)
                Console.Write("#");

            Console.WriteLine();    

            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width + 2; j++)
                {
                    if(j == 0 || j == width)
                        Console.Write("#");
                    if (i == heroY && j == heroX)
                        Console.Write("H");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < width + 2; i++)
                Console.Write("#");
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

            if (heroX >= width || heroX < 0 ||
                heroY >= height || heroY < 0)
            {
                gameOver = true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Setup();
            while (!game.gameOver)
            {
                game.Draw();
                game.Input();
                game.Logic();
            }
        }
    }
}
/* 
 *                                                                                                      Изменить передвижение героя (по нажатию клавиши)
 *                                                                                                      Редактировать поле до 10х10 клеток
 *                                                                                                      Добавить невозможность выхода за границы
 * Добавить жизней герою
 * Добавить мины с уроном
     */