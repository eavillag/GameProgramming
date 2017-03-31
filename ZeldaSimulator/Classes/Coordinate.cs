using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaSimulator.Classes
{
    class Coordinate
    {
        private int coord_x;
        private int coord_y;

        public int Coord_x{
            get{
                return coord_x;
            }

            set{
                coord_x = value;
            }
        }

        public int Coord_y{
            get{
                return coord_y;
            }

            set{
                coord_y = value;
            }
        }
    }
}
