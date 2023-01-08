using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCreatTask.Models
{
    internal class Student
    {
        static int _id = 1;
        public int Id { get; set; }

        public string FullName { get; set; }
        public string GroupNo { get; set; } 
        public bool Type { get; set; }

        public Student(string fullname, int type)
        {
            FullName = fullname;
            switch (type)
            {
                case 1:
                    Type = true;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("This Student has a guaranteed education");
                    break;

                case 2:
                    Type = false;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("This Student does not have a guaranteed education");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please choose valid number!!!");
                    return;

            }
                    Id = _id;
                    _id++;
        }
        public override string ToString()
        {
            return $"Student's Full Name: {FullName}\t\nStudent's Guaranteed Status: {Type}";
        }
    }
}
