using System;
using System.Collections.Generic;   
using System.Text;

namespace Dongyoon
{
    class Map
    {
        // 맵 클래스를 만드는 곳입니다.
        private int Width;
        private int Height;
        private Tile[,] tile;

        protected Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
