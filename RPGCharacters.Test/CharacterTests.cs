using System;
using Xunit;

namespace RPGCharacters.Test
{
    public class CharacterTests
    {
        [Fact]
        public void CheckIf_NewCharacter_IsLevel1()
        {
            //Arrange
            Mage mage = new Mage()
            {
                Name = "Test",
                Attribute = new Attribute()
                {
                    Strength = 1,
                    Dexterity = 1,
                    Intelligence = 8,
                }
            };
            double expectedLevel = 1;
            //Act
            double actualLevel = mage.Level;
            //Assert
            Assert.Equal(expectedLevel, actualLevel);

        }

        [Fact]
        public void TryTo_LevelUp_Character()
        {
            //Arrange
            Mage mage = new Mage()
            {
                Name = "Test",
                Attribute = new Attribute()
                {
                    Strength = 1,
                    Dexterity = 1,
                    Intelligence = 8,
                }
            };  
            double expectedLevel = 2;
            //Act
            mage.LevelUp();
            double actualLevel = mage.Level;
            //Assert
            Assert.Equal(expectedLevel, actualLevel);
            
        }

        [Fact]
        public void CheckIf_AttributesIncrease_WhenLevelingUp_MAGE()
        {
            //Arrange
            Mage mage = new Mage()
            {
                Name = "Test",
                Attribute = new Attribute()
                {
                    Strength = 1,
                    Dexterity = 1,
                    Intelligence = 8,
                }
            };
            double expectedStrength = mage.Attribute.Strength + 1;
            double expectedDexterity = mage.Attribute.Dexterity + 1;
            double expectedIntelligence = mage.Attribute.Intelligence + 5;
            //Act
            mage.LevelUp();
            double actualStength = mage.Attribute.Strength;
            double actualDexterity = mage.Attribute.Dexterity;
            double actualIntelligence = mage.Attribute.Intelligence;
            //Assert
            Assert.Equal(expectedStrength, actualStength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void CheckIf_AttributesIncrease_WhenLevelingUp_WARRIOR()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                Name = "Test",
                Attribute = new Attribute()
                {
                    Strength = 5,
                    Dexterity = 2,
                    Intelligence = 1,
                }
            };
            double expectedStrength = warrior.Attribute.Strength + 3;
            double expectedDexterity = warrior.Attribute.Dexterity + 2;
            double expectedIntelligence = warrior.Attribute.Intelligence + 1;
            //Act
            warrior.LevelUp();
            double actualStength = warrior.Attribute.Strength;
            double actualDexterity = warrior.Attribute.Dexterity;
            double actualIntelligence = warrior.Attribute.Intelligence;
            //Assert
            Assert.Equal(expectedStrength, actualStength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
    }
}
