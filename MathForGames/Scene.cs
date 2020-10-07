using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Scene
    {
        private Actor[] actorS;

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
            Actor[] appendedArray = new Actor[actorS.Length + 1];
            for(int i = 0; i < actorS.Length; i++)
            {
                appendedArray[i] = actorS[i];
            }
            appendedArray[actorS.Length + 1] = actor;
            actorS = appendedArray;
        }

        public void Start()
        {

        }
        public void Update()
        {

        }
        public void Draw()
        {

        }
        public void End()
        {

        }
    }
}
