using System;
using System.Collections.Generic;
using System.Text;
using Xunit; // to use as a test case
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        /// <summary>
        /// "Mock" Order to use for test case
        /// </summary>
        public class MockOrderItem:IOrderItem
        {
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; } = new List<string>();
        }

        [Fact] // This means it needs to be visible by test explorer
        // Test for Order item:
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item); // method implemented from Order interface
            Assert.Contains(item, order.Items); // checks if 'items' is in 'order.Items'
        }

        // Test for remove item:
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order(); // we need an order to check
            var item = new MockOrderItem(); // we need a mock order
            order.Add(item); // need to add it before we fail. *this test will fail if the 'add' test fails!!*
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items); // checks if 'item' is NOT in 'order.Items'
        }

        // Test to get the enumeration of items:
        [Fact]
        public void ShouldBeAbleToGetEnumerationOfItems()
        {
            var order = new Order();

            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();

            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item), // take the collection, for each item in the collection, do the Assert() method
                item => Assert.Equal(item1, item), 
                item => Assert.Equal(item2, item));
        }

        // Test for the sum of the item prices
        [Theory] // Theory takes in parameters
        [InlineData(new double[] { 1, 2, 3 })] // data to be tested. all of these params will be tested!
        [InlineData(new double[] { 199.34, 799})]
        [InlineData(new double[] { 0,0.3,0})]
        [InlineData(new double[] { 798})]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5})]
        [InlineData(new double[] { 3.13413434313 })]
        [InlineData(new double[] {double.NaN })] // NaN = 'not a number'

        public void SubtotalShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;

            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }


        // should trigger PropertyChanged for items
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChangedForPrice(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () => // add an event listener to order, listen to when "Price" changes, then trigger order.Add, and if it adds, it'll notify us of the change.
            {
                order.Add(item);
            });
        }
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () => // add an event listener to order, listen to when "Price" changes, then trigger order.Add, and if it adds, it'll notify us of the change.
            {
                order.Remove(item);
            });
        }
    }
}
