using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{

    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 21;
            TestItem.Address = "Some Address";
            TestItem.Postcode = "XXX XXX";
            TestItem.FName = "SomeName";
            TestItem.PhoneNo = "XXXXXXXXXXX";
            TestItem.SName = "SomeName";
            TestItem.Email = "myemail @hotmail.com";
            TestItem.DOB = DateTime.Now.Date.AddYears(-40);
            //add the item to the testlist
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
        
        

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 21;
            TestCustomer.Address = "Some Address";
            TestCustomer.Postcode = "XXX XXX";
            TestCustomer.FName = "SomeName";
            TestCustomer.PhoneNo = "XXXXXXXXXXX";
            TestCustomer.SName = "SomeName";
            TestCustomer.Email = "myemail @hotmail.com";
            TestCustomer.DOB = DateTime.Now.Date.AddYears(-40);
            //assign the data to this property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that  the two values are the same

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to thie list
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 21;
            TestItem.Address = "Some Address";
            TestItem.Postcode = "XXX XXX";
            TestItem.FName = "SomeName";
            TestItem.PhoneNo = "XXXXXXXXXXX";
            TestItem.SName = "SomeName";
            TestItem.Email = "myemail @hotmail.com";
            TestItem.DOB = DateTime.Now.Date.AddYears(-40);
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the propterty
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are equal
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
       
    }
}
