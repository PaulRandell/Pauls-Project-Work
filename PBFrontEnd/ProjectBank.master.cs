using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProjectBank : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff display page
        Response.Redirect("StaffDisplay.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff display page
        Response.Redirect("CustomerDisplay.aspx");
    }

    protected void btnCars_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff display page
        Response.Redirect("CarDisplay.aspx");
    }

    protected void btnSales_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff display page
        Response.Redirect("SalesDisplay.aspx");
    }
}
