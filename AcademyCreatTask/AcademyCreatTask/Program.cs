
using AcademyCreatTask.Enums;
using AcademyCreatTask.Models;
using AcademyCreatTask.Services.Implimentation;

AcademyServices services= new AcademyServices();
services.CreatGroup(LessonCategorys.Programming, 2);
services.CreateStudent("Elmeddin Mirzeyev", 1);
services.CreateStudent("Elmeddin Mirzeyev", 2);
services.CreateStudent("Elmeddin Mirzeyev", 1);
services.CreatGroup(LessonCategorys.Design, 1);
services.CreatGroup(LessonCategorys.SystemAdministration, 2);
services.GetAllGroups();
services.GetAllStudents();