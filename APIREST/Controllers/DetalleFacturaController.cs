using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace APIREST.Controllers
{
    public class DetalleFacturaController : ApiController
    {
            public DetalleFacturaNegocio _negocio = new DetalleFacturaNegocio();

            // GET: api/DetalleFacturas
            public IHttpActionResult Get()
            {
                var detalles = _negocio.ListarDetalles();
                return Ok(detalles);
            }

            // GET: api/DetalleFacturas/5
            public IHttpActionResult Get(int id)
            {
                var detalle = _negocio.ObtenerDetallePorId(id);
                if (detalle != null)
                    return Ok(detalle);
                else
                    return NotFound();
            }

            // POST: api/DetalleFacturas
            public IHttpActionResult Post([FromBody] DetalleFactura detalle)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var creado = _negocio.CrearDetalle(detalle);
                if (creado)
                    return CreatedAtRoute("DefaultApi", new { id = detalle.id }, detalle);
                else
                    return BadRequest("No se pudo crear el detalle de factura.");
            }

            // PUT: api/DetalleFacturas/5
            public IHttpActionResult Put(int id, [FromBody] DetalleFactura detalle)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var actualizado = _negocio.ActualizarDetalle(id, detalle);
                if (actualizado)
                    return StatusCode(HttpStatusCode.NoContent);
                else
                    return NotFound();
            }

            // DELETE: api/DetalleFacturas/5
            public IHttpActionResult Delete(int id)
            {
                var eliminado = _negocio.EliminarDetalle(id);
                if (eliminado)
                    return Ok();
                else
                    return NotFound();
            }
        }
    }