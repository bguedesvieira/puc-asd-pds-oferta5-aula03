using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    public class ServicesController : ApiController
    {
        Service[] services = new Service[]
        {
            new Service { Id = 1, Name = "Solicitação de Poda de Árvore"  },
            new Service { Id = 2, Name = "Solicitação de Construção de Meio-Fio"},
            new Service { Id = 3, Name = "Solicitação de Recolhimento de Carros Abandonados"},
            new Service { Id = 4, Name = "Solicitação de Desobstrução de Vias Públicas" },
            new Service { Id = 5, Name = "Solicitação de Desobstrução de Córregos" },
            new Service { Id = 6, Name = "Solicitação de Coleta de Animal Morto"},
            new Service { Id = 7, Name = "Solicitação de Limpeza de Boca de Lobo" },
            new Service { Id = 8, Name = "Pedido de adoção de cães" }

        };

        public IEnumerable<Service> GetAllServices()
        {
            return services;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var service = services.FirstOrDefault((p) => p.Id == id);
            if (service == null)
            {
                return NotFound();
            }
            return Ok(service);
        }

    }
}
