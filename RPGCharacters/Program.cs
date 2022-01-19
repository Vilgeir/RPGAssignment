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
                Level = 1,
                Attribute = new Attribute()
                {
                    Strength = 1,
                    Dexterity = 1,
                    Intelligence = 8,
                },
                Weapon = new Weapons()
                {
                    ItemName = "Staff",
                    LevelToEquip = 1,
                    //ItemSlot = "staff",
                    WeaponType = Weapons.WeaponTypes.Wand,
                    WeaponAttributes = new WeaponAttributes()
                    {
                        Damage = 10,
                        AttackSpeed = 2,
                    }
                },
                Armor = new Armor()
                {
                    ItemName = "Cloth",
                    LevelToEquip = 1,
                    //ItemSlot = ,
                    ArmorType = Armor.ArmorTypes.Mail,
                    Attribute = new Attribute()
                    {
                        Strength = 2,
                        Dexterity = 2,
                        Intelligence = 2,
                    }
                }
            };

            newMage.CharacterChecks();
            newMage.ShowStats();
            newMage.LevelUp();
            newMage.ShowStats();

        }
    }
}
