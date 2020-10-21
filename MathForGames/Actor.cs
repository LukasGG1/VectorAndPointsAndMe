using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;
using Raylib_cs;

namespace MathForGames
{
    class Actor
    {
        private char _icon = 'E';
        protected Vector2 _position;
        protected Vector2 _veclocity;
        protected Vector2 _facing;
        private ConsoleColor _color;
        protected Color _rayColor;
        public bool Started { get; private set; }
        //private int x = 0;
        //private int y = 0;

        public Vector2 Forward
        {
            get
            {
                return _facing;

            }
            set
            {
                _facing = value;
            }
        }

        public Actor(float x)
        {
            _position = new Vector2();
            _veclocity = new Vector2();
        }

        public Actor(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
        {
            _rayColor = Color.WHITE;
            _icon = icon;
            _position = new Vector2(x, y);
            _veclocity = new Vector2();
            _color = color;
            Forward = new Vector2(1, 0);
        }

        public Vector2 Velocity
        {
            get { return _veclocity; }
            set { _veclocity = value; }
        }

        public Actor(float x, float y, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : this(x, y, icon, color)
        {
            _rayColor = rayColor;

        }

        private void UpdateFacing()
        {
            if(_veclocity.Magnitude > 0)
            {
                return;
            }
            _facing = Velocity.Normalizaed;
            //Raylib.DrawLine();
        }

        //public int GetVelocity()
        //{
          //  return _veclocity;
        //}

        //public void SetVelocity(int velocity)
        //{
          //  _veclocity = velocity;
        //}


        public void Start()
        {
            Started = true;
        }



        public virtual void Update(float deltaTime) //<    (int num1)
        {
            //_veclocity.X = 1;
            //_veclocity.Y = 1;
            //float magnitude = _veclocity.GetManitude();
            UpdateFacing();
            _position += _veclocity * deltaTime;                //* 5.23f;
            //magnitude = _veclocity.GetManitude();
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
            Raylib.DrawText(_icon.ToString(), (int)(_position.X * 32), (int)(_position.Y * 32), 32, Color.BLUE);
            Raylib.DrawLine(
                (int)_position.X * 32,
                (int)_position.Y * 32,
                (int)((_position.X + Forward.X) * 32),
                (int)((_position.Y + Forward.Y) * 32),
                Color.WHITE
                );
            Console.ForegroundColor = _color;
            Console.SetCursorPosition((int)_position.X,(int) _position.Y);
            Console.Write(_icon);
            Console.ForegroundColor = Game.DefaultColor;


        }

        public virtual void End()
        {
            Started = false;
        }


    }
}
//I'm not seeing "a"