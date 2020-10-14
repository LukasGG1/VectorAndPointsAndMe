using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathForGames
{
    class Actor
    {
        private char _icon = 'E';
        protected Vector2 _position;
        protected Vector2 _veclocity;
        private ConsoleColor _color;
        //private int x = 0;
        //private int y = 0;
        

        public Actor()
        {
            _position = new Vector2();
            _veclocity = new Vector2();
        }

        public Actor(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
        {
            _icon = icon;
            _position = new Vector2(x, y);
            _veclocity = new Vector2();
            _color = color;
        }

        public void Start()
        {

        }



        public virtual void Update() //<    (int num1)
        {

            _position.X += _veclocity.X;
            _position.Y += _veclocity.Y;
            _position.X = Math.Clamp(_position.X, 0, Console.WindowWidth - 1);
            _position.Y = Math.Clamp(_position.Y, 0, Console.WindowHeight - 1);

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

        public virtual void Draw()
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition((int)_position.X,(int) _position.Y);
            Console.Write(_icon);
            Console.ForegroundColor = Game.DefaultColor;
        }

        public virtual void End()
        {

        }


    }
}
//I'm not seeing "a"