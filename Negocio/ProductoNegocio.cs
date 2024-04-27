using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        ProductoDatos productos;
        public ProductoNegocio()
        {
            productos = new ProductoDatos();
        }
        public List<Productos> All()
        {
            return productos.Listar();
        }
        public Productos ById(int id)
        {
            return productos.Listar().Where(p => p.idProducto == id).SingleOrDefault();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool insertarProducto(Productos productoNuevo)
        {
            return productos.Nuevo(productoNuevo);
        }

        public bool Update(int id, Productos producto)
        {
            throw new NotImplementedException();
        }
    }
}
