using System;

namespace ConsoleGame.core
{
    public class ConsoleTexture
    {
        public string[,] textureMatrix = new string[3, 3];

        public ConsoleTexture(string[,] textureMatrix)
        {
            this.textureMatrix = textureMatrix;
        }

        public void Render(Position startPosition)
        {
            for (int row = 0; row < textureMatrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(startPosition.x, startPosition.y + row);

                for (int col = 0; col < textureMatrix.GetLength(1); col++)
                {
                    Console.Write(textureMatrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
