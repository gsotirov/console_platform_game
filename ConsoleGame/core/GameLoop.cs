using System;
using System.Threading;

namespace ConsoleGame.core
{
    public class GameLoop
    {
        public Game game;
        public Renderer renderer;

        bool LoopRunning { get; set; }

        DateTime _prevTime = DateTime.Now;

        int framerate = 60;

        public GameLoop(Game game, Renderer renderer)
        {
            this.game = game;
            this.renderer = renderer;
        }

        public void Start()
        {
            game.Init();

            LoopRunning = true;

            StartGameLoop();
        }

        public void Stop()
        {
            LoopRunning = false;
        }

        void StartGameLoop()
        {
            while(LoopRunning)
            {
                TimeSpan time = DateTime.Now - _prevTime;

                OnLoopUpdate(time);

                Thread.Sleep(1000 / framerate);

                _prevTime = _prevTime + time;
            }
        }

        void OnLoopUpdate(TimeSpan time)
        {
            renderer.Render(time);
        }
    }
}