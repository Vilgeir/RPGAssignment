using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    
    public class Weapon : Item
    {
        //A list of all possible weapon types
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

        public bool GetItemType()
        {
            if(GetType() == typeof(Weapon)){
                return true;
            } else { 
            }   return false;
                
        }
    }
}
