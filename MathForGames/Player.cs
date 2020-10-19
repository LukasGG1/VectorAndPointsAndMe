using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace MathForGames
{
    class Player : Actor
    {

        public Player(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x,y, icon, color)
        {
            
        }

        public Player(float x, float y, Color rayColor, char icon = ' ',  ConsoleColor color = ConsoleColor.White)
            : base(x,y,rayColor,icon,color)
        {

        }

       public override void Update()
        
        {
            int xVelocity = -Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_A))
                + Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_D));

            int  yVelocity = -Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_W))
                + Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_S));


            Velocity = new Vector2(xVelocity, yVelocity);

            if(Velocity.GetManitude() != 0)
            {
                Velocity.X /= Velocity.GetManitude();
                Velocity.Y /= Velocity.GetManitude();
            }
            

            //Input for Movement

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
                case ConsoleKey.Spacebar:
                    {
                        Game.SetCurrentScene(1);
                        break;
                    }
                default:
                    {
                        _veclocity.X = 0;
                        _veclocity.Y = 0;
                        break;
                    }
            }

            //Applies force to position
            _position += _veclocity * 2;
            //_position.Y += _veclocity.Y;


            //make sure position stay within bounds
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
        //public static Player operator +(Player 1hs, int rhs)
        // {
        //     if(Ihs.Position.X == rhs.Position.X && 1hs.Position.Y == rhs.Position.X)                     float newX = 1hs.position.X + rhs;
        //     {                                                                                     float newY = 1hs.Position.Y + rhs;
        //          return true;                                                                     return new Player(newX, newY);
        //     }
        //      return false;
    
    }        
}
