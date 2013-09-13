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

        public void Shake()
        {
            Random rand = new Random();
            if (appnum == 0)
            {
                Console.WriteLine("Error: there are no apples on the tree. Press any key to continue...");
                Console.ReadKey(true);
            }
            else
                appnum -= (uint)rand.Next() % (appnum + 1);
        }
    }
}
