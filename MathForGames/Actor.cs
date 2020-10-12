using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Actor
    {
        private char icon = 'E';
        private int x = 0;
        public void Start()
        {

        }

        public void Update()
        {
            if(Game.CheckKey(ConsoleKey.D))
            {
                x++;
            }
            else if(Game.CheckKey(ConsoleKey.A))
            {
                x--;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,0);
            Console.Write(icon);
        }

        public void End()
        {

        }


    }
}
//I'm not seeing "a"