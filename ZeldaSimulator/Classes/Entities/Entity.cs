using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaSimulator.Interfaces;

namespace ZeldaSimulator.Classes.Entities
{
    abstract class Entity : InterfaceEntity
    {
        private int ent_id;
        private string ent_name;
        private string ent_usr_name;
        private Coordinate ent_coord;
        private Health ent_health;
        private Skills ent_skills;
        private Level ent_level;
        private Sack ent_sack;

        //Visual representation attribute

        /*------*****>>>>>>>>>>>>> PROPERTIES <<<<<<<<<<<<<<<*********--------*/
        public int Ent_id{
            get{
                return ent_id;
            }

            set{
                ent_id = value;
            }
        }
        public string Ent_name{
            get{
                return ent_name;
            }

            set{
                ent_name = value;
            }
        }
        public string Ent_usr_name{
            get{
                return ent_usr_name;
            }

            set{
                ent_usr_name = value;
            }
        }
        public Coordinate Ent_coord{
            get{
                return ent_coord;
            }

            set{
                ent_coord = value;
            }
        }
        public Health Ent_health{
            get{
                return ent_health;
            }

            set{
                ent_health = value;
            }
        }
        public Skills Ent_skills{
            get{
                return ent_skills;
            }

            set{
                ent_skills = value;
            }
        }
        public Level Ent_level{
            get{
                return ent_level;
            }

            set{
                ent_level = value;
            }
        }
        public Sack Ent_sack{
            get{
                return ent_sack;
            }

            set{
                ent_sack = value;
            }
        }

        


        /*--------*****>>>>>>>>>>>>Abstract METHODS <<<<<<<<<*********--------*/
        public abstract void ent_Move();

        public abstract void ent_Attack();

        public abstract void ent_Update_Avatar_Info();
        public abstract void ent_Update_Health();
        public abstract void ent_Update_Skills();
        public abstract void ent_Update_Level();
        public abstract void ent_Update_Sack();
        public abstract void ent_Update_Coordinate();


    }
}
