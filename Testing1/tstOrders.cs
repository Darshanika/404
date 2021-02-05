using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();

            //test to see that it exists
            Assert.IsNotNull(AnOrder);

        }
        [TestMethod]
        public void Over18PropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
    }
}
