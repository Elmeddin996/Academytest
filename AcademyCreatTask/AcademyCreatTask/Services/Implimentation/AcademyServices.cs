using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using AcademyCreatTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademyCreatTask.Services.Implimentation
{
    internal class AcademyServices : IAcademyServices
    {
        private List<AcademyGroups> _groups { get; set; }= new List<AcademyGroups>();

        public List<AcademyGroups> Groups { get { return _groups; } }

        List<Student> Students= new List<Student>();




        public string CreatGroup(LessonCategorys categorys,int online)
        {
            AcademyGroups group =new AcademyGroups(categorys, online);

           Groups.Add(group);
            
            return $"{group.No}  Succesly created";

        }
        
        public string CreateStudent(string fullname, int type)
        {
            Student student = new Student(fullname,type);

            Students.Add(student);

            return $"{student.FullName} Succesly created";
            
        }


        public string EditGroup(string no, string newNo)
        {
            throw new NotImplementedException();
        }

        public void GetAllGroups()
        {
            foreach (AcademyGroups group in Groups)
            {
                Console.WriteLine(group);
            }
        }

        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetStudents(string no)
        {
            throw new NotImplementedException();
        }
    }
}
