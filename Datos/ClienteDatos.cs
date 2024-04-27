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
    public class ClienteDatos : Interface1<Cliente>
    {
        Practica05Entities contexto;

        public ClienteDatos()
        {
            contexto = new Practica05Entities();
        }

        //BUSCAR POR ID
        public Cliente BuscarId(int id)
        {
            return contexto.Cliente.Where(P => P.id == id).FirstOrDefault();
        }

        public List<Cliente> Listar()
        {
            return contexto.Cliente.ToList();
        }

        public bool Actualizar(Cliente cliente)
        {
            var clienteExistente = contexto.Cliente.FirstOrDefault(c => c.id == cliente.id);
            if (clienteExistente != null)
            {
                contexto.Entry(clienteExistente).CurrentValues.SetValues(cliente);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(Cliente cliente)
        {
            // Tu lógica actual está correcta
            var clienteExistente = contexto.Cliente.FirstOrDefault(c => c.id == cliente.id);
            if (clienteExistente != null)
            {
                contexto.Cliente.Remove(clienteExistente);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }


        public Cliente Buscar(int id)
        {
            return contexto.Cliente.FirstOrDefault(c => c.id == id);
        }

        public bool Nuevo(Cliente cliente)
        {
            if (contexto.Cliente.Add(cliente) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }

}

