using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FacturaNegocio
    {
        public FacturaDatos _facturaDatos = new FacturaDatos(); // Utiliza FacturaDatos

        public List<Factura> ListarFacturas()
        {
            return _facturaDatos.ListarFacturas(); // Llama a FacturaDatos
        }

        public Factura ObtenerFacturaPorNumero(int numeroFactura)
        {
            return _facturaDatos.ObtenerFacturaPorNumero(numeroFactura); // Llama a FacturaDatos
        }

        public bool CrearFactura(Factura factura)
        {
            // Aquí puedes agregar lógica adicional de validación o procesamiento previo
            return _facturaDatos.CrearFactura(factura); // Llama a FacturaDatos
        }

        public bool ActualizarFactura(int numeroFactura, Factura factura)
        {
            // Aquí puedes agregar lógica adicional de validación o procesamiento previo
            return _facturaDatos.ActualizarFactura(numeroFactura, factura); // Llama a FacturaDatos
        }

        public bool EliminarFactura(int numeroFactura)
        {
            // Aquí puedes agregar lógica adicional de validación o procesamiento previo
            return _facturaDatos.EliminarFactura(numeroFactura); // Llama a FacturaDatos
        }
    }
}
