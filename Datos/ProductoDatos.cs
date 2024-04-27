using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos : Interface1<Productos>
    {
        Practica05Entities contexto;

        public ProductoDatos() { 
            contexto = new Practica05Entities();
        }
        public ObjectResult listarClientesCategoria() {
            return contexto.SP_Clientes();
        }
        public Productos BuscarId(int id) {
            return contexto.Productos.Where(P=>P.idProducto==id).FirstOrDefault();
        }
        public List<Productos> Listar()
        {
            return contexto.Productos.ToList();
        }

        public bool Actualizar(Productos item)
        {
            Productos temp = BuscarId(item.idProducto);
            //temp.idProducto = p.idProducto;
            temp.iva = item.iva;
            temp.precio_unitario = item.precio_unitario;
            temp.nombre = item.nombre;
            contexto.SaveChanges();
            return true;
        }

        public bool Nuevo(Productos producto)
        {
            if (contexto.Productos.Add(producto) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Productos item)
        {
            Productos temp = BuscarId(item.idProducto);
            if (temp != null)
            {
                contexto.Productos.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
