﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using MathLibrary;
using Raylib_cs;

namespace MathForGames
{
    class Game
    {
        private static bool gameOver = false;
        private static Scene[] _scenes;
        private Scene scene;
        private static int _currentSceneIndex;

        public static int CurrentSceneIndex
        {
            get
            {
                return _currentSceneIndex;
            }
        }
        public static ConsoleColor DefaultColor { get; set; } = ConsoleColor.White;
        
        //Static function used to set game over without an instance of game.
        public static void SetGameOver(bool value)
        {
            gameOver = value;
        }

        public static Scene GetScenes(int index)
        {
            return _scenes[index];
        }

        public static Scene GetCurrentScene()
        {
            return _scenes[_currentSceneIndex];
        }

        public static int AddScene(Scene scene)
        {
            //
            Scene[] tempArray = new Scene[_scenes.Length + 1];

            for(int i = 0; i < _scenes.Length; i++)
            {
                tempArray[i] = _scenes[i];
            }

            int index = _scenes.Length;
            tempArray[index] = scene;
            _scenes = tempArray;

            return index;
        }

        public static bool RemoveScene(Scene scene)
        {
            if(scene == null)
            {
                return false;
            }

            bool sceneRemoved = false;

            Scene[] tempArray = new Scene[_scenes.Length - 1];

            int j = 0;

            for (int i = 0; i < _scenes.Length; i++)
            {
                if(tempArray[i] != _scenes[i])
                {
                    tempArray[i] = _scenes[j];
                    j++;
                }

                else
                {
                    sceneRemoved = true;
                }
            }
            if (sceneRemoved)
                _scenes = tempArray;

            return sceneRemoved;
        }

        public static void SetCurrentScene(int index)
        {
            if (index < 0 || index < _scenes.Length)
                return;
            
            if (_scenes[_currentSceneIndex].Started)
                _scenes[_currentSceneIndex].End();

            _currentSceneIndex = index;

        }

        //Return whether or not the specified ConsoleKey is pressed.
        public static int GetNextKey()  //ConsoleKey
        {



            return Raylib.GetKeyPressed();


        }

        public static bool GetKeyDown(int key)
        {
            bool testBool = true;
            int test = Convert.ToInt32(testBool);

            return Raylib.IsKeyDown((KeyboardKey)key);
        }

        public static bool GetKeyPressed(int key)
        {

            return Raylib.IsKeyPressed((KeyboardKey)key);


        }



        //Called when the game begins. Use this for initialization.
        public void Start()
        {
            //Creates a new window for raylib
            Raylib.InitWindow(1024, 760, "Math For Game");
            Raylib.SetTargetFPS(60);

            //Set up console window
            Console.CursorVisible = false;
            Console.Title = "Math For Game";

            //Create a new scene for our actors to exist in
            _scenes = new Scene[0];
            scene = new Scene();
            
            //Creates two actors to add to our scene
            Actor actorS = new Actor(28,20, 'E',ConsoleColor.Green);
            actorS.Velocity.X = -1;
            Enemy enemy = new Enemy(10, 10, Color.GREEN, '■', ConsoleColor.Green);
            Player player = new Player(1, 1, Color.RED, '@', ConsoleColor.Red);
            //player.Velocity.X = 1;
            //player.Velocity.Y = 1;


            scene.AddActor(actorS);
            scene.AddActor(enemy);

            scene.AddActor(player);
            player.Speed = 1;
            //scene2.AddActor(player);

            int startingSceneIndex = 0;

            startingSceneIndex = AddScene(scene);

            AddScene(scene);
            //AddScene(scene2);

            

            SetCurrentScene(startingSceneIndex);


        }




        //Called every frame.
        public void Update(float deltaTime)
        {
            if (_scenes[_currentSceneIndex].Started)
               _scenes[_currentSceneIndex].Start(deltaTime);

            _scenes[_currentSceneIndex].Update(deltaTime);
           scene.Update(deltaTime); 
        }

        //Used to display objects and other info on the screen.
        public void Draw()
        {
           
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            
            Console.Clear();
            _scenes[_currentSceneIndex].Draw();
            scene.Draw();

            Raylib.EndDrawing();
        }


        //Called when the game ends.
        public void End()
        {
          // if(_scenes[_currentSceneIndex].Started)
            //{
                //_scenes[_currentSceneIndex].End();
            //}


        }


        //Handles all of the main game logic including the main game loop.
        public void Run()
        {
            Start();

            while(!gameOver || !Raylib.WindowShouldClose())
            {
                if(GetKeyPressed(32))
                {

                }
                float deltaTime = Raylib.GetFrameTime();
                Update(deltaTime);      //(deltaTime);
                Draw();
                while (Console.KeyAvailable) //Console.ReadKey(true);
                Console.ReadKey(true);
                //Thread.Sleep(100);
                //Console.ReadKey(false);
            }

            End();
        }
    }
}
