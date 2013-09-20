using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppleTreeTest
{
    class Tree
    {
        private uint appnum;
        private uint blossomnum;
        public uint AppleNum
        {
            get { return appnum; }
        }

        public uint BlossomNum
        {
            get { return blossomnum; }
        }

        public Tree(uint n)
        {
            appnum = n;
            blossomnum = 0;
        }

        public Tree()
        {
            appnum = blossomnum = 0;
        }

        public void Grow()
        {
            if (blossomnum == 0)
            {
                Console.WriteLine("Error: there are no free blossoms to fructify. Press any key to continue...");
                Console.ReadKey(true);
            }
            else
            {
                appnum += blossomnum;
                blossomnum = 0;
            }
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

        public void Bloom()
        {
            Random rand = new Random();
            blossomnum += (uint)rand.Next() % 100;
        }
    }
}
