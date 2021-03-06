﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Scene
    {
        private Actor[] actorS;
        public bool Started{ get; private set; }
        public Scene()
        {
            actorS = new Actor[0];
        }

        //public Scene(Actor[] actor)
        //{
          //  actor = actor
       // }

        public void AddActor(Actor actor)
        {
            //Create a new array with a size one greater than our old array.
            Actor[] appendedArray = new Actor[actorS.Length + 1];
            //Copy value from the old array to the new array.
            for(int i = 0; i < actorS.Length; i++) //or --) //or (int i = 10
            {
                    appendedArray[i] = actorS[i];


            }
            //set the last value in the new array to be the actor we want to add.
            appendedArray[actorS.Length] = actor;
            //Set old array to hold values of the new array
            actorS = appendedArray;
        }

        public bool RemoveActor(int index)
        {
            if(index >= 0 && index >= actorS.Length)
            {
                return false;
            }

            bool actorRemoved = false;


            //Create a new array with a size one less like as your password. than our old array <- Please, Don't type and enter tfc on console command.
            Actor[] tempArray = new Actor[actorS.Length - 1];   //<-- He is trying T-Pose for intimading and domianice....
            //Create variable to access tempArray index
            int jinkle = 0;
            //Copy values from the old array to the new array
            for(int i = 0; i <actorS.Length; i++)
            {
                //If the current index is not the index that needs to be removed
                //Add the value into the old array and increment jinkle
                if(i != index)
                {
                    tempArray[i] = actorS[i];
                    jinkle++;
                }
                else
                {
                    actorRemoved = true;
                    if(actorS[i].Started)
                    {
                        actorS[i].End();
                    }
                }
                //else if(i == index)
                //{
                  //  continue;
                //}
                //else
                //{
                  //  tempArray[i - 1] = actorS[i];
                //}
                //tempArray[i] = actorS[i]; //   Hell 2 U!
            }
            //Set the old array to be the tempArray
            actorS = tempArray;
            
            return actorRemoved;
        }

        public bool RemoveActor(Actor actor)
        {
            //Check to see if the actor was null
            if (actor == null)
            {
                return false;
            }

            bool actorRemoved = false;

            Actor[] tempArray = new Actor[actorS.Length - 1];

            int j = 0;
            for(int i = 0; i < actorS.Length; i++)
            {
                if (actor != actorS[i])
                {
                    tempArray = actorS;
                    j++;
                }
                else
                {
                    actorRemoved = true;
                    if(actor.Started)
                    {
                        actor.End();
                    }
                }
            }
            //Set the old array to the new array
            actorS = tempArray;
            //Return whether or not the removal was successful
            return actorRemoved;
        }

        public virtual void Start(float deltaTime)
        {
            for (int i = 0; i < actorS.Length; i++)
            {
                if (!actorS[i].Started)
                {
                    actorS[i].Start();
                }
                actorS[i].Update(deltaTime);
            }
            Started = true;
        }
        public virtual void Update(float deltaTime)
        {
            for (int i = 0; i < actorS.Length; i++)
            {
               if(!actorS[i].Started)
                {
                    actorS[i].Start();
                }
                actorS[i].Update(deltaTime);
            }
            
        }
        public void Draw()
        {
            for (int i = 0; i < actorS.Length; i++)
            {
                actorS[i].Draw();
            }
        }
        public virtual void End()
        {

            for (int i = 0; i < actorS.Length; i++)
            {
                if(actorS[i].Started)
                {
                    actorS[i].End();
                }
            }
            Started = false;
        }
    }
}
