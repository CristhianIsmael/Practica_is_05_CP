using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDatos : Interface1<Categoria>
    {
        public Practica05Entities _context = new Practica05Entities();

        public List<Categoria> ListarCategorias()
        {
            return _context.Categoria.ToList();
        }

        public Categoria ObtenerCategoriaPorId(int id)
        {
            return _context.Categoria.FirstOrDefault(c => c.id == id);
        }

        public bool CrearCategoria(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return true;
        }

        public bool ActualizarCategoria(int id, Categoria categoria)
        {
            var categoriaExistente = _context.Categoria.FirstOrDefault(c => c.id == id);
            if (categoriaExistente != null)
            {
                _context.Entry(categoriaExistente).CurrentValues.SetValues(categoria);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EliminarCategoria(int id)
        {
            var categoria = _context.Categoria.Find(id);
            if (categoria != null)
            {
                _context.Categoria.Remove(categoria);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        List<Categoria> Interface1<Categoria>.Listar()
        {
            throw new NotImplementedException();
        }

        bool Interface1<Categoria>.Actualizar(Categoria item)
        {
            throw new NotImplementedException();
        }

        bool Interface1<Categoria>.Nuevo(Categoria item)
        {
            throw new NotImplementedException();
        }

        bool Interface1<Categoria>.Eliminar(Categoria item)
        {
            throw new NotImplementedException();
        }
    }
}
