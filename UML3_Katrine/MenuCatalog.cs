using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UML3_Katrine
{
    public class MenuCatalog : IMenuCatalog
    {
        //alle ting der kommer fra interface er altid public 
        
        //instance field
        //der skal være for list eller dic af Imenuitem
        public SortedDictionary<int,IMenuItem> _catalog;

        //constuctor
        //her skal collection intaliseres 
        public MenuCatalog()
        {
            _catalog = new SortedDictionary<int,IMenuItem>();
        }
        
        public int Count { get { return _catalog.Count; } }

        public void Add(IMenuItem aMenuItem)
        {
            if (Search(aMenuItem.Number)!=null)
            {
                throw new MenuItemNumberExist("Error: Menu number already exist");
            }
            _catalog.Add(aMenuItem.Number, aMenuItem);

        }

        public IMenuItem Search(int number)
        { 
            if (_catalog.ContainsKey(number)) 
            { return _catalog[number]; }
            else 
            return null; 
        }

        public void Delete(int number)
        {
            _catalog.Remove(number);   
        }

        public void PrintPizzasMenu()
        {
            Console.WriteLine("Print of pizza menu:");
            foreach (var item in  _catalog.Values)
            {
                
                if (item.Type==MenuType.Pizza)
                {
                    Console.WriteLine(item.ToString()); 
                }

            }

            
        }

        public void PrintBeveragesMenu()
        { 
            Console.WriteLine("print of beverage menu:");
            
            foreach (var item in _catalog.Values)
            {
                if (item.Type==MenuType.SoftDrink || item.Type==MenuType.AlcoholicDrink)
                {
                    Console.WriteLine(item.ToString());
                }
               
            }
        
        }

        public void PrintToppingsMenu()
        { 
            Console.WriteLine("Print of toppings menu:");
            foreach (var item in _catalog.Values)
            {
                if (item.Type==MenuType.Topping) 
                { 
                    Console.WriteLine(item.ToString());
                }
            }
        
        }

        public void Update(int number, IMenuItem theMenuItem)
        { 
            if (_catalog.ContainsKey(number))
            {
                _catalog[number] = theMenuItem;
            }
        
        }


        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> found = new List<IMenuItem>();
            foreach (var item in _catalog.Values)
            {
                
                if (item.IsVegan==true && item.Type==type)
                {
                    found.Add(item);    
                }
            }

            return found; 
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        { 
            List<IMenuItem> found = new List<IMenuItem> ();
            foreach (var item in _catalog.Values)
            {
                if (item.IsOrganic==true && item.Type==type)
                {
                    found.Add (item);
                }
            }
            return found; 
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem result = null;
            foreach (var item in _catalog.Values)
            {
                if (result==null)
                {
                    result = item;
                }
                else if (result.Price<item.Price)
                {
                    result = item;
                }
            }
            return result; 
        }
    }
}
