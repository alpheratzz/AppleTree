using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppleTreeTest
{
    class Tree
    {
        private uint appnum;
        public uint AppleNum
        {
            get { return appnum; }
        }

        public Tree(uint n)
        {
            appnum = n;
        }

        public Tree()
        {
            appnum = 0;
        }

        public void Grow()
        {
            Random rand = new Random();
            appnum += (uint)rand.Next() % 100;
        }
    }
}
