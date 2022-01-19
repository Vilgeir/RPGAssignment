using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters
{
    public abstract class Item
    {
        public string ItemName { get; set; }
        public int LevelToEquip { get; set; }
        public string ItemSlot { get; set; } = "empty";
        public int HeadSlot { get; set; } = 0;
        public int BodySlot { get; set; } = 0;
        public int LegSlot { get; set; } = 0;

        // public string Slot { get; set; } = new Dictionary<string, string>();

        Dictionary<string, string> items = new Dictionary<string, string>();


        public Item()
        {
            //SetSlot();
        }

        public void SetSlot()
        {
            items.Add("weapon", ItemSlot);
            items.Add("body_armor", ItemSlot);

            Console.WriteLine(items["weapon"]);
            Console.WriteLine(items["body_armor"]);

            //try
            //{
            //    itemSlot.Add("weapon", "axe");

            //} catch (ArgumentException)
            //{
            //    Console.WriteLine("weapon is already equiped");
            //}       
            
        }

        public void SlotCheck()
        {
            //Console.WriteLine(items["weapon"]);
            //Console.WriteLine(items["body_armor"]);
        }

    }
}
