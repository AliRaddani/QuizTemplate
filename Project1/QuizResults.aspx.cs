using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class QuizResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int totalScore = 16;
            string studentName = Request["firstname"];
            string studentID= Request["studentid"];
            Student student = new Student(studentName, studentID);
           
            lblDisplay.Text = " Student Name: " + "<strong> " +student.getStudentName() + "</strong>"+ "<br/>" + " StudentID: "  +"<strong> " + student.getStudentID() + "</strong>";

            string franceCapital = Request["france"];
            string germanyCapital = Request["germany"];
            string indiaCapital = Request["india"];
            string chinaCapital = Request["china"];
            string afganistanCapital = Request["afganistan"];
            string moroccoCapital = Request["morocco"];
            string canadaCapital = Request["canada"];
            string chileCapital = Request["chile"];
            string spainCapital = Request["spain"];
            string senegalCapital = Request["senegal"];
            string bahrainCapital = Request["bahrain"];
            string angolaCapital = Request["angola"];
            string beninCapital = Request["benin"];
            string danmarkCapital = Request["danmark"];
            string salvadorCapital = Request["salvador"];
            string albaniaCapital = Request["albania"];
            string laosCapital = Request["laos"];
            string jordanCapital = Request["jordann"];
            string kenyaCapital = Request["kenya"];
            string latviaCapital = Request["latvia"];


            lblQuestion1.Text = student.getAnswer(franceCapital.ToLower(), "paris", "France", totalScore);
            lblScore.Text = student.calculateGrade(totalScore);
        }
    }
}