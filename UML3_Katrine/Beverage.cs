using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public class Beverage : MenuItem
    {
        //instance fields
        public bool Alcohol { get; set; }
        public string DrinkSizeLiter { get; set; }

        //constructor 
        public Beverage(int number, string name, string description, double price, MenuType menutype, 
            bool isvegan, bool isorganic, bool alcohol, string drinkSizeLiter) 
            : base(number, name, description, price, menutype, isvegan, isorganic)
        {
            Alcohol = alcohol;
            DrinkSizeLiter = drinkSizeLiter;

        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Number}.\t |{Name}|\t\t |{Price}kr |" +
                $"\n\t -{DrinkSizeLiter}L" +
                $"\n\t -{Description}" +
                $"\n\t {(IsVegan ? "Vegan" : "Not vegan")}" +
                $"\n\t {(IsOrganic ? "Organic" : "Not organic")}" +
                $"\n\t {(Alcohol ? "Is alcoholic" : "Does not contain alcohol")}\n";
        }



    }
}
