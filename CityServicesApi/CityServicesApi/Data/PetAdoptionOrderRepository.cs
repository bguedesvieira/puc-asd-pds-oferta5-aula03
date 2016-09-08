using CityServicesApi.ApiException;
using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Data
{
    public class PetAdoptionOrderRepository
    {
        private static int _lastId = 0;
        private static List<PetAdoptionOrder> _orders = new List<PetAdoptionOrder>();

        public List<PetAdoptionOrder> GetAllPetAdoptionOrder()
        {
            return _orders;
        }

        public PetAdoptionOrder GetPetAdoptionOrder(int id)
        {
            var order = _orders.FirstOrDefault((p) => p.Id == id);
            return order;
        }

        public PetAdoptionOrder AddPetAdoptionOrder(PetAdoptionOrder order)
        {
            PetAdoptionOrder serviceOrder = order;
            _lastId++;
            serviceOrder.Id = _lastId;
            _orders.Add(order);
            return serviceOrder;
        }

        public PetAdoptionOrder UpdatePetAdoptionOrder(PetAdoptionOrder order)
        {
            var adoptionOrder = _orders.FirstOrDefault((p) => p.Id == order.Id);
            if (adoptionOrder == null)
            {
                throw new CityServiceException(500, "Solicitação de Adoção de animal não encontrada! Contactar administrador");
            }
            _orders.Remove(adoptionOrder);
            _orders.Add(order);

            return order;
        }

        public void RemovePetAdoptionOrder(PetAdoptionOrder order)
        {
            var adoptionOrder = _orders.FirstOrDefault((p) => p.Id == order.Id);
            if (adoptionOrder == null)
            {
                throw new CityServiceException(500, "Solicitação de Adoção de animal não encontrada! Contactar administrador.");
            }
            _orders.Remove(adoptionOrder);
        }
    }
}
