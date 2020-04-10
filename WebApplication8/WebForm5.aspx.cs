using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        database database2 = new database();
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentUserName = database2.getCurrentUsername();
            label1.InnerHtml = "<h3> Welcome " + currentUserName + "<h3>";

            string[] tests = database2.getAvailableTests();
            int totalTests = tests.Length;
            String str1 = "<p>Available tests</p>";
            for (int i = 0; i < totalTests; i++)
            {
                if (tests[i] != null && tests[i].Length > 0)
                {
                    str1 += "<p><Button ID='hello' runat='server' >" + tests[i] + "</Button></p>";
                }
            }
            testList.InnerHtml = str1;

            string[,] results = database2.getResultStatus();
            int totalResult = database2.getTotalResult();

            string str2 = "<h4>Student results<h4>";

            for (int i = 0; i < totalResult; i++)
            {
                str2 += "<div class='div11'><p>" + results[i, 0] + "</p><p>" + results[i, 1] + "</p><p>" + results[i, 2] + "</p><p>" + results[i, 3] + "</p><p>"+results[i, 4]+"<p/><p>"+results[i, 5]+"<p/></div>";
            }

            card7.InnerHtml = str2;
        }

        protected void createQuestion(object sender, EventArgs e)
        {
            Response.Redirect("/WebForm6.aspx");
        }
    }
}