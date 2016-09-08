using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    public class DogAdoptionOrdersController : ApiController
    {
        DogAdoptionOrder[] adoptions = new DogAdoptionOrder[]
        {
            new DogAdoptionOrder { Id = 1, Cpf = "05412823602", Adress = "Rua Sabará 355", Name = "Bernardo Guedes Vieira" }
            
        };
        int lastId = 1;

        // GET: api/v1/DogAdoptionOrders
        public IEnumerable<DogAdoptionOrder> Get()
        {
            return adoptions;
        }

        // GET: api/DogAdoptionOrders/5
        public IHttpActionResult Get(int id)
        {
            var adoption = adoptions.FirstOrDefault((p) => p.Id == id);
            if (adoption == null)
            {
                return NotFound();
            }
            return Ok(adoption);
        }

        // POST: api/DogAdoptionOrders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DogAdoptionOrders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DogAdoptionOrders/5
        public void Delete(int id)
        {
        }
    }
}
