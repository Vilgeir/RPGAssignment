using System;
using Xunit;

namespace RPGCharacters.Test
{
    public class ItemTests
    {
        

        [Fact]
        public void CheckIf_WrongWeaponLevel_ThrowsException()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Weapon = new Weapon()
                {
                    ItemName = "Axe",
                    LevelToEquip = 2,
                    WeaponType = Weapon.WeaponTypes.Axe,
                    WeaponAttributes = new WeaponAttributes()
                    {
                        Damage = 10,
                        AttackSpeed = 2,
                    }
                }
            };
            string expected = "Weapon level too high";
            //Act
            var excemtion = Assert.Throws<InvalidWeaponException>(() => warrior.WeaponLevelCheck());
            string actual = excemtion.Message;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIf_WrongArmorLevel_ThrowsException()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Armor = new Armor()
                {
                    ItemName = "Body Armor",
                    LevelToEquip = 2,
                    ArmorType = Armor.ArmorTypes.Plate,
                    Attribute = new Attribute()
                    {
                        Strength = 2,
                        Dexterity = 2,
                        Intelligence = 2,
                    }
                }
            };
            string expected = "Armor level too high";
            //Act
            var excemtion = Assert.Throws<InvalidArmorException>(() => warrior.ArmorLevelCheck());
            string actual = excemtion.Message;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIf_WrongWeaponType_IsEquipped()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Weapon = new Weapon()
                {
                    ItemName = "Bow",
                    LevelToEquip = 1,
                    WeaponType = Weapon.WeaponTypes.Bow,
                    WeaponAttributes = new WeaponAttributes()
                    {
                        Damage = 10,
                        AttackSpeed = 2,
                    }
                }
            };
            string expected = "Invalid weapon";
            //Act
            var excemtion = Assert.Throws<InvalidWeaponException>(() => warrior.WeaponCompatibility());
            string actual = excemtion.Message;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIf_WrongArmorType_IsEquipped()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Armor = new Armor()
                {
                    ItemName = "Body Armor",
                    LevelToEquip = 1,
                    ArmorType = Armor.ArmorTypes.Cloth,
                    Attribute = new Attribute()
                    {
                        Strength = 2,
                        Dexterity = 2,
                        Intelligence = 2,
                    }
                }
            };
            string expected = "Invalid armor";
            //Act
            var excemtion = Assert.Throws<InvalidArmorException>(() => warrior.ArmorCompatibility());
            string actual = excemtion.Message;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_With_NoWeapon_Equipped()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Attribute = new Attribute()
                {
                    Strength = 5,
                    Dexterity = 2,
                    Intelligence = 1
                },
            };
            double baseAttributes = warrior.Attribute.Strength + warrior.Attribute.Dexterity + warrior.Attribute.Intelligence;
            double expected = 1 * (1 + (baseAttributes / 100));
            //Act
            double actual = warrior.CalculateTotalDamage();
            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CalculateDamage_With_OnlyValidWeapon_Equipped()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Attribute = new Attribute()
                {
                    Strength = 5,
                    Dexterity = 2,
                    Intelligence = 1
                },
                Weapon = new Weapon()
                {
                    ItemName = "Axe",
                    LevelToEquip = 1,
                    WeaponType = Weapon.WeaponTypes.Axe,
                    WeaponAttributes = new WeaponAttributes()
                    {
                        Damage = 7,
                        AttackSpeed = 1.1,
                    }
                },
                Armor = new Armor()
                {
                    Attribute = new Attribute()
                }
            };
            double baseAttributes = warrior.Attribute.Strength + warrior.Attribute.Dexterity + warrior.Attribute.Intelligence;
            double weaponAttributes = warrior.Weapon.WeaponAttributes.Damage * warrior.Weapon.WeaponAttributes.AttackSpeed;
            double expected = weaponAttributes * (1 + (baseAttributes / 100));
            //Act
            double actual = warrior.CalculateTotalDamage();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDamage_With_ValidWeapon_And_ValidArmor_Equipped()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Level = 1,
                Attribute = new Attribute()
                {
                    Strength = 5,
                    Dexterity = 2,
                    Intelligence = 1
                },
                Weapon = new Weapon()
                {
                    ItemName = "Axe",
                    LevelToEquip = 1,
                    WeaponType = Weapon.WeaponTypes.Axe,
                    WeaponAttributes = new WeaponAttributes()
                    {
                        Damage = 7,
                        AttackSpeed = 1.1,
                    }
                },
                Armor = new Armor()
                {
                    ItemName = "Cloth",
                    LevelToEquip = 1,
                    ArmorType = Armor.ArmorTypes.Plate,
                    Attribute = new Attribute()
                    {
                        Strength = 4,
                    }
                }
            };
            double baseAttributes = warrior.Attribute.Strength + warrior.Attribute.Dexterity + warrior.Attribute.Intelligence;
            double weaponAttributes = warrior.Weapon.WeaponAttributes.Damage * warrior.Weapon.WeaponAttributes.AttackSpeed;
            double armorAttributes = warrior.Armor.Attribute.Strength;
            double expected = weaponAttributes * (1 + ((baseAttributes + armorAttributes) / 100));
            //Act
            double actual = warrior.CalculateTotalDamage();
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}

