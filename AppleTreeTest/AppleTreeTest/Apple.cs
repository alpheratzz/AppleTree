using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppleTreeTest
{
    class Apple
    {
        private uint seed_count;

        public Apple()
        {
            Random r = new Random();
            seed_count = (uint)r.Next(10);
        }
    }
}
