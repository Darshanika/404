using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();
            //Test to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void LivesInUKCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property 
            Boolean TestData = true;

            //Assign the data to the property 
            ACustomer.LivesInUK = TestData;

            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.LivesInUK, TestData);
        }

        [TestMethod]
        public void DateOfBirthCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //Assign the data to the property 
            ACustomer.DOB = TestData;

            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.DOB, TestData);
        }

        [TestMethod]
        public void CustomerIDCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property
            Int32 TestData = 1;

            //Assign the data to the property 
            ACustomer.CustomerID = TestData;

            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerNameCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property
            String TestData = "Fatimah Badin";

            //Assign the data to the property 
            ACustomer.CustomerName = TestData;

            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property
            String TestData = "fatimahbadin@gmail.com";

            //Assign the data to the property 
            ACustomer.CustomerEmail = TestData;

            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void PasswordCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property
            String TestData = "Fatimah123";

            //Assign the data to the property 
            ACustomer.Password = TestData;

            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void CustomerAddressCustomerOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property
            String TestData = "123 Green Street LE7 8HU";

            //Assign the data to the property 
            ACustomer.CustomerAddress = TestData;

            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }


        
    }
}
