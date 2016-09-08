using CityServicesApi.Models;
using CityServicesApi.Data;
using CityServicesApi.Dto.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    [RoutePrefix("api/{folder}/imovel")]
    public class RealtyController : ApiController
    {
        private RealtyRepository _realtyRepository = new RealtyRepository();

        [HttpGet]
        [Route("valoriptu/{id}")]
        public IHttpActionResult GetRealtyTaxValue(int id)
        {

            Realty realty = _realtyRepository.GetRealty(id);
            if (realty == null)
            {
                return NotFound();
            }
            RealtyTaxValueResponse response = new RealtyTaxValueResponse();
            response.RealtyId = realty.Id;
            response.TaxValue = realty.TaxValue;

            return Ok(response);
        }
    }
}
