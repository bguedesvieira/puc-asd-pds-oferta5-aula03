using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Dto.v1
{
    public class PublicPlaceGarbageCollectionResponse
    {
        public int PublicPlaceId { get; set; }
        public string GarbageCollection { get; set; }
    }
}
