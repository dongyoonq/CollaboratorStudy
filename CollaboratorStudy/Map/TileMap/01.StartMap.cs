using System;
using System.Collections.Generic;
using System.Text;

namespace Dongyoon
{
    class StartMap : Map
    {
        public StartMap(int width, int height) : base(width, height)
        {

        }

        public override Map CreateMap(int width, int height)
        {
            return new StartMap(width, height);
        }
    }
}
