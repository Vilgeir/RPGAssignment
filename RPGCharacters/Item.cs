using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public abstract class Item
    {

        public enum Slots
        {
            HEAD_ARMOR,
            BODY_ARMOR,
            LEG_ARMOR,
            WEAPON
        }
        public string ItemName { get; set; }
        public int LevelToEquip { get; set; } = 1;

    }
}
