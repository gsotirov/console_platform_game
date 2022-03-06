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
            Player player = GameObjectFactory.Instance.Instantiate<Player>();

            player.OnShoot += OnPlayerShoot;
        }

        void OnPlayerShoot(Transform startPos, Position direction)
        {
            GameObjectFactory.Instance.Instantiate<Rocket>();
        }
    }
}
