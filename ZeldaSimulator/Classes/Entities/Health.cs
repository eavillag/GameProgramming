using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaSimulator.Classes.Entities
{
    class Health
    {
        private int hlth_max;
        private int hlth_initial;
        private int hlth_current;
        private int hlth_critical;

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
