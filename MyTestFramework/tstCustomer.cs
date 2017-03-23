using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Test Address";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DOB, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "testemail@hotmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void CustomerFNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Test Name";
            //assign the data to the property
            ACustomer.FName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FName, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);

        }




        [TestMethod]
        public void CustomerPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "XXXXXXXXXXX";
            //assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }
        [TestMethod]
        public void CustomerPostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "XXX XXX";
            //assign the data to the property
            ACustomer.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Postcode, TestData);
        }





        [TestMethod]
        public void CustomerSNamePropertyOK
           ()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Test Name";
            //assign the data to the property
            ACustomer.SName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.SName, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);

            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.Address != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.DOB != Convert.ToDateTime("04/07/1997 00:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.Email != "testemail@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.FName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.PhoneNo != "XXXXXXXXXXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.Postcode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean varaiable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            // check the customer ID
            if (ACustomer.SName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "";  //this should trigger an error
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "X";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXXXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(500, 'X');//This should trigger an error
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "";//this should trigger an error
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "X";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXXXXXXXXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXXXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PheNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXXXXXXXXXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "";
            Postcode = Postcode.PadRight(500, 'X');//this should trigger an error
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void FNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "";//this should trigger an error
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "X";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "XX";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "XXXXXXXXXXXXXXXXXXX";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "XXXXXXXXXXXXXXXXXXXX";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "XXXXXXXXXXX";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "XXXXXXXXXXXXXXXXXXXXX";//this should trigger an error
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "";
            FName = FName.PadRight(500, 'X');//this should trigger an error
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "";//this should trigger an error
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "X";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "XX";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "XXXXXXXXXXXXXXX";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";//this should trigger an error
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "";
            SName = SName.PadRight(500, 'X');//this should trigger an error
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "";//this should trigger an error
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "X";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "XX";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "XXXXXXXXXXXXXXX";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";//this should trigger an error
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "";
            Address = Address.PadRight(500, 'X');//this should trigger an error
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "";//this should trigger an error
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "X";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "XX";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "";
            Email = Email.PadRight(49, 'X');
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "";
            Email = Email.PadRight(50, 'X');
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "XXXXXXXXXXXXXXXXXXXXXXXXX";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "";//this should trigger an error
            Email = Email.PadRight(51, 'X');
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DOB = DateTime.Now.Date.AddYears(-40).ToString();
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "";
            Email = Email.PadRight(500, 'X');//this should trigger an error
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
      
         [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";//this should trigger an error
             //create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 500 years
            TestDate = TestDate.AddYears(-500);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 10 years and -1 day
            TestDate = TestDate.AddYears(-100);
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";//this should trigger an error
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 100 years +1 day
            TestDate = TestDate.AddYears(-100);
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 17 years - 1 day
            TestDate = TestDate.AddYears(-17);
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DOBMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 17 years
            TestDate = TestDate.AddYears(-17);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail@hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DOBMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 41 years
            TestDate = TestDate.AddYears(-41);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DOBMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date - 17 years +1 day
            TestDate = TestDate.AddYears(-17);
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";//this should trigger an error
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            // create a variable to store the teste data date
            DateTime TestDate;
            //Set todays date
            TestDate = DateTime.Now.Date;
            //change the data to todays date + 200 years
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DOBInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaiable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PhoneNo = "XXXXXXXXXXX";
            string Postcode = "XXX XXX";
            string FName = "SomeName";
            string SName = "SomeName";
            string Address = "Some Address";
            string Email = "myemail @hotmail.com";
            string DOB = "this is not a date";
            //invoke the method
            OK = ACustomer.Valid(DOB, PhoneNo, Postcode, FName, SName, Address, Email);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
