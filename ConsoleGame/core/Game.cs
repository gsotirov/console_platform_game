using System;

namespace ConsoleGame.core
{
    public class Game
    {
        public GameSettings settings;
        public Renderer renderer;

        public Game(GameSettings settings, Renderer renderer)
        {
            this.settings = settings;
            this.renderer = renderer;
        }

        public void Init()
        {
            // Add player
            AddPlayer();
            // Add enemies
            // Add platform
            // Add obsticles & stuff
        }

        private void AddPlayer()
        {
            GameObject player = CreateGameObject<Player>();
        }

        GameObject CreateGameObject<T>() where T : GameObject
        {
            GameObject obj = Activator.CreateInstance<T>();

            obj.OnCreated();

            renderer.RegisterGameObject(obj);

            return obj;
        }
    }
}
