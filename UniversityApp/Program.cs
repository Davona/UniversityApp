using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(UniversityService);
            MethodInfo[] methods = type.GetMethods();
            Type[] type3 = type.GetInterfaces();
            for (int i = 0; i < type3.Length; i++)
            {
                Console.WriteLine(type3[i].Name);
            }
            Console.WriteLine();
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i].Name);
            }
            Console.WriteLine();
            ParameterInfo[] parameters = methods[0].GetParameters();
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine(parameters[i].Name);
            }
            Console.WriteLine();
            StudentModel student = new StudentModel(25, "Ashot", 21, "Iravagituyun");
            Type type1 = student.GetType();
            ConstructorInfo[] constructor = type1.GetConstructors();
            parameters = constructor[0].GetParameters();
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine(parameters[i].ParameterType.Name+" " + parameters[i].Name);
            }
            Console.WriteLine();
            object[] param = new object[] { 021, "Armen", 23, "Lezvabanutyun" };
            object student1 = constructor[0].Invoke(param);
            TeacherModel teacher = new TeacherModel(025, "Anush", 25, null);
            Type type2 = teacher.GetType();
            PropertyInfo[] properties = type2.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i].Name+" "+ properties[i].GetValue(teacher));
            }
            Console.WriteLine();
            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i].Name + " " + properties[i].GetValue(new TeacherModel(012,"Inna",32,null)));
            }


        }
    }
}
