using ConsoleGame.core;

namespace ConsoleGame
{
    class Program
    {
        static void Main()
        {
            GameSettings settings = new GameSettings();
            Renderer renderer = new Renderer();

            Game game = new Game(settings, renderer);
            GameLoop loop = new GameLoop(game, renderer);

            loop.Start();
        }
    }

    class SceneData
    {
        public static int[,] Grid { get; set; }
    }

    public class Size
    {
        public int width;
        public int height;

        public Size(int gameWidth, int gameHeight)
        {
            width = gameWidth;
            height = gameHeight;
        }
    }

    public class GameSettings
    {
        public Size size;

        public GameSettings()
        {
            size = new Size(100, 0);
        }
    }
}
