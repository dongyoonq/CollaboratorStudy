using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    internal class Block : Tile
    {
        protected override void SetCollison()
        {
            IsCollisonTile = false;
        }
    }
}
