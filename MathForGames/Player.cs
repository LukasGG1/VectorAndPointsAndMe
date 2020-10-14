﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Player : Actor
    {

        public Player(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x,y, icon, color)
        {

        }

       public override void Update()
        
        {


            ConsoleKey keyPressed = Game.GetNextKey();

            switch (keyPressed)
            {
                case ConsoleKey.A:
                    {
                        _veclocity.X = -1;
                        break;
                    }

                case ConsoleKey.D:
                    {
                        _veclocity.X = 1;
                        break;
                    }

                case ConsoleKey.W:
                    {
                        _veclocity.Y = -1;
                        break;
                    }

                case ConsoleKey.S:
                    {
                        _veclocity.Y = 1;
                        break;
                    }
                default:
                    {
                        _veclocity.X = 0;
                        _veclocity.Y = 0;
                        break;
                    }
            }
            _position.X = Math.Clamp(_position.X, 0, Console.WindowWidth);
            _position.Y = Math.Clamp(_position.Y, 0, Console.WindowHeight);
            //Update()
            //ConsoleKey keyPressed = Game.GetNextKey();

            //switch(keyPressed)
            // {              
            //  case ConsoleKey.A:
            //    x--;
            //  break;
            // case ConsoleKey.D:
            //    x++;
            // break;
            // case ConsoleKey.W:
            //    y++;
            // break;// case ConsoleKey.S:
            //    y--;
            // break;

            // }
            //
            //if(x <= 0)
            //x++;
            //if(x > Console.WindowWidth)
            //x--;
            //if(y <= 0)
            //y++
            //if(y > Console.WindowHeight)
            //y--;
            //}
        }
    }
}