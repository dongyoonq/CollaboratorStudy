using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    abstract class Tile
    {
        protected int size; 
        protected bool IsCollisonTile;

        protected Tile(int size)
        {
            this.size = size;
        }
    }
}
