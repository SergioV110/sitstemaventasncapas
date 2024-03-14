using SistemaVentas.DAL;
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
    }
}
