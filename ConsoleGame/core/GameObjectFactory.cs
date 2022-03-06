using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.core
{
    public class GameObjectFactory
    {
        private static readonly GameObjectFactory instance = new GameObjectFactory();

        List<GameObject> gameObjects = new List<GameObject>();
        
        static GameObjectFactory()
        {
        }

        private GameObjectFactory()
        {
        }

        public List<GameObject> GameObjects
        {
            get { return gameObjects; } 
        }

        public void RegisterGameObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public void UnregisterGameObject(GameObject gameObject)
        {
            gameObjects.Remove(gameObject);
        }

        public static GameObjectFactory Instance
        {
            get { return instance; }
        }

        public T Instantiate<T>() where T : GameObject
        {
            T obj = Activator.CreateInstance<T>();

            obj.OnCreated();

            RegisterGameObject(obj);

            return obj;
        }
    }
}
