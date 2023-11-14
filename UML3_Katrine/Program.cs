using UML3_Katrine;

//oprettelse af objekter 
Pizza p1 = new Pizza(1, "pizza1", "test description", 35.0, MenuType.Pizza, true, true, true,"tomater");
Pizza p4 = new Pizza(1, "pizza1", "test description", 35.0, MenuType.Pizza, true, true, false, "tomater");
Pizza p2 = new Pizza(2, "pizza2", "test description", 33.0, MenuType.Pizza, false, true, false, "tomater");
Pizza p3 = new Pizza(3, "pizza3", "test description", 37.0, MenuType.Pizza, true, false, false, "tomater");
Beverage b1 = new Beverage(11, "Cola", "test description", 20.0,MenuType.SoftDrink,true,false,false,"0.33");
Beverage b2 = new Beverage(12, "Wine", "test description", 45.0, MenuType.AlcoholicDrink, true, true, true, "0.75");
Topping t1 = new Topping(21, "Extra cheese", "test description", 10.0, MenuType.Topping, false, true);
Topping t2 = new Topping(22, "Extra salad", "test description", 10.0, MenuType.Topping, true, true);


IMenuCatalog catalog = new MenuCatalog();

//test af exception 
Console.WriteLine("Test af exception");
try
{
catalog.Add(p1);
catalog.Add(p4);
}
catch (MenuItemNumberExist nex)
{
    Console.WriteLine(nex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"something went wrong: {ex.Message}");
}

//test af add
catalog.Add(p2);
catalog.Add(p3);
catalog.Add(b1);
catalog.Add(b2);
catalog.Add(t1);
catalog.Add(t2);


//test af print
Console.WriteLine("\nTest af print menu");
catalog.PrintPizzasMenu(); 
catalog.PrintBeveragesMenu();
catalog.PrintToppingsMenu();



//test af search 
Console.WriteLine("\ntest af search");
Console.WriteLine(catalog.Search(1));
Console.WriteLine(catalog.Search(5));


//test af vegansk liste
Console.WriteLine("\nPrint af vegansk pizza");

List<IMenuItem> veganPizza = catalog.FindAllVegan(MenuType.Pizza);
foreach (var item  in veganPizza)
{
    Console.WriteLine(item.ToString());
}

//test af most expensive item
Console.WriteLine("\ntest af most expensive item");
Console.WriteLine(catalog.MostExpensiveMenuItem());

//test af printInfo
Console.WriteLine("\ntest af printInfo");
p1.PrintInfo();

//test af update 
Console.WriteLine("\nTest af update");
Console.WriteLine("pizza inden update");
Console.WriteLine(catalog.Search(1));
Pizza p5 = new Pizza(1, "pizza1", "updated pizza", 35.0, MenuType.Pizza, true, true, true, "tomater");
catalog.Update(p5.Number, p5);
Console.WriteLine("pizza efter update");
Console.WriteLine(catalog.Search(1));




