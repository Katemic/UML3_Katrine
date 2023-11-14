using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public interface IMenuItem
    {
        //alle ting fra interface er public 
        //interface er en supertype, MenuItem er en Superclass og pizza er en subclass
        int Number { get; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        MenuType Type { get; set; }
        bool IsVegan { get; set; }
        bool IsOrganic { get; set; }

        void PrintInfo();

    }
}
