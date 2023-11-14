using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public class Pizza : MenuItem
    {
        
        //instance fields 
        public bool DeepPan {  get; set; }
        public string Toppings { get; set; }

        //constructor 
        public Pizza(int number, string name, string description, double price, MenuType menutype, 
            bool isvegan, bool isorganic, bool deepPan, string toppings) 
            : base(number, name, description, price, menutype, isvegan, isorganic)
        {
            DeepPan = deepPan;
            Toppings = toppings;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Number}.\t |{Name}|\t\t |{Price}kr |" +
                $"\n\t -{Toppings}" +
                $"\n\t -{Description}" +
                $"\n\t {(IsVegan ? "Vegan" : "Not vegan")}" +
                $"\n\t {(IsOrganic ? "Organic" : "Not organic")}" +
                $"\n\t {(DeepPan ? "DeepPan available" : "DeepPan not available")}\n";
        }

    }
}
