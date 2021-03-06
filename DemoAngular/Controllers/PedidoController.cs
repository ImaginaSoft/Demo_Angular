﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoAngular.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAngular.Controllers
{
    //[Route("api/[controller]")]
    public class PedidoController : Controller
    {

        PedidoDataAccessLayer objPedido = new PedidoDataAccessLayer();

        // GET: api/<controller>
        [HttpGet("[action]")]
        [Route("api/Pedido/Index")]
        public IEnumerable<Pedido> Get()
        {
            //return new string[] { "value1", "value2" };
            return objPedido.ObtenerListadoPedido();
        }

        //// GET api/<controller>/5
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
