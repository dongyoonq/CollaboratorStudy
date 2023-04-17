using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    internal class Road : Tile
    {
        public Road(int size) : base(size)
        {
            IsCollisonTile = true;
        }
    }
}
