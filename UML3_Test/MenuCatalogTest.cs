using NuGet.Frameworks;
using UML3_Katrine;

namespace UML3_Test
{
    [TestClass]
    public class MenuCatalogTest
    {
        
        //arrange
        MenuCatalog catalog;
        public void SetUp()
        {
            catalog = new MenuCatalog();
            MenuItem m1 = new Pizza(1, "test", "test beskrivelse", 45.50, MenuType.Pizza, true, false, false, "test topping");
            catalog.Add(m1);
        }


        [TestMethod]
        public void Add_1MenuItem()
        {
            //arrange
            SetUp();
            //act
            int numbersBefore = catalog.Count;
            MenuItem m2 = new Pizza (2,"test","test beskrivelse", 45.50, MenuType.Pizza, true, false, false, "test topping"); 
            catalog.Add(m2);
            int numbersAfter = catalog.Count;
            //assert
            Assert.AreEqual(numbersBefore+1, numbersAfter);


        }

        [TestMethod]
        public void Delete_1MenuItem()
        {
            //arrange 
            SetUp();
            //act 
            //MenuItem m3 = new Pizza(3, "test", "test beskrivelse", 45.50, MenuType.Pizza, true, false, false, "test topping");
            int numbersBefore = catalog.Count;
            catalog.Delete(1);
            int numbersAfter = catalog.Count;
            //assert 
            Assert.AreEqual (numbersBefore-1, numbersAfter);

        }

        [TestMethod]
        public void Search_1MenuItem()
        {
            //arrange
            SetUp();
            MenuItem m4 = new Pizza(4, "test", "test beskrivelse", 45.50, MenuType.Pizza, true, false, false, "test topping");
            catalog.Add(m4);
            //act
            IMenuItem found = catalog.Search(4);
            //assert
            Assert.AreEqual(m4,found);
            Assert.IsNotNull(catalog.Search(1));

        }
        
    }
}