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
        public int _id;
        public string _name;
        public int _age;
        public List<StudentModel> _students;
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
        public int _id;
        public string _name;
        public int _age;
        public string _faculty;
        public TeacherModel _teacher;
    }
}
