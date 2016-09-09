using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Data
{
    public class PublicPlaceRepository
    {
        private static PublicPlace[] _places = new PublicPlace[]
        {
            new PublicPlace { Id = 1, Type = "Rua", Name = "Cláudio Manoel", PostalCode = 30140100,GarbageCollection ="SEGUNDA;QUARTA"},
            new PublicPlace { Id = 2, Type = "Praça", Name = "da Liberdade", PostalCode = 30140010,GarbageCollection="TERÇA;QUINTA;SABADO"},
            new PublicPlace { Id = 3, Type = "Avenida", Name = "Afonso Pena", PostalCode = 30130000,GarbageCollection="TODOS OS DIAS"},
            new PublicPlace { Id = 4, Type = "Rua", Name = "Sergipe", PostalCode = 30130170, GarbageCollection="SEGUNDA;QUARTA;SEXTA;SABADO" }
        };

        public PublicPlace[] GetAllPublicPlaces()
        {
            return _places;
        }

        public PublicPlace GetPublicPlace(int id)
        {
            var place = _places.FirstOrDefault((p) => p.Id == id);
            return place;
        }

    }
}
