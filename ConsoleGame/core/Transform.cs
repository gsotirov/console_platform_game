namespace ConsoleGame.core
{
    public class Position
    {
        public int x = 0;
        public int y = 0;
        public int z = 0;

        public Position(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public class Scale
    {
        public int x = 1;
        public int y = 1;

        public Scale(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Transform
    {
        public Position position;
        public Scale scale;

        public Transform()
        {
            position = new Position(0, 0, 0);
            scale = new Scale(1, 1);
        }
    }
}
