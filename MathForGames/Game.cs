using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using MathLibrary;

namespace MathForGames
{
    class Game
    {
        private static bool gameOver = false;
        private Scene scene;


        public static ConsoleColor DefaultColor { get; set; } = ConsoleColor.White;
        
        //Static function used to set game over without an instance of game.
        public static void SetGameOver(bool value)
        {
            gameOver = value;
        }



        //Return whether or not the specified ConsoleKey is pressed.
        public static  ConsoleKey GetNextKey()
        {
            //If the imposer hasn't pressed a key return
            if (Console.KeyAvailable)
            {
                                   //ReadKey(true).Key == key)
                
                    return 0;
                
             
            }
            return Console.ReadKey(true).Key;
            //return Console.ReadKey(true).Key

        }

        //Called when the game begins. Use this for initialization.
        public void Start()
        {
            Console.CursorVisible = false;
            scene = new Scene();
            Actor actorS = new Actor(0,0, 'E',ConsoleColor.Green);
            Player player = new Player(0, 1, 'D', ConsoleColor.Red);
            scene.AddActor(actorS);
            scene.AddActor(player);
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
