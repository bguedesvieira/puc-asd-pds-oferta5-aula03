using CityServicesApi.Dto.v1;
using CityServicesApi.Models;
using CityServicesApi.ApiException;
using CityServicesApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    [RoutePrefix("api/{folder}/servicos")]
    public class ServiceOrdersController : ApiController
    {
        private ServiceOrderRepository _serviceOrderRepository = new ServiceOrderRepository();
        private PublicPlaceRepository _publicPlaceRepository = new PublicPlaceRepository();

        public IEnumerable<ServiceOrder> GetAllServiceOrders()
        {
            return _serviceOrderRepository.GetAllServiceOrders();
        }

        public IHttpActionResult GetServiceOrder(int id)
        {
            var order = _serviceOrderRepository.GetServiceOrder(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        [Route("podaarvore")]
        public IHttpActionResult OrderTreePruning(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.PodaArvore, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("construcaomeiofio")]
        public IHttpActionResult OrderWalkWayCurbBuilding(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.MeioFio, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("recolhimentocarro")]
        public IHttpActionResult OrderCarRemoving(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.RecolhimentoCarro, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("desobstrucaovia")]
        public IHttpActionResult OrderRoadCleanning(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.DesobstrucaoViaPublica, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("desobstrucaocorrego")]
        public IHttpActionResult OrderWatercourseCleanning(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.DesobstrucaoCorrego, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("coletaanimal")]
        public IHttpActionResult OrderDeadAnimalRemoving(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.ColetaAnimal, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("limpezabocalobo")]
        public IHttpActionResult OrderWastepipeCleanning(ServiceOrderRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.PublicPlaceId))
                {
                    return BadRequest("Parâmetro 'logradouro' inválido!");
                }


                ServiceOrder order = GenerateServiceOrder(ServiceOrderType.MeioFio, request.PublicPlaceId);
                order = _serviceOrderRepository.AddServiceOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado! Entre em contato com o administrador do sistema."));
            }
        }


        [NonAction]
        private ServiceOrder GenerateServiceOrder(ServiceOrderType type, int PublicPlaceId)
        {
            ServiceOrder order = new ServiceOrder();
            
            order.OrderDate = DateTime.Now;
            order.Type = type;

            PublicPlace place = _publicPlaceRepository.GetPublicPlace(PublicPlaceId);
            if (place == null)
            {
                throw new CityServiceException(500,"Parametro 'logradouro' inválido");
            }

            order.Place = place;

            return order;
        }

    }
}
