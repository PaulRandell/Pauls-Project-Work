using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Redirects the user to the car record page
        Response.Redirect("CarRecord.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Redirects the user to the car record page
        Response.Redirect("CarRecord.aspx");
    }

    protected void btnArchive_Click(object sender, EventArgs e)
    {
        //Redirects the user to the car delete page
        Response.Redirect("CarArchive.aspx");
    }
}