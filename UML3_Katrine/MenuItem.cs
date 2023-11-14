using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public abstract class MenuItem : IMenuItem
    {
        //instance fields 
        public int Number { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        
        //constructor 
        public MenuItem(int number, string name, string description, 
            double price, MenuType menutype, bool isvegan, bool isorganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = menutype;
            IsVegan = isvegan;
            IsOrganic = isorganic;
        }

        //metoder
        public virtual void PrintInfo()
        {
             Console.WriteLine(ToString());
            
        }
        public override string ToString()
        {
            
            return $"toostring ting "+(IsVegan? "vegan ":"not vegan ")+(IsOrganic? "organic ":"not organic ");
        }


    }
}
