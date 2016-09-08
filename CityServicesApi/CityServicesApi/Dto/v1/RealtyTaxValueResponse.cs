using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Dto.v1
{
    public class RealtyTaxValueResponse
    {
        public int RealtyId { get; set; }
        public Decimal TaxValue { get; set; }
    }
}
