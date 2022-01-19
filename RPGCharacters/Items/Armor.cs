using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public class Armor : Item
    {
        public enum ArmorTypes
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }
        public Attribute Attribute { get; set; }

        public ArmorTypes ArmorType { get; set; }
    }

}
