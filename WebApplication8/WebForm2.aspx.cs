using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public database database2 = new database();

        
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUserName = database2.getCurrentUsername();
            label1.InnerHtml = "<h3> Welcome "+currentUserName+"<h3>";

            string[] tests = database2.getAvailableTests();
            int totalTests = tests.Length;
            String str1 = "<p>Available tests</p>";
            for (int i = 0; i < totalTests; i++)
            {
                if ( tests[i] != null && tests[i].Length > 0)
                {
                    str1 += "<p><Button ID='hello' runat='server' >" + tests[i] + "</Button></p>";
                }
            }

            testList.InnerHtml = str1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string test = TextBox1.Text;
            Boolean valid = database2.validTest(test);
            if (valid)
            {
                database2.setCurrentTest(test);
                Response.Redirect("/WebForm3.aspx");
            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "Please select the right test ";
            }
            
        }

        
    }
}