using System;
using System.Collections.Generic;


namespace MyClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerID Property
        private Int32 mCustomerID;
        //private data member for the Address Property
        private string mAddress;
        //private data member for the DOB Property
        private DateTime mDOB;
        //private data member for the Email Property
        private string mEmail;
        //private data member for the FName Property
        private string mFName;
        //private data member for the PhoneNo Property
        private string mPhoneNo;
        //private data member for the Postcode Property
        private string mPostcode;
        //private data member for the SName Property
        private string mSName;





        public string Address
        {
            get
            {
                //return private data
                return mAddress;
            }
            set
            {
                // set the private data
                mAddress = value;
            }
        }

        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the value of the private data member
                mDOB = value;
            }
        }
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the private data member
                mEmail = value;
            }
        }
        public string FName
        {
            get
            {
                //return the private data
                return mFName;
            }
            set
            {
                //set the value of the private data member
                mFName = value;
            }
        }
        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the value of the private data member
                mPhoneNo = value;
            }
        }
        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }
            set
            {
                //set the value of the private data member
                mPostcode = value;
            }
        }
        public string SName
        {
            get
            {
                //return the private data
                return mSName;
            }
            set
            {
                //set the value of the private data member
                mSName = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramether for the Customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCust_ID");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data member to test data value
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFName = Convert.ToString(DB.DataTable.Rows[0]["FName"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mSName = Convert.ToString(DB.DataTable.Rows[0]["SName"]);

                // return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }



        public bool Valid(string dOB, string phoneNo, string postcode, string fName, string sName, string address, string email)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            DateTime DateTemp;
            //if the PhoneNo is blank
            if (phoneNo.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the PhoneNo greater than 20 characters
            if (phoneNo.Length > 20)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the Postcode is blank
            if (postcode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Postcoe greater than 10 characters
            if (postcode.Length > 10)
            {
                //set the flag OK to false
                OK = false;
            }

            //if the fName is blank
            if (fName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the fName greater than 20 characters
            if (fName.Length > 20)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the sName is blank
            if (sName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the sName greater than 30 characters
            if (sName.Length > 30)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address is blank
            if (address.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address greater than 30 characters
            if (address.Length > 30)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the email is blank
            if (email.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the email greater than 50 characters
            if (email.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //copy the DOB value to the Date Temp variable
            try
            {
                 
                DateTemp = Convert.ToDateTime(dOB);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //set the flag OK to false
                    OK = false;
                }
                // if the Date is less than todays date minus 17 years
                if (DateTemp > DateTime.Now.Date.AddYears(-17))
                {
                    //set the flag OK to false
                    OK = false;
                }
            }

            catch
            {
                OK = false;
            }
            //return the value of OK
            return OK;
        }

      /*  public static implicit operator List<object>(clsCustomer v)
        {
            throw new NotImplementedException();
        }*/
    }
    }

