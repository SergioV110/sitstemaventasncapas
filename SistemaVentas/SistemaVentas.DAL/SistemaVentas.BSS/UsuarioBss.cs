﻿using SistemaVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class UsuarioBss
    {
        UsuarioDal dal = new UsuarioDal();
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuariosDal();
        }
        public void InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }
        public Usuario ObtenerUsuarioIdBss(int idusuario)
        {
            return dal.ObtenerUsuarioIdDal(idusuario);
        }
        public void EditarUsuarioBss(Usuario u)
        {
            dal.EditarUsuarioDal(u);
        }
        public void EliminarUsuarioBss(int idusuario)
        {
            dal.EliminarUsuarioDal(idusuario);
        }
        public DataTable UsuarioDatosBss() 
        {
            return dal.UsurioDatosDal();
        }
    }
}
