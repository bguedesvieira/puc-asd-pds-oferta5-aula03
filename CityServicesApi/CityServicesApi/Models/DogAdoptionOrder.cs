﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Models
{
    public class DogAdoptionOrder
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
    }
}
