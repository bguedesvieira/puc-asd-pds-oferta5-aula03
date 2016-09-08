using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Models
{
    public enum PetType
    {
        Dog,
        Cat
    }

    public class PetAdoptionOrder
    {
        public int Id { get; set; }
        public PetType Type { get; set; }
        public DateTime OrderDate { get; set; }
        public string PetName { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
    }
}
