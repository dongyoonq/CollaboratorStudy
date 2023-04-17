using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    internal class Block : Tile
    {
        public Block(int size) : base(size)
        {
            IsCollisonTile = false;
        }
    }
}
