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
        public Item Item { get; set; }
        public Weapons Weapon { get; set; }
        public Armor Armor { get; set; }

        

        // Base primary attributtes
        public Attribute Attribute { get; set; }

        public void WeaponCompatibility()
        {
            if (GetType() == typeof(Mage))
            {
                if ((Weapon.WeaponType != Weapons.WeaponTypes.Staff) && (Weapon.WeaponType != Weapons.WeaponTypes.Wand))
                    throw new Exception("Invalid weapon");
            }
        }

        public void WeaponLevelCheck()
        {
            if (Level < Weapon.LevelToEquip)
                throw new Exception("Weapon level too high");
        }

        public void ArmorLevelCheck()
        {
            if (Level < Armor.LevelToEquip)
                throw new Exception("Weapon level too high");
        }

        public void LevelUp()
        {
 {}            if (GetType() == typeof(Mage))
            {
                Attribute.Strength += 1;
                Attribute.Dexterity += 1;
                Attribute.Intelligence += 5;
            }
        }        

        public double CalculateTotalDamage()
        {
            double totalArmor = Armor.Attribute.Strength + Armor.Attribute.Dexterity + Armor.Attribute.Intelligence;
            double totalBase = Attribute.Strength + Attribute.Dexterity + Attribute.Intelligence;
            double totalAttributes = totalArmor + totalBase;
            double totalDamage = Weapon.WeaponAttributes.AttackSpeed * totalAttributes;

            return totalDamage;
        }

        public void CharacterChecks()
        {
            WeaponCompatibility();
            WeaponLevelCheck();
            ArmorLevelCheck();
        }
        public void ShowStats()
        {
            Console.WriteLine($"Strength: {Attribute.Strength} Dexterity: {Attribute.Dexterity} Intelligence: {Attribute.Intelligence}");
            Console.WriteLine($"The total damage of {Name} is {CalculateTotalDamage()}");
        }


    }
}
