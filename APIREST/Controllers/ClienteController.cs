using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace APIREST.Controllers
{
    public class ClienteController : ApiController
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();

        // GET: api/Clientes
        public IHttpActionResult Get()
        {
            var respuesta = clienteNegocio.All();
            return Ok(respuesta);
        }

        // GET: api/Clientes/5
        public IHttpActionResult Get(int id)
        {
            Cliente respuesta = clienteNegocio.ById(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST: api/Clientes
        public IHttpActionResult Post([FromBody] Cliente cliente)
        {
            clienteNegocio.InsertarCliente(cliente);
            return Ok("Cliente insertado correctamente");
        }

        // PUT: api/Clientes/5
        public IHttpActionResult Put(int id, [FromBody] Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultado = clienteNegocio.Update(id, cliente);
            if (resultado)
            {
                return Ok("Cliente actualizado correctamente");
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE: api/Clientes/5
        public IHttpActionResult Delete(int id)
        {
            var resultado = clienteNegocio.Delete(id);
            if (resultado)
            {
                return Ok("Cliente eliminado correctamente");
            }
            else
            {
                return NotFound();
            }
        }
    }
}