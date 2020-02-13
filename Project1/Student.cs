using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class Student

    {

        string studentName;

        string studentID;

        public Student() { }

        public Student(string name, string id)
        {
            this.studentName = name;
            this.studentID = id;
        }

        public string getStudentName()
        {
            return this.studentName;
        }
        public void setStudentName(string name)
        {
            this.studentName = name;
        }

        public string getStudentID()
        {
            return this.studentID;
        }

        public void setStudentID(string id)
        {
            this.studentID = id;
        }

        public string getAnswer(string requestCapital, string capital, string country, int total) {
            if (requestCapital.ToLower() == capital) {
                total++;
                return " Question: What is the capital of <strong>" + country + "</strong> <br /> Your Answered right: " +
                                      "<strong>" + requestCapital + "</strong> is the capital of <strong>"+ country +  " </strong><br /> You scored one point. <br />";


            }
            else if (requestCapital.ToLower() != capital)
            {
                return " Question: What is the capital of <stromng>" + country + "</strong> <br />  Your Answered wrong, the answer is not:  " +
                                     " <strong>" + requestCapital + "</strong>" + "<br /> " + "the right answer is: " + "<strong>"+capital+"</strong>. <br>" +
                                     "You Scored Zero point.";
            }
            return "";

        }

        public  string calculateGrade(int score)
        {
            if(score >= 15)
            {
                return "A";
            }
            else if(score >= 10 && score < 15)
            {
                return "B";

            }
            else if (score >= 5 && score < 10)
            {
                return "c";
            }
            else if (score > 0 && score < 5)
            {
                return "D";
            }
           
                return " failed ";
            

        }
    }     
            
    
}