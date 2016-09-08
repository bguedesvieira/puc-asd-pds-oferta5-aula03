using CityServicesApi.ApiException;
using CityServicesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Data
{
    public class ServiceOrderRepository
    {

        private static int _lastId = 0;
        private static List<ServiceOrder> _orders = new List<ServiceOrder>();
        
        public List<ServiceOrder> GetAllServiceOrders()
        {
            return _orders; 
        }

        public ServiceOrder GetServiceOrder(int id)
        {
            var order = _orders.FirstOrDefault((p) => p.Id == id);
            return order;
        }

        public ServiceOrder AddServiceOrder(ServiceOrder order)
        {
            ServiceOrder serviceOrder = order;
            _lastId++;
            serviceOrder.Id = _lastId;
            _orders.Add(order);
            return serviceOrder;
        }

        public ServiceOrder UpdateServiceOrder(ServiceOrder order)
        {
            var serviceOrder = _orders.FirstOrDefault((p) => p.Id == order.Id);
            if (serviceOrder == null)
            {
                throw new CityServiceException(500, "Solicitação de Serviço não encontrada! Contactar administrador");
            }
            _orders.Remove(serviceOrder);
            _orders.Add(order);

            return order;
        }

        public void RemoveServiceOrder(ServiceOrder order)
        {
            var serviceOrder = _orders.FirstOrDefault((p) => p.Id == order.Id);
            if (serviceOrder == null)
            {
                throw new CityServiceException(500, "Solicitação de Serviço não encontrada! Contactar administrador.");
            }
            _orders.Remove(serviceOrder);
        }

    }
}
