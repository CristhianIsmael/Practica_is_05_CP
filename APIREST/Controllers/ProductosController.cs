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
    public class ProductosController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();

        // get
        public IHttpActionResult Get() {
            var respuesta = productoNegocio.All();
            return Ok(respuesta);
        }
        public IHttpActionResult Get(int id) { 
            Productos respuesta = productoNegocio.ById(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }
        public IHttpActionResult Post(Productos productos) { 
            productoNegocio.insertarProducto(productos);
            return Ok("Insertado correctamente");
        }

        // Para actualizar un producto
        public IHttpActionResult Put(int id, [FromBody] Productos producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultado = productoNegocio.Update(id, producto);
            if (resultado)
            {
                return Ok("Actualizado correctamente");
            }
            else
            {
                return NotFound();
            }
        }

        // Para eliminar un producto
        public IHttpActionResult Delete(int id)
        {
            var resultado = productoNegocio.Delete(id);
            if (resultado)
            {
                return Ok("Eliminado correctamente");
            }
            else
            {
                return NotFound();
            }
        }

    }
}