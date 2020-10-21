using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace MathForGames
{
    class Player : Actor
    {
        private float _speed = 1;

        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        public Player(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x,y, icon, color)
        {
            
        }

        public Player(float x, float y, Color rayColor, char icon = ' ',  ConsoleColor color = ConsoleColor.White)
            : base(x,y,rayColor,icon,color)
        {

        }

       public override void Update(float deltaTime)
        
        {
            int xVelocity = -Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_A))
                + Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_D));

            int  yVelocity = -Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_W))
                + Convert.ToInt32(Game.GetKeyDown((int)KeyboardKey.KEY_S));


            Velocity = new Vector2(xVelocity, yVelocity);
            Velocity = Velocity.Normalizaed * Speed;

            if(Velocity.GetManitude() != 0)
            {
                Velocity.X /= Velocity.GetManitude();
                Velocity.Y /= Velocity.GetManitude();
            }
            

            //Input for Movement

           

            //Applies force to position
            _position += _veclocity * 2;
            
            //_position.Y += _veclocity.Y;


            //make sure position stay within bounds
            _position.X = Math.Clamp(_position.X, 0, Console.WindowWidth - 1);
            _position.Y = Math.Clamp(_position.Y, 0, Console.WindowHeight - 1);
            
            base.Update(deltaTime);
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
