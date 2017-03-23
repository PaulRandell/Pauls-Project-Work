using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Address";
            //assign the data to the property
            AStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, TestData);
        }

        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DOB, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Email";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void StaffFNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some FName";
            //assign the data to the property
            AStaff.FName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FName, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);

        }

        [TestMethod]
        public void StaffJobPositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Position";
            //assign the data to the property
            AStaff.JobPosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.JobPosition, TestData);
        }

        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "07123456789";
            //assign the data to the property
            AStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneNo, TestData);
        }
        [TestMethod]
        public void StaffPostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Postcode";
            //assign the data to the property
            AStaff.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Postcode, TestData);
        }



        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            decimal TestData = 15000.00m;
            //assign the data to the property
            AStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }

        [TestMethod]
        public void StaffSNamePropertyOK
           ()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some SName";
            //assign the data to the property
            AStaff.SName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.SName, TestData);
        }


    }
}