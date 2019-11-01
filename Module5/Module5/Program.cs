﻿using System;
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
            
            for(int i = 0; i < width + 1; i++)
                Console.Write("#");

            Console.WriteLine();    

            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(j == 0 || j == width - 1)
                        Console.Write("#");
                    if (i == heroY && j == heroX)
                        Console.Write("H");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < width + 1; i++)
                Console.Write("#");


        }
        public void Input()
        {
            if (Console.KeyAvailable)
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
            }
        }
    }
}
