using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp
{
    class StudentManager
    {
        List<StudentModel> _students;
        public StudentManager()
        {
            _students = new List<StudentModel>();
        }
        public void Add(StudentModel student)
        {
            _students.Add(student);
        }
        public void Update(StudentModel student)
        {
            StudentModel wrongStudent = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == student._id)
                {
                    wrongStudent = _students[i];
                    break;
                }
            }
            int wrongStudentidx = _students.IndexOf(wrongStudent);
            _students[wrongStudentidx] = student;
        }
        public void Delete(int id)
        {
            StudentModel studentForDelete = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                {
                    studentForDelete = _students[i];
                }
            }
            _students.Remove(studentForDelete);
        }
        public StudentModel Get(int id)
        {
            StudentModel student = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                {
                    student = _students[i];
                    break;
                }
            }
            return student;
        }
        public List<StudentModel> GetAll()
        {
            return _students;
        }
    }
}
