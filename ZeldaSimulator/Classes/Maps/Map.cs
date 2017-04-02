using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeldaSimulator.Classes.Entities;
using ZeldaSimulator.Classes.Items;
namespace ZeldaSimulator.Classes.Gaming
{
    class Map
    {
        private int map_id;
        private int map_level_id;
        private string map_name;
        private int map_width;
        private int map_height;
        private int map_max_monster;
        private int map_max_items;

        private double map_monster_probability;
        private double map_item_probability;

        private Cell[][] map_cells;
        private Cell[][] map_items;
        private Cell[][] map_monster;
        //might need more layers to draw maps

        private List<Monster> map_monster_list;
        private Monster map_current_monster;
        private List<Item> map_items_list;
        private Item map_current_item;
        
    }
}
