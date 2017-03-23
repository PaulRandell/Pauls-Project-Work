using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Redirects the user to the customer record page
        Response.Redirect("CustomerRecord.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Redirects the user to the customer record page
        Response.Redirect("CustomerRecord.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Redirects the user to the customer delete page
        Response.Redirect("CustomerDelete.aspx");
    }
}