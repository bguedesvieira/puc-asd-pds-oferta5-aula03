using CityServicesApi.Models;
using CityServicesApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    public class PublicPlacesController : ApiController
    {

        private PublicPlaceRepository _publicPlaceRepository = new PublicPlaceRepository();

        // GET: api/v1/publicplaces
        public IEnumerable<PublicPlace> Get()
        {
            return _publicPlaceRepository.GetAllPublicPlaces();
        }
    }


}
