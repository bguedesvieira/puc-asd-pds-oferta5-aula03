using CityServicesApi.Models;
using CityServicesApi.ApiException;
using CityServicesApi.Dto.v1;
using CityServicesApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CityServicesApi.Controllers.v1
{
    [RoutePrefix("api/{folder}/adocaopet")]
    public class PetAdoptionOrdersController : ApiController
    {
        private PetAdoptionOrderRepository _petAdoptionOrderRepository = new PetAdoptionOrderRepository();

        // GET: api/v1/DogAdoptionOrders
        public IEnumerable<PetAdoptionOrder> Get()
        {
            return _petAdoptionOrderRepository.GetAllPetAdoptionOrder();
        }

        // GET: api/DogAdoptionOrders/5
        public IHttpActionResult Get(int id)
        {
            var adoption = _petAdoptionOrderRepository.GetPetAdoptionOrder(id);
            if (adoption == null)
            {
                return NotFound();
            }
            return Ok(adoption);
        }

        [HttpPost]
        [Route("cachorro")]
        public IHttpActionResult OrderDogAdoption(PetAdoptionRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.Cpf) || "".Equals(request.Adress) || "".Equals(request.Name) 
                    || "".Equals(request.PetName) || "".Equals(request.PostalCode))
                {
                    return BadRequest("Parâmetros inválidos!");
                }


                PetAdoptionOrder order = GeneratePetAdoptionOrder(PetType.Dog, request);
                order = _petAdoptionOrderRepository.AddPetAdoptionOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado ao incluir solicitação de adoção de Cachorro! Entre em contato com o administrador do sistema."));
            }
        }

        [HttpPost]
        [Route("gato")]
        public IHttpActionResult OrderCatAdoption(PetAdoptionRequest request)
        {
            try
            {
                if (request == null || "".Equals(request.Cpf) || "".Equals(request.Adress) || "".Equals(request.Name)
                    || "".Equals(request.PetName) || "".Equals(request.PostalCode))
                {
                    return BadRequest("Parâmetros inválidos!");
                }


                PetAdoptionOrder order = GeneratePetAdoptionOrder(PetType.Cat, request);
                order = _petAdoptionOrderRepository.AddPetAdoptionOrder(order);
                return Ok(order);
            }
            catch (Exception e)
            {
                return InternalServerError(new CityServiceException(500, "Ocorreu um erro inesperado ao incluir solicitação de adoção de Gato! Entre em contato com o administrador do sistema."));
            }
        }

        [NonAction]
        private PetAdoptionOrder GeneratePetAdoptionOrder(PetType type, PetAdoptionRequest request)
        {
            PetAdoptionOrder order = new PetAdoptionOrder();

            order.OrderDate = DateTime.Now;
            order.Type = type;
            order.PetName = request.PetName;
            order.Cpf = request.Cpf;
            order.Adress = request.Adress;
            order.Name = request.Name;
            
            return order;
        }
    }
}
