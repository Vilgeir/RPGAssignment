using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public class Mage : Character
    {

        public bool MageTest { get; set; } = true;

        Attribute Stat = new Attribute();

        public Mage()
        {
            SetBaseStats();
        }

        public void SetBaseStats()
        {
            if (Level == 1)
            {
                Stat.Strength = 1;
                Stat.Dexterity = 1;
                Stat.Intelligence = 8;
            }
        }


        //public override void LevelUp() 
        //{
        //    stat.Strength += 1;
        //    stat.Dexterity += 1;
        //    stat.Intelligence += 8;
        //    Level++;
        //}

        //public override void ShowStats()
        //{
        //    Console.WriteLine($"LVL: {Level} Strength: {Stat.Strength}, Dexterity: {Stat.Dexterity}, Intelligence: {Stat.Intelligence}");
        //}

    }
} 
