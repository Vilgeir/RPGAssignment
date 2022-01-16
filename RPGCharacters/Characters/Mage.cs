using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public class Mage : Character
    {

        Attribute stat = new Attribute();

        public void SetBaseStats()
        {
            if (Level == 1)
            {
                stat.Strength = 1;
                stat.Dexterity = 1;
                stat.Intelligence = 8;
                Console.WriteLine("Just the beginning");
            } else
            {
                Console.WriteLine("Way to go!");
            }
        }

        public void increaseLvl() 
        {
            stat.Strength += 1;
            stat.Dexterity += 1;
            stat.Intelligence += 8;
            Level++;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Strength: {stat.Strength}, Dexterity: {stat.Dexterity}, Intelligence: {stat.Intelligence}");
        }
      
    }
}
