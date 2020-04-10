using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public database database1 = new database();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            RadioButtonList1.SelectedIndex = -1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string regNo = TextBox1.Text;
            string password = TextBox2.Text;
            string type = RadioButtonList1.SelectedValue;

            string result = database1.check(regNo, password);

            if (result == "NA")
            {
                Label1.Text = "Wrong reg no or password.";
            }
            else if(result == "student")
            {
                Response.Redirect("/WebForm2.aspx");
            }
            else if (result == "faculty")
            {
                Response.Redirect("/WebForm5.aspx");
            }
        }
    }
}