using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp
{

    interface IPrint 
    {
        void ShowSchedule();


    }


    public class UniversityService:IPrint
    {
        public void Show(List<StudentModel> _students)
        {

            for (int i = 0; i < _students.Count; i++)
            {
                Console.WriteLine("--------------");
                Console.WriteLine($"_id-{_students[i]._id}" + " " + $"_name-{_students[i]._name}" + " " + $"_age-{_students[i]._age}" + " " + $"_faculty-{_students[i]._faculty}");
                Console.WriteLine("Student's teacher");
                if (_students[i]._teacher != null)
                {
                    Console.WriteLine($"_id-{_students[i]._teacher._id}" + " " + $"_name-{_students[i]._teacher._name}" + " " + $"_age-{_students[i]._teacher._age}");
                }
            }
        }
        public void Show(List<TeacherModel> _teachers)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                Console.WriteLine("---------");
                Console.WriteLine($"_id-{_teachers[i]._id}" + " " + $"_name-{_teachers[i]._name}" + " " + $"_age-{_teachers[i]._age}");
                Console.WriteLine("Teacher's students");
                if (_teachers[i]._students != null)
                {
                    for (int j = 0; j < _teachers[i]._students.Count; j++)
                    {
                        Console.WriteLine($"_id-{_teachers[i]._students[j]._id}" + " " + $"_name-{_teachers[i]._students[j]._name}" + " " + $"_age-{_teachers[i]._students[j]._age}" + " " + $"_faculty-{_teachers[i]._students[j]._faculty}");
                    }
                }
            }
        }

        public void ShowSchedule()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public List<TeacherModel> Swap(List<StudentModel> students, List<TeacherModel> teachers)
        {
            int count = 0;
            for (int i = 0; i < students.Count; i++)
            {
                teachers[count]._students.Add(students[i]);
                count++;
                if (count == teachers.Count)
                {
                    count = 0;
                }
            }
            return teachers;
        }
        public List<StudentModel> Swap(List<TeacherModel> teachers, List<StudentModel> students)
        {
            int k = 0;
            for (int i = 0; i < students.Count; i++)
            {
                students[i]._teacher = teachers[k];
                k++;
                if (k == teachers.Count)
                {
                    k = 0;
                }
            }
            return students;
        }
    }
}
