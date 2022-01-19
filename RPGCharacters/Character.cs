using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public Item item { get; set; }
        public Weapons Weapon { get; set; }
        public Armor Armor { get; set; }

        // Base primary attributtes
        public Attribute Attribute { get; set; }

        public void WeaponCompatibility()
        {
            if (GetType() == typeof(Mage))
            {
                try
                {
                    Weapon.WeaponType = "AXE";
                    Console.WriteLine(Weapon.WeaponType);
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void LevelUp()
        {
            if (GetType() == typeof(Mage))
            {
                Attribute.Strength += 1;
                Attribute.Dexterity += 1;
                Attribute.Intelligence += 5;
            }
        }

        public void ShowStats()
        {
            Console.WriteLine($"Strength: {Attribute.Strength} Dexterity: {Attribute.Dexterity} Intelligence: {Attribute.Intelligence}");
        }

        public void CalculateTotalDamage()
        {
            double totalArmor = Armor.Attribute.Strength + Armor.Attribute.Dexterity + Armor.Attribute.Intelligence;
            double totalBase = Attribute.Strength + Attribute.Dexterity + Attribute.Intelligence;
            double totalAttributes = totalArmor + totalBase;
            double totalDamage = Weapon.WeaponAttributes.AttackSpeed * totalAttributes;

            Console.WriteLine($"The Caracter has total damage of {totalDamage}");
        }

        // Total primary attributtes
    }
}
