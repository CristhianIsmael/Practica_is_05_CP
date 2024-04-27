using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using AccesoDatos;
using System.Web.Http;
namespace APIREST.Controllers
{
    public class CategoriaController : ApiController
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public IHttpActionResult Get()
        {
            var categorias = categoriaNegocio.ListarCategorias();
            return Ok(categorias);
        }

        public IHttpActionResult Get(int id)
        {
            var categoria = categoriaNegocio.ObtenerCategoriaPorId(id);
            if (categoria != null)
                return Ok(categoria);
            else
                return NotFound();
        }

        public IHttpActionResult Post([FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var creado = categoriaNegocio.CrearCategoria(categoria);
            if (creado)
                return Ok("Categoría creada correctamente");
            else
                return BadRequest("No se pudo crear la categoría");
        }

        public IHttpActionResult Put(int id, [FromBody] Categoria categoria)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var actualizado = categoriaNegocio.ActualizarCategoria(id, categoria);
            if (actualizado)
                return Ok("Categoría actualizada correctamente");
            else
                return NotFound();
        }

        public IHttpActionResult Delete(int id)
        {
            var eliminado = categoriaNegocio.EliminarCategoria(id);
            if (eliminado)
                return Ok("Categoría eliminada correctamente");
            else
                return NotFound();
        }
    }
}