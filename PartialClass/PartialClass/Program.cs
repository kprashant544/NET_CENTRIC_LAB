﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Program
    {
        public partial class Coords
        {
            private int x;
            private int y;
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public partial class Coords
            {
                public void PrintCoords()
                {
                    Console.WriteLine("Coords:{0},{1}", x, y);
                }

            }
            class TestCoords
            {
                static void Main()
                {
                    Coords myCoords = new Coords(10,15);
                    myCoords.PrintCoords();

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
            }
        }

        
    }
}
