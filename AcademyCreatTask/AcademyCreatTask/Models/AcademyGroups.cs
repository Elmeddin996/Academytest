using AcademyCreatTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCreatTask.Models
{
    internal class AcademyGroups
    {
        static int _id = 100;
        public int Id { get; set; }
        public string No { get; set; }
        public bool IsOnline { get; set; }
        public int Limite { get; set; }   
        public LessonCategorys Category { get; set; }

        private List<Student> _students { get; set; } = new List<Student>();

        public List<Student> Students { get { return _students; } }


        public AcademyGroups(LessonCategorys category, int online) 
        {
            No = $"{category.ToString().Substring(0,1)}{_id}";
            Category = category;
            IsOnline=false ;


            switch (online)
            {
                case 1:
                    IsOnline=true;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("This Group is Online");
                    break;

                case 2:
                    IsOnline=false;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("This Group is Offline");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose valid number!!!");
                    return;
            }
            Id=_id;
            _id++;

        }
        public override string ToString()
        {
            return $" No:{No}\t\n Category:{Category}\t\n Group includes {Students.Count} Student\t\n";
        }
    }
}
