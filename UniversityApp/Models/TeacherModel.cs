using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class TeacherModel
    {
        public TeacherModel(int id, string name, int age ,List<StudentModel>students)
        {
            _id = id;
            _name = name;
            _age = age;
            _students = students;
        }
        public int _id { get; set; }
        public string _name { get; set; }
        public int _age { get; set; }
        public List<StudentModel> _students { get; set; }
    }
    public class StudentModel
    {
        public StudentModel(int id, string name, int age, string faculty)
        {
            _id = id;
            _name = name;
            _age = age;
            _faculty = faculty;
        }
        public int _id { get; set; }
        public string _name { get; set; }
        public int _age { get; set; }
        public string _faculty { get; set; }
        public TeacherModel _teacher;
    }
}
