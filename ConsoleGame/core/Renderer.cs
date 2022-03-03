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
            Console.Clear();

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.OnUpdate(time);
                gameObject.Render();
            }
        }
    }
}