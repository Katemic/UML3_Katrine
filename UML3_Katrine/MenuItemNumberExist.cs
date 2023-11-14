using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public class MenuItemNumberExist : Exception
    {
        public MenuItemNumberExist()
        {
            
        }

        public MenuItemNumberExist(string message)
            :base (message)
        {
            
        }
    }
}
