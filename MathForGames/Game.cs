using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace MathForGames
{
    class Game
    {
        private static bool gameOver = false;
        private Scene scene;
       
        //Static function used to set game over without an instance of game.
        public static void SetGameOver(bool value)
        {
            gameOver = value;
        }



        //Return whether or not the specified ConsoleKey is pressed.
        public static bool CheckKey(ConsoleKey key)
        {
            //If the imposer hasn't pressed a key return
            if (Console.KeyAvailable)
            {
                if (Console.In.Peek() == (int)key)                    //ReadKey(true).Key == key)
                {
                    return true;
                }
            }

            //return Console.ReadKey(true).Key

            return false;
        }

        //Called when the game begins. Use this for initialization.
        public void Start()
        {
            Console.CursorVisible = false;
            scene = new Scene();
            Actor actorS = new Actor();
            scene.AddActor(actorS);
        }


        //Called every frame.
        public void Update()
        {
            
            scene.Update();
        }

        //Used to display objects and other info on the screen.
        public void Draw()
        {
            Console.Clear();
            scene.Draw();
        }


        //Called when the game ends.
        public void End()
        {

        }


        //Handles all of the main game logic including the main game loop.
        public void Run()
        {
            Start();

            while(!gameOver)
            {
                Update();
                Draw();
                while (Console.KeyAvailable) Console.ReadKey(true);
                //Console.ReadKey(true);
                Thread.Sleep(250);
                //Console.ReadKey(false);
            }

            End();
        }
    }
}
