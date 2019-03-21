using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class ProgramUI
    {
        MenuRepository _menuRepo = new MenuRepository();
        Menu _menu = new Menu();

        internal void Run()
        {
            bool ProgamIsStillRunning = true;

            while (ProgamIsStillRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello. What would you like to do right now? Please choose the number associated with your choice.\n" +
                    "1. Make a new Menu Item\n" +
                    "2. Delete a menu item\n" +
                    "3. Print the current menu\n" +
                    "4. Exit application");
                string inputAsString = Console.ReadLine();
                if (!int.TryParse(inputAsString, out int input))
                {
                    continue;
                }
                switch (input)
                {
                    case 1:
                        NewMenuItem();
                        break;
                    case 2:
                        RemoveMenuItem();
                        break;
                    case 3:
                        PrintCurrentMenuList();
                        break;
                    case 4:
                        ProgamIsStillRunning = false;
                        break;
                }
            }
        }

        private void PrintCurrentMenuList()
        {
            Console.Clear();
            List<Menu> _menuItems = _menuRepo.GetMenuList();
            foreach (Menu MenuItem in _menuItems)
            {
                Console.WriteLine($"{MenuItem.MealNumber}. {MenuItem.MealName} {MenuItem.MealPrice.ToString("C2")}\n" +
                    $"{MenuItem.MealIngredients}\n" +
                    $"{MenuItem.MealDescription}\n");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void RemoveMenuItem()
        {
            Console.Clear();
            PrintCurrentMenuList();

            Console.WriteLine("What is the Menu number you are trying to remove?");
            int RemoveItemNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Item's name you are trying to remove?");
            string RemoveItemName = Console.ReadLine();

            bool success = _menuRepo.RemoveMenuItemBySpecifications(RemoveItemNumber, RemoveItemName);
            if (success == true)
            {
                Console.WriteLine($"The order for {RemoveItemName} was successfully removed.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The order for {RemoveItemName} was unable to be removed at this time.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void NewMenuItem()
        {
            Console.Clear();

            Console.WriteLine("What is the new menu item's number?");
            int Menuitemnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the name of the menu item?");
            string MenuItemName = Console.ReadLine();

            Console.WriteLine("Please Describe the menu item.");
            string MenuItemDescribtion = Console.ReadLine();

            Console.WriteLine("Please List the ingredients in the meal.");
            string MenuItemIngredients = Console.ReadLine();

            Console.WriteLine("What is the new menu item's price?");
            decimal MenuItemPrice = decimal.Parse(Console.ReadLine());

            Menu menutolist = new Menu(MenuItemName, Menuitemnumber, MenuItemDescribtion, MenuItemIngredients, MenuItemPrice);

            _menuRepo.AddMenuItemToList(menutolist);

            Console.WriteLine("We have added the new item to the Menu. Press any key to continue");
            Console.ReadKey();
        }
    }
}
