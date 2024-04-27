using AccesoDatos;
using System.Collections.Generic;

namespace Datos
{
    public interface IDetalleFacturaDatos<T>
    {
        List<DetalleFactura> Listar();
        DetalleFactura ObtenerPorId(int id);
        bool Crear(DetalleFactura detalleFactura);
        bool Actualizar(int id, DetalleFactura detalleFactura);
        bool Eliminar(int id);
    }
}