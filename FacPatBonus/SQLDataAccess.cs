using System;

namespace FacPatBonus
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public static List<Product> Products = new List<Product>()
        {

            new Product () {Name= "PS5" , Price = 450 },
            new Product () {Name= "XBOX1", Price = 500 },
            new Product () {Name= "SWITCH", Price = 400 },


        };

        public List<Product> LoadData() // this LoadData Requires a Return to remove error
        {
            Console.WriteLine("I am reading data from SQL Data Accrsss");

            return Products;  // we will return the items in Products which is a new list made from Product 
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access");
        }
    }
}

