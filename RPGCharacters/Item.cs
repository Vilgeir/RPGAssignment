using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public abstract class Item
    {
        //Shared attributes for all items
        public string ItemName { get; set; }
        public int LevelToEquip { get; set; } = 1;

        public Character Character { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

    }
}
