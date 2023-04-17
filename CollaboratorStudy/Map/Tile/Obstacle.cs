using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    internal class Obstacle : Tile
    {
        public Obstacle(int size) : base(size)
        {
            IsCollisonTile = false;
        }
    }
}
