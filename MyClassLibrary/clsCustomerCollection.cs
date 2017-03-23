using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        
        public clsCustomer ThisCustomer { get; set; }

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
            public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                
            }
        } 
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //obkect for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ACustomer.FName = Convert.ToString(DB.DataTable.Rows[Index]["FName"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.SName = Convert.ToString(DB.DataTable.Rows[Index]["SName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

    }
}