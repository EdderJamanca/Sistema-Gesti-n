using Microsoft.EntityFrameworkCore;
using SistemaGestionData.Context;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.DataAccess
{
    public class UsuarioDataAccess
    {
        private readonly SistemaGestionContext _context;

        public UsuarioDataAccess(SistemaGestionContext context)
        {
            _context = context;
        }

        public  List<Usuario> GetAllUsuario()
        {

            return _context.Usuarios.ToList();
        }

        public  void createUsuario(Usuario usuario)
        {

                if (usuario != null)
                {
                    _context.Usuarios.Add(usuario);
                    _context.SaveChanges();
                }
                else
                {
                    // Manejar el caso en que el usuario sea null
                    throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser null.");
                }
            
        }
        public  Usuario ObtenerUsuario(int idusuario)
        {
            try
            {

                    Usuario usuario = _context.Usuarios.FirstOrDefault(p => p.Id == idusuario);
                    return usuario;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public  void modificarUsuario(Usuario usuario)
        {
            try
            {

                    int Id = usuario.Id;
                    Usuario usuarioActual = _context.Usuarios.Find(Id);
                    if (usuarioActual != null)
                    {
                        usuarioActual.Nombre = usuario.Nombre;
                        usuarioActual.Apellido = usuario.Apellido;
                        usuarioActual.NombreUsuario = usuario.NombreUsuario;

                        _context.SaveChanges();
                    }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public  void DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges(); // Guardar cambios en la base de datos
            }
        }
    }
}
