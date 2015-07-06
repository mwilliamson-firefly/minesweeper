namespace Minesweeper
{
    public class Minefield
    {
        private readonly int _width;
        private readonly int _height;

        public Minefield(int width, int height)
        {
            _width = width;
            _height = height;
        }

        internal int Width
        {
            get { return _width; }
        }

        internal int Height
        {
            get { return _height; }
        }

        public Minefield Explore(Coordinates coordinates)
        {
            return this;
        }
    }
}
