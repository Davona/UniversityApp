using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp
{
    class TeacherManager
    {
        List<TeacherModel> _teachers;
        public TeacherManager()
        {
            _teachers = new List<TeacherModel>();
        }
        public void Add(TeacherModel teacher)
        {
            _teachers.Add(teacher);
        }
        public void Update(TeacherModel teacher)
        {
            TeacherModel wrongTeacher = null;
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == teacher._id)
                {
                    wrongTeacher = _teachers[i];
                    break;
                }
                int wrongTeacheridx = _teachers.IndexOf(wrongTeacher);
                _teachers[wrongTeacheridx] = teacher;
            }
        }
        public void Delete(int id)
        {
            TeacherModel teacherForDelete = null;
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                {
                    teacherForDelete = _teachers[i];
                }
            }
            _teachers.Remove(teacherForDelete);
        }
        public TeacherModel Get(int id)
        {
            TeacherModel teacher = null;
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                {
                    teacher = _teachers[i];
                    break;
                }
            }
            return teacher;
        }
        public List<TeacherModel> GetAll()
        {
            return _teachers;
        }

    }
}
