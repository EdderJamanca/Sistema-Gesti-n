﻿using SistemaGestionData.DataAccess;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.Services
{
    public class UsuariosService
    {
        private UsuarioDataAccess _usuarioDataAccess;

        public UsuariosService(UsuarioDataAccess usuarioDataAccess)
        {
            _usuarioDataAccess = usuarioDataAccess;
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioDataAccess.GetAllUsuario();
        }
        public Usuario? GetOneUsuario(int id)
        {
            return _usuarioDataAccess.ObtenerUsuario(id);
        }
        public void CreateUsuario(Usuario usuario)
        {
            _usuarioDataAccess.createUsuario(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _usuarioDataAccess.modificarUsuario(usuario);
        }
        public void DeleteUsuario(int id)
        {
            _usuarioDataAccess.DeleteUsuario(id);
        }
    }
}
