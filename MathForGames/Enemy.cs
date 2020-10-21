using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGames
{
    class Enemy : Actor
    {
        private Actor _target;


        public Actor Target
        {
            get
            {
                return _target;
            }
            set
            {
                _target = value;
            }
        }
        public Enemy(float x, float y, char icon = ' ', ConsoleColor color = ConsoleColor.White)
           : base(x, y, icon, color)
        {

        }

        public Enemy(float x, float y, Color rayColor, char icon = ' ', ConsoleColor color = ConsoleColor.White)
            : base(x, y, rayColor, icon, color)
        {

        }

        public bool CheckTargetInSight()
        {
            if(Target == null)
            {
                return false;
            }

            Vector2 direction = Vector2.Normalize(_position - Target._position);

            return false;

        }
    }
}
