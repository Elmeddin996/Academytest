using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AcademyCreatTask.Services.Interfaces
{
    internal interface IAcademyServices
    {
        public List<AcademyGroups> Groups { get; }
        public string CreatGroup(LessonCategorys categorys, int online);
        public string EditGroup(string no, string newNo);
        public string CreateStudent(string fullname,int type);
        public void GetStudents(string no);
        public void GetAllGroups();
        public void GetAllStudents();

    }
}
