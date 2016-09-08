using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Dto.v1
{
    public class PetAdoptionRequest
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PostalCode { get; set; }
        public string PetName { get; set; }
    }
}
