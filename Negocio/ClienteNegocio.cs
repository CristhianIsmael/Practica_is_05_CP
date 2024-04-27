using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        ClienteDatos clienteDatos = new ClienteDatos();

        // Método para obtener todos los clientes
        public List<Cliente> All()
        {
            return clienteDatos.Listar();
        }

        // Método para obtener un cliente por ID
        public Cliente ById(int id)
        {
            return clienteDatos.Buscar(id);
        }

        // Método para insertar un nuevo cliente
        public void InsertarCliente(Cliente cliente)
        {
            // Aquí puedes incluir cualquier lógica de negocio antes de la inserción
            clienteDatos.Nuevo(cliente);
        }

        // Método para actualizar un cliente existente
        public bool Update(int id, Cliente cliente)
        {
            // Verificar que el cliente existe
            Cliente clienteExistente = clienteDatos.Buscar(id);
            if (clienteExistente != null)
            {
                // Aquí puedes incluir cualquier lógica de negocio antes de la actualización
                return clienteDatos.Actualizar(cliente);
            }
            return false;
        }

        // Método para eliminar un cliente
        public bool Delete(int id)
{
    // Verificar que el cliente existe
    Cliente clienteExistente = clienteDatos.Buscar(id); // Usar el método Buscar para obtener el cliente
    if (clienteExistente != null)
    {
        // Aquí puedes incluir cualquier lógica de negocio antes de la eliminación
        return clienteDatos.Eliminar(clienteExistente); // Pasar el objeto clienteExistente, no el ID
    }
    return false;
}

    }
}

