using System;
using System.Collections.Generic;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_test
{
    [TestClass]
    public class _01_challenge_test
    {
        [TestMethod]
        public void MenuRepositroy_AddItemToMenu()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu item1 = new Menu();
            Menu item2 = new Menu();
            Menu item3 = new Menu();

            _menuRepo.AddMenuItemToList(item1);
            _menuRepo.AddMenuItemToList(item2);
            _menuRepo.AddMenuItemToList(item3);

            int actual = _menuRepo.GetMenuList().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepositroy_RemoveItemFromMenu()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu item1 = new Menu();
            Menu item2 = new Menu();
            Menu item3 = new Menu();

            _menuRepo.AddMenuItemToList(item1);
            _menuRepo.AddMenuItemToList(item2);
            _menuRepo.AddMenuItemToList(item3);

            _menuRepo.RemoveMenuItemFromList(item1);

            int actual = _menuRepo.GetMenuList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepo_GetMenu()
        {
            // Arrange
            MenuRepository _menuRepo = new MenuRepository();
            Menu ItemOne = new Menu();

            // Act
            _menuRepo.AddMenuItemToList(ItemOne);
            List<Menu>ItemList = _menuRepo.GetMenuList();

            bool expected = true;
            bool actual = ItemList.Contains(ItemOne);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
