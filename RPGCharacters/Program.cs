using System;

namespace RPGCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {

            Mage newmage = new Mage()
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
                    ItemSlot = "staff",
                    WeaponType = "ree",
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
                    BodySlot = 0,
                    ItemSlot = "Cloth",
                    Attribute = new Attribute()
                    {
                        Strength = 2,
                        Dexterity = 2,
                        Intelligence = 2,
                    }
                }
            };

            newmage.ShowStats();
            newmage.LevelUp();
            newmage.ShowStats();
            newmage.CalculateTotalDamage();
            newmage.WeaponCompatibility();
            newmage.CalculateTotalDamage();
            newmage.LevelUp();
            newmage.CalculateTotalDamage();
        }

        

    }
}
