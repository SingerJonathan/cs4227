using System.Collections.Generic;
using cs4227.Restaurant;
using cs4227.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cs4227.Database.Tests
{
    [TestClass]
    public class OrderDatabaseHandlerTests
    {
        [TestMethod]
        public void InsertOrderTest()
        {
            int newestOrderId = StaticAccessor.DB.GetNewestOrderId() + 1;
            List<FoodItem> foodItems = new List<FoodItem>() {StaticAccessor.DB.GetFoodItem(2), StaticAccessor.DB.GetFoodItem(3)};
            Order testOrder = new Order(newestOrderId, 9, 1, foodItems, "This is an address", 5.0);
            StaticAccessor.DB.InsertOrder(testOrder);
            Order actualOrder = StaticAccessor.DB.GetOrder(2);

            Assert.AreEqual(actualOrder.UserId, testOrder.UserId);
            Assert.AreEqual(actualOrder.RestaurantId, testOrder.RestaurantId);
            Assert.AreEqual(actualOrder.Cost, testOrder.Cost);
            Assert.AreEqual(actualOrder.Address, testOrder.Address);
            Assert.AreEqual(actualOrder.Cancelled, testOrder.Cancelled);
            for (int index = 0; index < foodItems.Count; index++)
                Assert.AreEqual(actualOrder.FoodItems[index].Id, testOrder.FoodItems[index].Id);
        }

        [TestMethod]
        public void UpdateOrderTest()
        {
            List<FoodItem> foodItems = new List<FoodItem>() { StaticAccessor.DB.GetFoodItem(1), StaticAccessor.DB.GetFoodItem(2) };
            Order testOrder = new Order(3, 9, 1, foodItems, "This is another address", 8.0 + 5.0, true);

            Order actualOrder = StaticAccessor.DB.GetOrder(3);
            actualOrder.Cost += 5;
            actualOrder.Cancelled = true;
            StaticAccessor.DB.UpdateOrder(actualOrder);

            Assert.AreEqual(actualOrder.Id, testOrder.Id);
            Assert.AreEqual(actualOrder.UserId, testOrder.UserId);
            Assert.AreEqual(actualOrder.RestaurantId, testOrder.RestaurantId);
            Assert.AreEqual(actualOrder.Cost, testOrder.Cost);
            Assert.AreEqual(actualOrder.Address, testOrder.Address);
            Assert.AreEqual(actualOrder.Cancelled, testOrder.Cancelled);
            for (int index = 0; index < foodItems.Count; index++)
                Assert.AreEqual(actualOrder.FoodItems[index].Id, testOrder.FoodItems[index].Id);
        }

        [TestMethod]
        public void GetOrderTest()
        {
            List<FoodItem> foodItems = new List<FoodItem>() { StaticAccessor.DB.GetFoodItem(2), StaticAccessor.DB.GetFoodItem(3) };
            Order actualOrder = new Order(2, 9, 1, foodItems, "This is an address", 5.0);

            Order testOrder = StaticAccessor.DB.GetOrder(2);

            Assert.AreEqual(actualOrder.Id, testOrder.Id);
            Assert.AreEqual(actualOrder.UserId, testOrder.UserId);
            Assert.AreEqual(actualOrder.RestaurantId, testOrder.RestaurantId);
            Assert.AreEqual(actualOrder.Cost, testOrder.Cost);
            Assert.AreEqual(actualOrder.Address, testOrder.Address);
            Assert.AreEqual(actualOrder.Cancelled, testOrder.Cancelled);
            for (int index = 0; index < foodItems.Count; index++)
                Assert.AreEqual(actualOrder.FoodItems[index].Id, testOrder.FoodItems[index].Id);
        }
    }
}