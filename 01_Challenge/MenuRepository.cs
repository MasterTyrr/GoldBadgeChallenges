using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepository
    {
        //This is the list of MenuItems
        private List<Menu> _MenuList = new List<Menu>();

        //This will allow the user to add a new menu item to the menu
        public void AddMenuItemToList(Menu newMenuItem)
        {
            _MenuList.Add(newMenuItem);
        }

        //This will allow the program to call the Current menu list
        public List<Menu> GetMenuList()
        {
            return _MenuList;
        }

        //This is a POCO to remove items from the product list 
        public void RemoveMenuItemFromList(Menu MenuItem)
        {
            _MenuList.Remove(MenuItem);
        }

        public bool RemoveMenuItemBySpecifications(int RemoveItemNumber, string RemoveItemName)
        {
            bool successful = false;
            foreach (Menu menuitem in _MenuList)
            {
                if (menuitem.MealNumber == RemoveItemNumber && menuitem.MealName == RemoveItemName)
                {
                    RemoveMenuItemFromList(menuitem);
                    successful = true;
                    break;
                }
            }
            return successful;
        }
    }
}
