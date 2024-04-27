using AccesoDatos;
using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class DetalleFacturaNegocio
    {
        private DetalleFacturaDatos _datos = new DetalleFacturaDatos();

        public List<DetalleFactura> ListarDetalles()
        {
            // Agregar aquí lógica adicional si es necesario, como filtrar los detalles.
            return _datos.Listar();
        }

        public DetalleFactura ObtenerDetallePorId(int id)
        {
            // Agregar lógica de negocio antes de obtener el detalle si es necesario.
            return _datos.ObtenerPorId(id);
        }

        public bool CrearDetalle(DetalleFactura detalle)
        {
            // Verificar la existencia de factura y producto antes de crear el detalle.
            if (!_datos.ExisteFactura(detalle.idFactura) || !_datos.ExisteProducto(detalle.idProducto))
            {
                // Manejar el error si la factura o el producto no existen.
                return false;
            }

            // Crear el detalle de la factura.
            return _datos.Crear(detalle);
        }

        public bool ActualizarDetalle(int id, DetalleFactura detalle)
        {
            return _datos.Actualizar(id, detalle);
        }

        public bool EliminarDetalle(int id)
        {
            // Validar que el detalle a eliminar existe.
            var detalleExistente = ObtenerDetallePorId(id);
            if (detalleExistente == null)
            {
                // Manejar el error si el detalle no existe.
                return false;
            }

            // Eliminar el detalle.
            return _datos.Eliminar(id);
        }
    }
}
