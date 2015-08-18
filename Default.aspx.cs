using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                //get values from form
                string transactionAmountz = transactionAmount.Text;
                string customerAmountz = customerAmount.Text;

                //convert values
                double transactionAmount2 = Convert.ToDouble(transactionAmountz);
                double customerAmount2 = Convert.ToDouble(customerAmountz);
                double result = customerAmount2 - transactionAmount2;

                //class
                Change checking = new Change();

                //set accessor
                checking.setValues(result);
                results.Text += "<h1>Change</h1>";
                results.Text += "<div id='changeTotalDiv'><b>CHANGE AMOUNT = "+ result +"</b></div>";

                //get accessor display results
                results.Text += checking.getValues();

                form1.Visible = false;
                results.Visible = true;
               
            }
        }
    }
}