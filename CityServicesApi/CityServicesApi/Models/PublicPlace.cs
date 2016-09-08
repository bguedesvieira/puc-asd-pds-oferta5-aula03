using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Models
{
    public class PublicPlace
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
    }
}
