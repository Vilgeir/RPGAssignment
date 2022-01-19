using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    
    public class Weapons : Item
    {
        public enum WeaponTypes
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }
        public WeaponAttributes WeaponAttributes { get; set; }

        public WeaponTypes WeaponType { get; set; }

    }
}
