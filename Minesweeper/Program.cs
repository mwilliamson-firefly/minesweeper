using System;

namespace Minesweeper
{
    internal class Program
    {
        private const int Height = 10;
        private const int Width = 10;

        internal static void Main(string[] args)
        {
            var minefield = new Minefield(Width, Height);
            Console.Write(MinefieldRenderer.RenderMinefield(minefield));
            //format A2
            var input = Console.ReadLine();
            var coordinates = UserInputReader.ReadCoordinates(input);
            var newMinefield = minefield.Explore(coordinates);
            Console.Write(MinefieldRenderer.RenderMinefield(newMinefield));
            Console.ReadLine();
        }
    }
}
