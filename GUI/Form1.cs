﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dmse_Project_201.Core;
using DMSE_Project_201.Core;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Logic logic = new Logic();
        private Student[] students;
        private Graph chartForm = new Graph();
        private Graph pieForm = new Graph();
        private int[] graphGrades = new int[7];

        private double numCore = 0.0;
        private double numGen = 0.0;
        private double numElective = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            students = logic.LoadStudentFromJson();
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            var id = TXTBuserinput.Text;
            var student = logic.SearchByID(students, id);
            if (student != null)
            {
                DisplayStudent(student);
            }
            else
            {
                NullStudent();
            }
        }

        private void DisplayStudent(Student student)
        {
            numGen = 0;
            numCore = 0;
            numElective = 0;

            foreach (Course course in student.Courses)
            {
                switch (course.CourseType)
                {
                    case "Core":
                        if (course.Grade != "F" && course.Grade != "W" && course.Grade != "I")
                        {
                            numCore++;
                        }
                        break;
                    case "General Education":
                        if (course.Grade != "F" && course.Grade != "W" && course.Grade != "I")
                        {
                            numGen++;
                        }
                        break;
                    case "Elective":
                        if (course.Grade != "F" && course.Grade != "W" && course.Grade != "I")
                        {
                            numElective++;
                        }
                        break;
                }

            }

            LBLname.Text = String.Format("{0} {1}", student.FirstName, student.LastName);
            LBLid.Text = student.ID;
            LBLcore.Text = Math.Round((numCore / 26), 2).ToString();
            LBLelective.Text = Math.Round((numElective / 8), 2).ToString();
            LCLgened.Text = Math.Round((numGen / 8), 2).ToString();
            LBLoverall.Text = Math.Round(((numCore + numGen + numElective) / 42), 2).ToString();

            //LBLcore.Text = logic.PercentComplete(student.Courses.Where(c => c.CourseType == "Core")).ToString();
            //LBLelective.Text = logic.PercentComplete(student.Courses.Where(c => c.CourseType == "Elective")).ToString();
            //LCLgened.Text = logic.PercentComplete(student.Courses.Where(c => c.CourseType == "General Education")).ToString();
            //LBLoverall.Text = logic.PercentComplete(student.Courses).ToString();

            DGCourses.DataSource = student.Courses;
        }


        private void NullStudent()
        {
            MessageBox.Show("No Student Record Found, Please Input Valid Student ID");
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Array.Clear(graphGrades, 0, graphGrades.Length);
            var id = TXTBuserinput.Text;
            var student = logic.SearchByID(students, id);
            if (student != null)
            {
                foreach (Course course in student.Courses)
                {
                    switch (course.Grade)
                    {
                        case "A":
                            graphGrades[0] += 1;
                            break;
                        case "B":
                            graphGrades[1] += 1;
                            break;
                        case "C":
                            graphGrades[2] += 1;
                            break;
                        case "D":
                            graphGrades[3] += 1;
                            break;
                        case "F":
                            graphGrades[4] += 1;
                            break;
                        case "I":
                            graphGrades[5] += 1;
                            break;
                        case "W":
                            graphGrades[6] += 1;
                            break;
                    }
                }
                chartForm.GraphStart(graphGrades[0], graphGrades[1], graphGrades[2], graphGrades[3], graphGrades[4], graphGrades[5], graphGrades[6], student.LastName);
                DisplayStudent(student);
                chartForm.Text = "Overall Grades";
                chartForm.ShowDialog();
                
            }
            else
            {
                NullStudent();
            }

        }

        private void btnPieChart_Click(object sender, EventArgs e)
        {
            
            
            var id = TXTBuserinput.Text;
            var student = logic.SearchByID(students, id);
            if (student != null)
            {
                DisplayStudent(student);
                double numIncomplete = 42.0 - numCore - numGen - numElective;
                pieForm.CreatePieChart(numCore/42, numGen/42, numElective/42, numIncomplete/42, student.LastName);
                pieForm.Text = "Complete Course Percentage";
                pieForm.ShowDialog();
            }
            else
            {
                NullStudent();
            }
            
        }
    }
}
