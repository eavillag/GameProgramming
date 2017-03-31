using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaSimulator.Classes.Entities
{
    class Health
    {
        int hlth_max;
        int hlth_current;
        int hlth_critical;

        public int Hlth_max{
            get{
                return hlth_max;
            }

            set{
                hlth_max = value;
            }
        }

        public int Hlth_current{
            get{
                return hlth_current;
            }

            set{
                hlth_current = value;
            }
        }

        public int Hlth_critical
        {
            get
            {
                return hlth_critical;
            }

            set
            {
                hlth_critical = value;
            }
        }
    }
}
