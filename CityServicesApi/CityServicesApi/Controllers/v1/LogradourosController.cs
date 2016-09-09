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
    [RoutePrefix("api/{folder}/logradouros")]
    public class LogradourosController : ApiController
    {

        private PublicPlaceRepository _publicPlaceRepository = new PublicPlaceRepository();

        // GET: api/v1/publicplaces
        public IEnumerable<PublicPlace> Get()
        {
            return _publicPlaceRepository.GetAllPublicPlaces();
        }

        [HttpGet]
        [Route("coletalixo/{id}")]
        public IHttpActionResult GetRealtyTaxValue(int id)
        {

            PublicPlace place = _publicPlaceRepository.GetPublicPlace(id);
            if (place== null)
            {
                return NotFound();
            }

            PublicPlaceGarbageCollectionResponse response = new PublicPlaceGarbageCollectionResponse();
            response.PublicPlaceId  = place.Id;
            response.GarbageCollection = place.GarbageCollection;

            return Ok(response);
        }


    }


}
