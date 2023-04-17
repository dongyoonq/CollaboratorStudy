using System;
using System.Collections.Generic;   
using System.Text;

namespace Dongyoon
{
    abstract class Map
    {
        // 맵 클래스를 만드는 곳입니다.
        private int Width;
        private int Height;
        Tile[,] tile;

        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.tile = new Tile[Width, Height];
        }

    }
}
