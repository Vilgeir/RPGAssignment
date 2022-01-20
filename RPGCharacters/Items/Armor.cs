using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public class Armor : Item
    {
        //A list of possible armor types
        public enum ArmorTypes
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }

        //Reference to Attribute class since armor uses same attributes as characters
        public Attribute Attribute { get; set; }

        public ArmorTypes ArmorType { get; set; }
    }

}
