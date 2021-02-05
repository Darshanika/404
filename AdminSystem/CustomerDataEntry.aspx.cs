using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomer
        clsCustomers ACustomer = new clsCustomers();

        //Capture the all
        ACustomer.CustomerName = txtCustomerName.Text;

        ACustomer.CustomerEmail = txtCustomerEmail.Text;

        ACustomer.Password = txtPassword.Text;

        ACustomer.CustomerAddress = txtCustomerAddress.Text;

        //ACustomer.DOB = txtDateOfBirth.Text;


        //Store the address in the session object
        Session["ACustomer"] = ACustomer;

        //Navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}