using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Models
{
    public class Realty
    {
        public int Id { get; set; }
        public PublicPlace Place { get; set; }
        public decimal TaxValue  { get; set; }
    }
}
