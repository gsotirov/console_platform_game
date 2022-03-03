using System;
namespace ConsoleGame.core
{
    public class Player : GameObject
    {
        ConsoleTexture texture;

        public Player()
        {
            texture = new ConsoleTexture(new string[,] {
                { " ", "@", " " },
                { "@", "@", "@" },
                { "@", "@", "@" },
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

                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        transform.position.x++;
                        break;
                    case ConsoleKey.LeftArrow:
                        transform.position.x--;
                        break;
                    case ConsoleKey.UpArrow:
                        transform.position.y--;
                        break;
                    case ConsoleKey.DownArrow:
                        transform.position.y++;
                        break;
                }
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
