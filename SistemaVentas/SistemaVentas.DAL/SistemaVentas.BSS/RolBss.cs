using SistemaVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolesDal();
        }
        public void InsertarRolBss(Rol rol)
        {
            dal.InsertarRolDal(rol);
        }
        public Rol ObtenerRolIdBss(int idrol)
        {
            return dal.ObtenerRolIdDal(idrol);
        }
        public void EditarRolBss(Rol r)
        {
            dal.EditarRolDal(r);
        }
        public void EliminarRolBss(int idrol)
        {
            dal.EliminarRolDal(idrol);
        }

    }
}
