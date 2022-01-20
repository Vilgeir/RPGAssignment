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
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        

        // Base primary attributtes
        public Attribute Attribute { get; set; }

        /// <summary>
        /// Checks if a character can equip weapon
        /// </summary>
        public void WeaponCompatibility()
        {
            //Checks which type of character is selected
            if (GetType() == typeof(Mage))
            {
                //If the right weapon is selected a message will be displayed. Otherwise an exception will be thrown
                if ((Weapon.WeaponType == Weapon.WeaponTypes.Staff) || (Weapon.WeaponType == Weapon.WeaponTypes.Wand))
                {
                    Console.WriteLine("Weapon equipped");
                } else                
                {
                    throw new InvalidWeaponException("Invalid weapon");
                }              
            }
            if (GetType() == typeof(Warrior))
            {
                if ((Weapon.WeaponType == Weapon.WeaponTypes.Axe) || (Weapon.WeaponType == Weapon.WeaponTypes.Hammer) || (Weapon.WeaponType == Weapon.WeaponTypes.Sword))
                {
                    Console.WriteLine("Weapon equipped");
                } else
                {
                    throw new InvalidWeaponException("Invalid weapon");
                }
            }
        }

        /// <summary>
        /// Checks if a character can equip armor
        /// </summary>
        public void ArmorCompatibility()
        {
            if (GetType() == typeof(Mage))
            {
                if (Armor.ArmorType == Armor.ArmorTypes.Cloth)
                {
                    Console.WriteLine("Armor equipped");
                } else
                {
                    throw new InvalidArmorException("Invalid armor");
                }
                    
            }
            if (GetType() == typeof(Warrior))
            {                 
                if ((Armor.ArmorType == Armor.ArmorTypes.Mail) || (Armor.ArmorType == Armor.ArmorTypes.Plate))
                {
                    Console.WriteLine("Armor equipped");
                } else
                {
                    throw new InvalidArmorException("Invalid armor");
                }
                    
            }
        }

        /// <summary>
        /// If the character level is lower than the item level an exception will be thrown
        /// </summary>
        public void WeaponLevelCheck()
        {
            if (Level < Weapon.LevelToEquip)
                throw new InvalidWeaponException("Weapon level too high");
        }

        /// <summary>
        /// Same as above, just for armor
        /// </summary>
        public void ArmorLevelCheck()
        {
            if (Level < Armor.LevelToEquip)
                throw new InvalidArmorException("Armor level too high");
        }

        /// <summary>
        /// This method increases the level of the character, and raises the attributes
        /// </summary>
        public void LevelUp()
        {
            //Checks what type of character it is
            if (GetType() == typeof(Mage))
            {
                Attribute.Strength += 1;
                Attribute.Dexterity += 1;
                Attribute.Intelligence += 5;
            }
            if (GetType() == typeof(Warrior))
            {
                Attribute.Strength += 3;
                Attribute.Dexterity += 2;
                Attribute.Intelligence += 1;
            }
            if (GetType() == typeof(Range))
            {
                Attribute.Strength += 1;
                Attribute.Dexterity += 5;
                Attribute.Intelligence += 1;
            }
            if (GetType() == typeof(Rouge))
            {
                Attribute.Strength += 1;
                Attribute.Dexterity += 4;
                Attribute.Intelligence += 1;
            }
            Level++;
        }        

        /// <summary>
        /// This is supposed to calculate total damage for the character. At the moment it does not work as intended,
        /// It only runs if weapon AND armor is selected
        /// </summary>
        /// <returns>Total damage value</returns>
        public double CalculateTotalDamage()
        { 
            double totalBaseAttributes = Attribute.Strength + Attribute.Dexterity + Attribute.Intelligence;

            if (Weapon.GetType() == typeof(Weapon) && (Armor.GetType() == typeof(Armor)))
            {
                double weaponDamage = Weapon.WeaponAttributes.Damage * Weapon.WeaponAttributes.AttackSpeed;
                double totalArmorAttributes = Armor.Attribute.Strength + Armor.Attribute.Dexterity + Armor.Attribute.Intelligence;
                return weaponDamage * (1 + ((totalBaseAttributes + totalArmorAttributes) / 100));
            } 
            else if (Weapon.GetType() == typeof(Weapon))
            {
                double weaponDamage = Weapon.WeaponAttributes.Damage * Weapon.WeaponAttributes.AttackSpeed;
                return weaponDamage * (1 + (totalBaseAttributes / 100));
            }
            else if (Armor.GetType() == typeof(Armor))
            {
                double totalArmorAttributes = Armor.Attribute.Strength + Armor.Attribute.Dexterity + Armor.Attribute.Intelligence;
                return 1 * (1 + ((totalBaseAttributes + totalArmorAttributes) / 100));
            } 
            else
            {
                return 1 * (1 + (totalBaseAttributes / 100));
            }
        }

        /// <summary>
        /// Collects all different check methods in one method
        /// </summary>
        public void CharacterChecks()
        {
            WeaponCompatibility();
            WeaponLevelCheck();
            ArmorLevelCheck();
            ArmorCompatibility();
        }

        /// <summary>
        /// Displays all stats
        /// </summary>
        public void ShowStats()
        {
            double[] ArmorAttributes = {Armor.Attribute.Strength, Armor.Attribute.Dexterity, Armor.Attribute.Intelligence };
            Console.WriteLine($"WITHOUT ITEMS - Strength: {Attribute.Strength} Dexterity: {Attribute.Dexterity} Intelligence: {Attribute.Intelligence}");
            Console.WriteLine($"WITH ITEMS - Strength: {Attribute.Strength + ArmorAttributes[0]} Dexterity: {Attribute.Dexterity + ArmorAttributes[1]} Intelligence: {Attribute.Intelligence + ArmorAttributes[2]}");
            Console.WriteLine($"{Name} - Damage: {CalculateTotalDamage()}");
        }
    }
}
