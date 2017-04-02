using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaSimulator.Classes.Entities;
using ZeldaSimulator.Classes.Items;
using ZeldaSimulator.Classes.Gaming;
using ZeldaSimulator.Classes;
namespace ZeldaSimulator.Controllers
{
    class ControllerGame
    {
        private static List<Monster> controller_game_monsters;    
        private static List<Item> controller_game_items;          
        private static List<Map> controller_game_maps;            
        private static List<Avatar> controller_game_avatars;      
        private static List<Session> controller_game_sessions;
        private static int controller_session_count;
        private static Archive controller_Game_Archive;

        internal static List<Monster> Controller_game_monsters
        {
            get
            {
                return controller_game_monsters;
            }

            set
            {
                controller_game_monsters = value;
            }
        }

        internal static List<Item> Controller_game_items
        {
            get
            {
                return controller_game_items;
            }

            set
            {
                controller_game_items = value;
            }
        }

        internal static List<Map> Controller_game_maps
        {
            get
            {
                return controller_game_maps;
            }

            set
            {
                controller_game_maps = value;
            }
        }

        internal static List<Avatar> Controller_game_avatars
        {
            get
            {
                return controller_game_avatars;
            }

            set
            {
                controller_game_avatars = value;
            }
        }

        internal static List<Session> Controller_game_sessions
        {
            get
            {
                return controller_game_sessions;
            }

            set
            {
                controller_game_sessions = value;
            }
        }

        public static int Controller_session_count
        {
            get
            {
                return controller_session_count;
            }

            set
            {
                controller_session_count = value;
            }
        }

        public ControllerGame() {
            Controller_game_avatars = new List<Avatar>();
            Controller_game_monsters = new List<Monster>();
            Controller_game_items = new List<Item>();
            Controller_game_maps = new List<Map>();
            Controller_game_sessions = new List<Session>();
            //load game session count from archives
        }

        public static void controller_Game_Load_Monsters() {
        }
        public static void controller_Game_Load_Items() {
        }
        public static void controller_Game_Load_Maps() {
        }
        public static void controller_Game_Load_Avatars() {
        }
        public static void controller_Game_Load_count() {
        }
        public static void controller_Game_Load_Sesssions() {
        }
        public static void controller_Game_pick_session() {
        }
        public static void controller_Game_delete_session() {
        }
        public static void controller_Game_save_session() {
        }
        public static void controller_Game_restart() {
        }
    }
}
