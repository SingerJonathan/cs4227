using cs4227.Meal;
using cs4227.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cs4227.Restaurant.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void GetCostTest()
        {
            Order order = StaticAccessor.DB.GetOrder(1);
            double testCost = order.Cost;
            double actualCost = 0;
            var membership = StaticAccessor.DB.GetUser(order.UserId).Membership;

            foreach (var item in order.FoodItems)
                actualCost += item.Cost - item.Discounts[membership];
            actualCost += StaticAccessor.DB.GetRestaurant(order.RestaurantId).Delivery;

            Assert.AreEqual(actualCost, testCost);
        }

        [TestMethod]
        public void CreateMementoTest()
        {
            Order actualOrder = StaticAccessor.DB.GetOrder(1);
            Memento memento = actualOrder.CreateMemento();

            Order testOrder = actualOrder;
            testOrder.SetMemento(memento);

            Assert.AreEqual(actualOrder.Id, testOrder.Id);
            Assert.AreEqual(actualOrder.UserId, testOrder.UserId);
            Assert.AreEqual(actualOrder.Cancelled, testOrder.Cancelled);
            Assert.AreEqual(actualOrder.FoodItems, testOrder.FoodItems);
        }
    }
}