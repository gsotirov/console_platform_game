using System;
namespace ConsoleGame.core
{
    public class Player : GameObject
    {
        ConsoleTexture texture;

        public Player()
        {
            texture = new ConsoleTexture(new string[,] {
                { "  ", "@", "  " },
                { " ", "@@@", " " },
                { "@ ", "@", " @" },
            });
        }

        public override void OnCreated()
        {
            return;
        }

        public override void OnDestroyed()
        {
            throw new NotImplementedException();
        }

        public override void OnUpdate(TimeSpan time)
        {
            while(Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    transform.position.x = transform.position.x - 1;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    transform.position.x = transform.position.x + 1;
                }
            }
        }

        public override void Render()
        {
            texture.Render(transform.position);
        }
    }
}
