using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Data
{
    public class StudentRepository
    {
        private static Student[] _students = new Student[]
        {
            new Student {Id = 1,Name = "Joãozinho" ,
            Subjects = new SubjectStudent[]  { new SubjectStudent { Subject = new Subject { Id = 1, Name = "Matemática" },Grade = 7 },
                                               new SubjectStudent { Subject = new Subject { Id = 2, Name = "Português"}, Grade = 7 },
                                               new SubjectStudent {Subject = new Subject { Id = 3, Name = "Inglês" }, Grade = 8 }
                                             }
            },
            new Student {Id = 2,Name = "Maria" ,
            Subjects = new SubjectStudent[]  { new SubjectStudent { Subject = new Subject { Id = 1, Name = "Matemática" },Grade = 9 },
                                               new SubjectStudent { Subject = new Subject { Id = 2, Name = "Português"}, Grade = 8 },
                                               new SubjectStudent {Subject = new Subject { Id = 4, Name = "Espanhol" }, Grade = 10 }
                                             }
            }
        };

        public Student GetStudent(int id)
        {
            var student = _students.FirstOrDefault((p) => p.Id == id);
            return student;
        }

    }
}
