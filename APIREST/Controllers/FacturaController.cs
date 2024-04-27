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
    public class FacturaController : ApiController
    {
        public class DetalleFacturasController : ApiController
        {
            public DetalleFacturaNegocio _negocio = new DetalleFacturaNegocio();

            public IHttpActionResult Get()
            {
                return Ok(_negocio.ListarDetalles());
            }

            public IHttpActionResult Get(int id)
            {
                var detalle = _negocio.ObtenerDetallePorId(id);
                return detalle != null ? Ok(detalle) : (IHttpActionResult)NotFound();
            }

            public IHttpActionResult Post([FromBody] DetalleFactura detalle)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var creado = _negocio.CrearDetalle(detalle);
                return creado ? (IHttpActionResult)Ok("Detalle creado con éxito.") : BadRequest("No se pudo crear el detalle.");
            }

            public IHttpActionResult Put(int id, [FromBody] DetalleFactura detalle)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var actualizado = _negocio.ActualizarDetalle(id, detalle);
                return actualizado ? (IHttpActionResult)Ok("Detalle actualizado con éxito.") : NotFound();
            }

            public IHttpActionResult Delete(int id)
            {
                var eliminado = _negocio.EliminarDetalle(id);
                return eliminado ? (IHttpActionResult)Ok("Detalle eliminado con éxito.") : NotFound();
            }
        }
    }
}