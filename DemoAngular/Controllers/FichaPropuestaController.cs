using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoAngular.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAngular.Controllers
{
    //[Route("api/[controller]")]
    public class FichaPropuestaController : Controller
    {
        FichaPropuestaDataAccesLayer objfprpuesta = new FichaPropuestaDataAccesLayer();

        // GET: api/<controller>
        [HttpGet("[action]")]
        [Route("api/Pedido/ListadoPropuesta")]
        public IEnumerable<FichaPropuesta> Get()
        {
            //return new string[] { "value1", "value2" };
                return objfprpuesta.ObtenerListadoPropuesta();
        }

        [HttpGet("[action]")]
        [Route("api/Pedido/DetallePropuesta/{NroPedido}/{NroPropuesta}")]
        public IEnumerable<FichaPropuesta> Propuesta_Detalle(int nroPedido,int nroPropuesta) {

            return objfprpuesta.ObtenerDetallePropuesta(nroPedido, nroPropuesta);

        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
