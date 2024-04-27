using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public CategoriaDatos _datos = new CategoriaDatos();

        public List<Categoria> ListarCategorias()
        {
            return _datos.ListarCategorias();
        }

        public Categoria ObtenerCategoriaPorId(int id)
        {
            return _datos.ObtenerCategoriaPorId(id);
        }

        public bool CrearCategoria(Categoria categoria)
        {
            // Aquí puede ir lógica adicional antes de la creación
            return _datos.CrearCategoria(categoria);
        }

        public bool ActualizarCategoria(int id, Categoria categoria)
        {
            // Aquí puede ir lógica adicional antes de la actualización
            return _datos.ActualizarCategoria(id, categoria);
        }

        public bool EliminarCategoria(int id)
        {
            // Aquí puede ir lógica adicional antes de la eliminación
            return _datos.EliminarCategoria(id);
        }
    }
}
