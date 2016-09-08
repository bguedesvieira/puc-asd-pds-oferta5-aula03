using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Models
{
    public enum ServiceOrderType
    {
        PodaArvore,
        MeioFio,
        RecolhimentoCarro,
        DesobstrucaoViaPublica,
        DesobstrucaoCorrego,
        ColetaAnimal,
        LimpezaBocaLobo
    }

    public class ServiceOrder
    {
        public int Id { get; set; }
        public ServiceOrderType Type { get; set; }
        public DateTime OrderDate { get; set; }
        public PublicPlace Place { get; set; }
    }
}
