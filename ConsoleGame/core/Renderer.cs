using System;
using System.Collections.Generic;

namespace ConsoleGame.core
{
    public class Renderer
    {
        List<GameObject> gameObjects = new List<GameObject>();

        public void RegisterGameObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public void UnregisterGameObject(GameObject gameObject)
        {
            gameObjects.Remove(gameObject);
        }

        public void Render(TimeSpan time)
        {
            //Reset();

            Console.Clear();

            foreach(GameObject gameObject in gameObjects)
            {
                gameObject.OnUpdate(time);
                gameObject.Render();
            }
        }

        void Reset()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                for (int j = 0; j < Console.WindowHeight; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
            }
        }
    }
}