using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public class Topping : MenuItem
    {
        //constructor
        public Topping(int number, string name, string description, double price, MenuType menutype,
            bool isvegan, bool isorganic)
            : base(number, name, description, price, menutype, isvegan, isorganic)
        {

        }

        //methods 
        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Number}.\t |{Name}|\t\t |{Price}kr |" +
                $"\n\t -{Description}" +
                $"\n\t {(IsVegan ? "Vegan" : "Not vegan")}" +
                $"\n\t {(IsOrganic ? "Organic" : "Not organic")}\n";
        }
    }
}

