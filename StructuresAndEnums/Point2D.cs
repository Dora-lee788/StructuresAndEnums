using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnums
{
        public struct Point2D
        {
            public int X;
            public int Y;
            public Quadrant CurrentQuadrant;

            public Quadrant GetQuadrant()
            {
                if (X > 0 && Y > 0)
                    CurrentQuadrant = Quadrant.First;
                else if (X < 0 && Y > 0)
                    CurrentQuadrant = Quadrant.Second;
                else if (X < 0 && Y < 0)
                    CurrentQuadrant = Quadrant.Third;
                else
                    CurrentQuadrant = Quadrant.Fourth;

                return CurrentQuadrant;
            }

            public override string ToString()
            {
                return $"({X}, {Y}), четверть: {GetQuadrant()}";
            }
        }
    
}
