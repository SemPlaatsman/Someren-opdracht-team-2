using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
        //new DrinkDao
        DrinkDao drinkdb;

        //constructor to initialize the drinkdb
        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        //command to get all drinks with the drinkdb
        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }

        public List<Drink> GetDrinksByID(int ID)
        {
            List<Drink> drinks = drinkdb.GetDrinkByid(ID);
            return drinks;
        }

        //command to add a drink with the drinkdb
        public void AddDrink(Drink drink)
        {
            drinkdb.Add(drink);
        }

        //command to update a drink with the drinkdb
        public void UpdateDrink(Drink oldDrink, Drink newDrink)
        {
            drinkdb.Update(oldDrink, newDrink);
        }

        //command to delete a drink with the drinkdb
        public void DeleteDrink(Drink drink)
        {
            drinkdb.Delete(drink);
        }
    }
}
