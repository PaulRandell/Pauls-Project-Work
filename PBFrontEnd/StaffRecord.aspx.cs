using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff display page
        Response.Redirect("StaffDisplay.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff display page
        Response.Redirect("StaffDisplay.aspx");
    }
}