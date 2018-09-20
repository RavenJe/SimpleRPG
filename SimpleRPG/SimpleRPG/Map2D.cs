using System;

namespace SimpleRPG
{

    class Map2D
    {
        private string _name;
        private readonly int _rows;
        private readonly int _columns;
        private int _lastX;
        private int _lastY;

        private readonly int[,] _map2D;

        public Map2D(int size, string name)
        {
            _name = name;
            _rows = size;
            _columns = size;

            _map2D = new int[size, size];
        }

        public int GetPosition(int x, int y)
        {
            return _map2D[x, y];
        }

        public void SetPlayerPosition(int x, int y)
        {
            if (x > _rows || y > _columns)
            {
                Console.WriteLine("Error: The position doesn't exist.");
            }
            else
            {
                _map2D[_lastX, _lastY] = 0;
                _map2D[x, y] = 1;
                _lastX = x;
                _lastY = y;
            }
        }

        public void Show()
        {
            // Rows
            for (var i = 0; i < _columns; i++)
            {
                Console.Write("[{0}]", _map2D[i, 0]);

                // Columns
                for (var j = 1; j < _rows; j++)
                {
                    Console.Write("[{0}]", _map2D[i, j]);
                }

                Console.WriteLine();

            }
        }
    }
}