using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        database database4 = new database();

        protected void Page_Load(object sender, EventArgs e)
        {
            string curName = database4.getCurrentUsername();
            label1.InnerHtml = "<h3>Welcome " + curName + "</h3>";

            int correct = database4.getCorrect();
            int inCorrect = database4.getInCorrect();
            int totaScore = database4.getResult();

            pScore.InnerHtml = "<h1>" + totaScore + "/20</h1>";
            pCorrect.InnerHtml = "<h3> correct answers: " + correct + "</h3>";
            pInCorrect.InnerHtml = "<h3>incorrect answers: " + inCorrect + "</h3>";

        }
    }
}