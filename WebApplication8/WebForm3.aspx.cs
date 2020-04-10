using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        database database3 = new database();

        protected void Page_Load(object sender, EventArgs e)
        {

            string curName = database3.getCurrentUsername();
            label1.InnerHtml = "<h3>Welcome " + curName + "</h3>";

            string[] tests = database3.getAvailableTests();
            int currentTestIndex = database3.getCurrentTestIndex();
            
            
              
            if (currentTestIndex != -1)
            {
                string[,,] questions = database3.getQuestion(currentTestIndex);

                if (questions != null)
                {
                    div1.InnerHtml = "<h4>1. " + questions[currentTestIndex, 0, 0] + "</h4>";
                    RadioButtonList1.Items[0].Text = questions[currentTestIndex, 0, 1];
                    RadioButtonList1.Items[1].Text = questions[currentTestIndex, 0, 2];
                    RadioButtonList1.Items[2].Text = questions[currentTestIndex, 0, 3];
                    RadioButtonList1.Items[3].Text = questions[currentTestIndex, 0, 4];

                    div2.InnerHtml = "<h4>2. " + questions[currentTestIndex, 1, 0] + "</h4>";
                    RadioButtonList2.Items[0].Text = questions[currentTestIndex, 1, 1];
                    RadioButtonList2.Items[1].Text = questions[currentTestIndex, 1, 2];
                    RadioButtonList2.Items[2].Text = questions[currentTestIndex, 1, 3];
                    RadioButtonList2.Items[3].Text = questions[currentTestIndex, 1, 4];

                    div3.InnerHtml = "<h4>3. " + questions[currentTestIndex, 2, 0] + "</h4>";
                    RadioButtonList3.Items[0].Text = questions[currentTestIndex, 2, 1];
                    RadioButtonList3.Items[1].Text = questions[currentTestIndex, 2, 2];
                    RadioButtonList3.Items[2].Text = questions[currentTestIndex, 2, 3];
                    RadioButtonList3.Items[3].Text = questions[currentTestIndex, 2, 4];

                    div4.InnerHtml = "<h4>4. " + questions[currentTestIndex, 3, 0] + "</h4>";
                    RadioButtonList4.Items[0].Text = questions[currentTestIndex, 3, 1];
                    RadioButtonList4.Items[1].Text = questions[currentTestIndex, 3, 2];
                    RadioButtonList4.Items[2].Text = questions[currentTestIndex, 3, 3];
                    RadioButtonList4.Items[3].Text = questions[currentTestIndex, 3, 4];

                    div5.InnerHtml = "<h4>5. " + questions[currentTestIndex, 4, 0] + "</h4>";
                    RadioButtonList5.Items[0].Text = questions[currentTestIndex, 4, 1];
                    RadioButtonList5.Items[1].Text = questions[currentTestIndex, 4, 2];
                    RadioButtonList5.Items[2].Text = questions[currentTestIndex, 4, 3];
                    RadioButtonList5.Items[3].Text = questions[currentTestIndex, 4, 4];

                    
                }

                Label2.Text = "Test code: "+tests[currentTestIndex];
            }
             

            

        }

        protected void submitAction(object sender, EventArgs e)
        {
            string first = RadioButtonList1.SelectedValue;
            string second = RadioButtonList2.SelectedValue;
            string third = RadioButtonList3.SelectedValue;
            string fourth = RadioButtonList4.SelectedValue;
            string fifth = RadioButtonList5.SelectedValue;

            int currentScore = 0;
            int currentTestIndex = database3.getCurrentTestIndex();
            int correct = 0;
            int inCorrect = 0;

            string[, ,] questions = database3.getQuestion(currentTestIndex);

            if (first == questions[currentTestIndex, 0, 5])
            {
                currentScore += 4;
                correct++;
            }
            else
            {
                currentScore -= 1;
                inCorrect++;
            }

            if (second == questions[currentTestIndex, 1, 5])
            {
                currentScore += 4;
                correct++;
            }
            else
            {
                currentScore -= 1;
                inCorrect++;
            }

            if (third == questions[currentTestIndex, 2, 5])
            {
                currentScore += 4;
                correct++;
            }
            else
            {
                currentScore -= 1;
                inCorrect++;
            }

            if (fourth == questions[currentTestIndex, 3, 5])
            {
                currentScore += 4;
                correct++;
            }
            else
            {
                currentScore -= 1;
                inCorrect++;
            }

            if (fifth == questions[currentTestIndex, 4, 5])
            {
                currentScore += 4;
                correct++;
            }
            else
            {
                currentScore -= 1;
                inCorrect++;
            }

            database3.setResult(correct, inCorrect, currentScore);

            Response.Redirect("/WebForm4.aspx");

        }

    }
}