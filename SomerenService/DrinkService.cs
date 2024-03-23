using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
    }
}