using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff record page
        Response.Redirect("StaffRecord.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff record page
        Response.Redirect("StaffRecord.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Redirects the user to the staff delete page
        Response.Redirect("StaffDelete.aspx");
    }
}