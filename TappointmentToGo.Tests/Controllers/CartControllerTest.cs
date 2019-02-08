using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TappointmentToGo.Models;

namespace TappointmentToGo.Tests.Controllers
{
    [TestClass]
    public class CartTest
    {
        public Cart Cart { get; private set; }
        public List<MenuItem> MenuItems { get; private set; }

        [TestInitialize]
        public void SetUp()
        {
            Cart = new Cart(int.MaxValue);
            MenuItems = new MenuItem[10].Select(i => new MenuItem()).ToList();
        }

        [TestMethod]
        public void AddItem_HasNewCartItem()
        {
            // Act
            Cart.Add(MenuItems[0]);

            // Assert
            Assert.AreEqual(Cart.ItemsNumber, 1);
        }

        [TestMethod]
        public void AddTwoItems_WhenTheSameItem_CartItemsCountStaysOne()
        {
            // Act
            Cart.Add(MenuItems[0]);
            Cart.Add(MenuItems[0]);

            // Assert
            Assert.AreEqual(Cart.CartItems.Count, 1);
        }

        [TestMethod]
        public void AddTwoItems_WhenDifferentItems_CartItemsCountIsTwo()
        {
            // Arrange
            MenuItems[1].Id += 1;

            // Act
            Cart.Add(MenuItems[0]);
            Cart.Add(MenuItems[1]);

            // Assert
            Assert.AreEqual(Cart.CartItems.Count, 2);
        }

        [TestMethod]
        public void AddItem_PriceIsCorrect()
        {
            // Arrange
            MenuItems[0].Price = 1000;

            // Act
            Cart.Add(MenuItems[0]);

            // Assert
            Assert.AreEqual(Cart.Total, 1000);
        }

        [TestMethod]
        public void AddMultipleItems_PriceIsCorrect()
        {
            // Arrange
            MenuItems[0].Price = 1000;
            MenuItems[1].Price = 1300;
            MenuItems[2].Price = 200;

            // Act
            Cart.Add(MenuItems[0]);
            Cart.Add(MenuItems[1]);
            Cart.Add(MenuItems[1]);
            Cart.Add(MenuItems[2]);

            // Assert
            Assert.AreEqual(Cart.Total, 3800);
        }

        [TestMethod]
        public void AddItem_WhenCartEmpty_PricesasdIsCorrect()
        {
            // Arrange
            MenuItems[0].Price = 1000;

            // Act
            Cart.Add(MenuItems[0]);

            // Assert
            Assert.AreEqual(Cart.Total, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(CartFullException))]
        public void AddItem_WhenCartCantHoldMore_ThrowsException()
        {
            // Arrange
            MenuItems[0].Price = 1000;
            Cart.MaxAmount = 0;

            // Act
            Cart.Add(MenuItems[0]);

            // Assert: Expect exception
        }
    }
}
