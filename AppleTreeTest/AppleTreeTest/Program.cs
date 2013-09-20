using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppleTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitFlag = true;
            ConsoleKeyInfo key;
            Tree tree = new Tree();
            while (exitFlag)
            {
                Console.Clear();
                Console.WriteLine("[1] Bloom");
                Console.WriteLine("[2] Grow");
                Console.WriteLine("[3] Shake");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("There are {0} apples on the tree now", tree.AppleNum);
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        tree.Bloom();
                        break;
                    case '2':
                        tree.Grow();
                        break;
                    case '3':
                        tree.Shake();
                        break;
                    case '0':
                        exitFlag = false;
                        break;
                    default: 
                        break;
                }
            }
        }
    }
}
