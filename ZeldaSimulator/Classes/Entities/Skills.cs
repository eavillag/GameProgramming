using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaSimulator.Classes.Entities
{
    class Skills
    {
        int skl_min_damage;
        int skl_max_damage;
        int skl_min__base_damage;
        int skl_max__base_damage;
        int skl_min_defense;
        int skl_min_base_defense;

        public int Skl_min_damage{
            get{
                return skl_min_damage;
            }

            set{
                skl_min_damage = value;
            }
        }

        public int Skl_max_damage{
            get{
                return skl_max_damage;
            }

            set{
                skl_max_damage = value;
            }
        }

        public int Skl_min__base_damage{
            get{
                return skl_min__base_damage;
            }

            set{
                skl_min__base_damage = value;
            }
        }

        public int Skl_max__base_damage{
            get{
                return skl_max__base_damage;
            }

            set{
                skl_max__base_damage = value;
            }
        }

        public int Skl_min_defense{
            get{
                return skl_min_defense;
            }

            set{
                skl_min_defense = value;
            }
        }

        public int Skl_min_base_defense{
            get{
                return skl_min_base_defense;
            }

            set{
                skl_min_base_defense = value;
            }
        }
    }
}
