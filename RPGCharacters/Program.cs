using System;

namespace RPGCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {

            Mage newMage = new Mage()
            {
                Name = "Lux",
                Attribute = new Attribute()
                {
                    Strength = 1,
                    Dexterity = 1,
                    Intelligence = 8,
                },
                Weapon = new Weapon()
                {
                    ItemName = "Wand",
                    LevelToEquip = 1,
                    WeaponType = Weapon.WeaponTypes.Wand,
                    WeaponAttributes = new WeaponAttributes()
                    {
                        Damage = 13,
                        AttackSpeed = 2,
                    }
                },
                Armor = new Armor()
                {
                    ItemName = "Cloth",
                    LevelToEquip = 1,
                    ArmorType = Armor.ArmorTypes.Cloth,
                    Attribute = new Attribute()
                    {
                        Strength = 2,
                        Dexterity = 2,
                        Intelligence = 3,
                    }
                }
            };

            newMage.CharacterChecks();
            newMage.LevelUp();
            newMage.ShowStats();

        }
    }
}
