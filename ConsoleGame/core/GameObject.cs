using System;

namespace ConsoleGame.core
{
    public interface IGameObject
    {
        void OnCreated();
        void OnUpdate(TimeSpan time);
        void OnDestroyed();
        void Render();
    }

    public abstract class GameObject : IGameObject
    {
        public Transform transform = new Transform();

        public abstract void OnCreated();
        public abstract void OnUpdate(TimeSpan time);
        public abstract void OnDestroyed();
        public abstract void Render();
    }
}
