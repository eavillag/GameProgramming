using System;
using System.Collections.Generic;

using ZeldaSimulator.Classes.Items;

namespace ZeldaSimulator.Classes
{
    class Sack
    {
        List<Item> sack_items;
        Item sack_current_item;
        int sack_qty_weapon_items;
        int sack_qty_armor_items;
        int sack_qty_potion_items;
    }
}
