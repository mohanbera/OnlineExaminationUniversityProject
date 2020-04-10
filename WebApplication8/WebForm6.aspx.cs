using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        database database5 = new database();

        protected void Page_Load(object sender, EventArgs e)
        {
            string curName = database5.getCurrentUsername();
            label1.InnerHtml = "<h3>Welcome " + curName+"</h3>";
        }

        protected void submitAction(object sender, EventArgs e)
        {
            int totalTests = database5.getTotalTest();
            string course = TextBox1.Text;
            if (course.Length > 3)
            {
                database5.insertCourse(course);

                database5.setText(totalTests, 0, 0, TextBox2.Text);
                database5.setText(totalTests, 0, 1, TextBox3.Text);
                database5.setText(totalTests, 0, 2, TextBox4.Text);
                database5.setText(totalTests, 0, 3, TextBox5.Text);
                database5.setText(totalTests, 0, 4, TextBox6.Text);
                database5.setText(totalTests, 0, 5, TextBox7.Text);

                database5.setText(totalTests, 1, 0, TextBox8.Text);
                database5.setText(totalTests, 1, 1, TextBox9.Text);
                database5.setText(totalTests, 1, 2, TextBox10.Text);
                database5.setText(totalTests, 1, 3, TextBox11.Text);
                database5.setText(totalTests, 1, 4, TextBox12.Text);
                database5.setText(totalTests, 1, 5, TextBox13.Text);

                database5.setText(totalTests, 2, 0, TextBox14.Text);
                database5.setText(totalTests, 2, 1, TextBox15.Text);
                database5.setText(totalTests, 2, 2, TextBox16.Text);
                database5.setText(totalTests, 2, 3, TextBox17.Text);
                database5.setText(totalTests, 2, 4, TextBox18.Text);
                database5.setText(totalTests, 2, 5, TextBox19.Text);

                database5.setText(totalTests, 3, 0, TextBox20.Text);
                database5.setText(totalTests, 3, 1, TextBox21.Text);
                database5.setText(totalTests, 3, 2, TextBox22.Text);
                database5.setText(totalTests, 3, 3, TextBox23.Text);
                database5.setText(totalTests, 3, 4, TextBox24.Text);
                database5.setText(totalTests, 3, 5, TextBox25.Text);

                database5.setText(totalTests, 4, 0, TextBox26.Text);
                database5.setText(totalTests, 4, 1, TextBox27.Text);
                database5.setText(totalTests, 4, 2, TextBox28.Text);
                database5.setText(totalTests, 4, 3, TextBox29.Text);
                database5.setText(totalTests, 4, 4, TextBox30.Text);
                database5.setText(totalTests, 4, 5, TextBox31.Text);

                database5.increaseTotalTest();
                Label2.Text = "Your test has been uploaded.";
                Response.Redirect("/WebForm5.aspx");
            }
            else
            {
                Label2.Text = "Please enter a valid course.";
            }


        }
    }
}