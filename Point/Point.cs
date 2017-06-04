using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        public int _coordinateX { get; set; }
        private int _coordinateY { get; set; }

        public Point(int coordinateX, int coordinateY)
        {
            _coordinateX = coordinateX;
            _coordinateY = coordinateY;
        }

        public void Move(int moveCoordinateX, int moveCoordinateY)
        {
            _coordinateX = _coordinateX + moveCoordinateX;
            _coordinateY = _coordinateY + moveCoordinateY;
        }

        public void Show()
        {
            Console.WriteLine("{0}Coordinates:{0}X coordinate: {1}{0}Y coordinate: {2}", Environment.NewLine, _coordinateX, _coordinateY);
        }

    }
}
