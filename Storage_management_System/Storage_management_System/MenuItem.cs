using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_management_System
{
    public class MenuItem
    {
        public int Id{get;set;}
        public string name { get; set; }

        public string Image { get; set; }
        public int Left { get; set; }

        public static ObservableCollection<MenuItem> MenuList()
        {
            ObservableCollection<MenuItem> menus = new ObservableCollection<MenuItem>()

        {
            new MenuItem()
            {
                Id = 1,
                name = "Fire-Noodle",
                Image = "Assets/Fire-Noodle.png",
                Left = 8
            },
            new MenuItem()
            {
                Id = 2,
                name = "Spicy-Bag",
                Image = "Assets/Spicy-Bag.png",
                Left = 5
            },


             new MenuItem()
            {
                Id = 3,
                name = "spring-roll",
                Image = "Assets/spring-roll.png",
                Left = 3
            },

              new MenuItem()
            {
                Id = 4,
                name = "Chicken",
                Image = "Assets/Cheken.png",
                Left = 9
            },


                 new MenuItem()
            {
                Id = 5,
                name = "Chips",
                Image = "Assets/Chips.png",
                Left = 30
            }
        };

            return menus;


        }

    }

}
