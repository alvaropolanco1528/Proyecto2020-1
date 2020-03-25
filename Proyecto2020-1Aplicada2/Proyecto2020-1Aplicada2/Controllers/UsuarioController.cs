using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto2020_1Aplicada2.Data;
using Proyecto2020_1Aplicada2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;



namespace Proyecto2020_1Aplicada2.Controllers
{
    public class UsuarioController
    {
        public bool Guardar(Usuario usuario)
        {
            GranjaContexto contexto = new GranjaContexto();
            bool paso = false;
            try
            {
                if (usuario.UsuarioId == 0)
                {
                    paso = Insertar(usuario);
                }
                else
                {
                    paso = Modificar(usuario);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        private bool Insertar(Usuario usuario)
        {
            GranjaContexto contexto = new GranjaContexto();
            bool paso = false;
            try
            {
                contexto.Usuario.Add(usuario);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        private bool Modificar(Usuario usuario)
        {
            GranjaContexto contexto = new GranjaContexto();
            bool paso = false;
            try
            {
                contexto.Usuario.Add(usuario);
                contexto.Entry(usuario).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Usuario Buscar(int id)
        {
            GranjaContexto contexto = new GranjaContexto();
            Usuario usuario = new Usuario();
            try
            {
                usuario = contexto.Usuario.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }
        public bool Eliminar(int id)
        {
            GranjaContexto contexto = new GranjaContexto();
            bool paso = false;
            Usuario usuario = new Usuario();

            try
            {
                usuario = contexto.Usuario.Find(id);
                contexto.Entry(usuario).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public List<Usuario> GetList(Expression<Func<Usuario, bool>> expression)
        {
            GranjaContexto contexto = new GranjaContexto();
            List<Usuario> lista;
            try
            {
                lista = contexto.Usuario.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}

