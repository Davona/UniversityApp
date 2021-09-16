using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentModel> students = new List<StudentModel>();
            List<TeacherModel> teachers = new List<TeacherModel>();
            StudentManager studentManager = new StudentManager();
            for (int i = 0; i < 15; i++)
            {
                studentManager.Add(new StudentModel(i, $"name-{i}", i + 16, $"faculty-{i}"));
            }
            TeacherManager teacherManager = new TeacherManager();
            for (int j = 0; j < 3; j++)
            {
                teacherManager.Add(new TeacherModel(j, $"name-{j}", j + 24,new List<StudentModel>()));
            }
            students = studentManager.GetAll();
            UniversityService university = new UniversityService();
            teachers = teacherManager.GetAll();
            university.Swap(students, teachers);
            university.Swap(teachers, students);
            university.Show(students);
            university.Show(teachers);
        }
    }
}
