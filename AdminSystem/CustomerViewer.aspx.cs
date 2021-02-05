using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomer
        clsCustomers ACustomer = new clsCustomers();

        //Get the data from the session object 
        ACustomer = (clsCustomers)Session["ACustomer"];

        //Display all data for this entry
        Response.Write(ACustomer.CustomerName);

        Response.Write(ACustomer.CustomerEmail);

        Response.Write(ACustomer.Password);

        Response.Write(ACustomer.CustomerAddress);

        Response.Write(ACustomer.DOB);
    }
}