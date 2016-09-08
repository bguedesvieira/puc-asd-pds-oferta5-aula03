using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Data
{
    public class RealtyRepository
    {
        private static Realty[] _realties = new Realty[]
        {
            new Realty {Id=1,
                        TaxValue =1000,
                        Place = new PublicPlace{ Id = 4, Type = "Rua", Name = "Sergipe", PostalCode = 30130170 } },
             new Realty {Id=2,
                        TaxValue =1200,
                        Place = new PublicPlace{ Id = 3, Type = "Avenida", Name = "Afonso Pena", PostalCode = 30130000} },
              new Realty {Id=3,
                        TaxValue =300,
                        Place = new PublicPlace{ Id = 1, Type = "Rua", Name = "Cláudio Manoel", PostalCode = 30140100} },
               new Realty {Id=4,
                        TaxValue =1500,
                        Place = new PublicPlace{ Id = 2, Type = "Praça", Name = "da Liberdade", PostalCode = 30140010} },
        };

        public Realty GetRealty(int id)
        {
            var realty = _realties.FirstOrDefault((p) => p.Id == id);
            return realty;
        }
    }
}
