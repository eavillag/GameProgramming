using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaSimulator.Classes.Entities;

namespace ZeldaSimulator.Classes.Gaming
{
    class Session
    {
        private int ses_id;
        private DateTime ses_date;
        private DateTime ses_elapsed_time;
        private Avatar ses_avatar;
        private Monster ses_current_monster;
        private Map ses_current_map;
        private SessionLevel ses_session_level;
        private List<Map> ses_list_maps;       //not necessary?


        public Session(){
            
        }
    }
}
