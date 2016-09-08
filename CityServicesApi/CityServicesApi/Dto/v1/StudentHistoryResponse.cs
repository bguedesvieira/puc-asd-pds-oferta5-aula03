using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Dto.v1
{
    public class StudentSubject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Decimal Grade { get; set; }
    }

    public class StudentHistoryResponse
    {
        public int StudentId { get; set; } 
        public List<StudentSubject> Subjects { get; set; }
    }
}
