using BootstrapMVCTest.Models;
using BootstrapMVCTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstCoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Create a List of Students
            //In Real-Time, you will get the data from the database
            List<Student> listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };

            //Pass the Student List to the View to make the view as a Strongly Typed View
            return View(listStudents);
        }

        public ViewResult Details(int Id)
        {
            //Here, we have hard coded the student details
            //In Real-Time, you will get the student information from the database
            Student studentDetails = new Student() { StudentId = Id, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" };

            //Pass the Student model to the View to make the view as a Strongly Typed View
            return View(studentDetails);
        }
    }
}