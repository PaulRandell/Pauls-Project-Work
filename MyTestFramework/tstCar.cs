using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTestFramework
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(ACar);
        }

             [TestMethod]
        public void CarAgePropertyOK
            ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 23;
            //assign the data to the property
            ACar.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Age, TestData);
        }

        [TestMethod]
        public void CarIDPropertyOK
      ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACar.CarID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarID, TestData);
        }

        [TestMethod]
        public void CarFuelTypePropertyOK
      ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACar.FuelType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.FuelType, TestData);
        }

        [TestMethod]
        public void CarMakePropertyOK
      ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Make";
            //assign the data to the property
            ACar.Make = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Make, TestData);
        }

        [TestMethod]
        public void CarManualGearboxPropertyOK
    ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACar.ManualGearbox = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.ManualGearbox, TestData);
        }

        [TestMethod]
        public void CarManufacturedDatePropertyOK
    ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACar.ManufacturedDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.ManufacturedDate, TestData);
        }

        [TestMethod]
        public void CarModelOK
      ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Model";
            //assign the data to the property
            ACar.Model = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Model, TestData);
        }

        [TestMethod]
        public void CarPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            decimal TestData = 7000.00m;
            //assign the data to the property
            ACar.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Price, TestData);
        }

        [TestMethod]
        public void CarRegNumberlOK
      ()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "AB62 ABC";
            //assign the data to the property
            ACar.RegNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.RegNumber, TestData);
        }




    }
}
