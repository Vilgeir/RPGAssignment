using System;

namespace RPGCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Mage newmage = new Mage();

            newmage.Name = "Trine";

            newmage.Level = 1;

            newmage.SetBaseStats();

            

            newmage.ShowStats();

            newmage.increaseLvl();

            newmage.ShowStats();




        }

       
    }
}
