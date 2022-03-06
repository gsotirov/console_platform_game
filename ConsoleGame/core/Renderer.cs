using System;

namespace ConsoleGame.core
{
    public class Renderer
    {
        public void Render(TimeSpan time)
        {
            Console.Clear();

            for (int i = 0; i < GameObjectFactory.Instance.GameObjects.Count; i++)
            {
                GameObject gameObject = GameObjectFactory.Instance.GameObjects[i];

                gameObject.OnUpdate(time);
                gameObject.Render();
            }
        }
    }
}