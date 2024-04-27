using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.FacturaDatos;

namespace Datos
{
    public class FacturaDatos : Interface1<Factura>
    {
        public Practica05Entities contexto = new Practica05Entities();

        public List<Factura> ListarFacturas()
        {
            return contexto.Factura.ToList();
        }

        public Factura ObtenerFacturaPorNumero(int numeroFactura)
        {
            return contexto.Factura.FirstOrDefault(f => f.numero_factura == numeroFactura);
        }

        public bool CrearFactura(Factura factura)
        {
            contexto.Factura.Add(factura);
            contexto.SaveChanges();
            return true;
        }

        public bool ActualizarFactura(int numeroFactura, Factura factura)
        {
            var facturaExistente = contexto.Factura.FirstOrDefault(f => f.numero_factura == numeroFactura);
            if (facturaExistente != null)
            {
                contexto.Entry(facturaExistente).CurrentValues.SetValues(factura);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EliminarFactura(int numeroFactura)
        {
            var factura = contexto.Factura.FirstOrDefault(f => f.numero_factura == numeroFactura);
            if (factura != null)
            {
                contexto.Factura.Remove(factura);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        // Implementación de la interfaz Interface1<Factura>
        List<Factura> Interface1<Factura>.Listar()
        {
            return ListarFacturas();
        }

        bool Interface1<Factura>.Actualizar(Factura factura)
        {
            return ActualizarFactura(factura.numero_factura, factura);
        }

        bool Interface1<Factura>.Nuevo(Factura factura)
        {
            return CrearFactura(factura);
        }

        bool Interface1<Factura>.Eliminar(Factura factura)
        {
            return EliminarFactura(factura.numero_factura);
        }
    }
}     
