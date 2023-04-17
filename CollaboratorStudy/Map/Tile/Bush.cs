using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    internal class Bush : Tile
    {
        public Bush(int size) : base(size)
        {
            IsCollisonTile = true;
        }
    }
}
