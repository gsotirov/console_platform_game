using System;

using ConsoleGame.core;

namespace ConsoleGame
{
    internal class Rocket : GameObject
    {
        private char symbol = '@';
        private Position direction = new Position(1, 0, 0);

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
            transform.position.x += direction.x;
            transform.position.y += direction.y;
        }

        public override void Render()
        {
            Console.SetCursorPosition(transform.position.x, transform.position.y);
            Console.Write(symbol);
        }
    }
}
