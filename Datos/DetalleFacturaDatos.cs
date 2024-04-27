using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class DetalleFacturaDatos : IDetalleFacturaDatos<DetalleFactura>
    {
        public Practica05Entities _contexto = new Practica05Entities();
        public List<DetalleFactura> Listar()
        {
            return _contexto.DetalleFactura.ToList();
        }

        public DetalleFactura ObtenerPorId(int id)
        {
            return _contexto.DetalleFactura.FirstOrDefault(df => df.id == id);
        }

        public bool Crear(DetalleFactura detalleFactura)
        {
            _contexto.DetalleFactura.Add(detalleFactura);
            _contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(int id, DetalleFactura detalleFactura)
        {
            var detalleExistente = _contexto.DetalleFactura.Find(id);
            if (detalleExistente != null)
            {
                _contexto.Entry(detalleExistente).CurrentValues.SetValues(detalleFactura);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var detalle = _contexto.DetalleFactura.Find(id);
            if (detalle != null)
            {
                _contexto.DetalleFactura.Remove(detalle);
                _contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ExisteFactura(int idFactura)
        {
            return _contexto.Factura.Any(f => f.numero_factura == idFactura);
        }

        public bool ExisteProducto(int idProducto)
        {
            return _contexto.Productos.Any(p => p.idProducto == idProducto);
        }

        public DetalleFactura ObtenerDetallePorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteFactura(int? idFactura)
        {
            throw new NotImplementedException();
        }

        public bool ExisteProducto(int? idProducto)
        {
            throw new NotImplementedException();
        }
    }
}
