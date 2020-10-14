using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Actor
    {
        private char icon = 'E';
        private int x = 0;
        private int y = 0;
        public void Start()
        {

        }

        public void Update() //<    (int num1)
        {
            if(Game.CheckKey(ConsoleKey.D))
            {
                x++;
            }

            else if(Game.CheckKey(ConsoleKey.A))
            {
                x--;
            }

            else if (Game.CheckKey(ConsoleKey.W))
            {
                y++;
            }

            else if (Game.CheckKey(ConsoleKey.S))
            {
                y--;
            }

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
              //Math.Clamp(x, 0, Console.WindowWidth-1);
              //Math.Clamp(y, 0, Console.WindowHeight-1); 
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }

        public void End()
        {

        }


    }
}
//I'm not seeing "a"