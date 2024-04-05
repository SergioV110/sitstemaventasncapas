using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class RolDal
    {
        Rol rol = new Rol();
        public DataTable ListarRolesDal()
        {
            string consulta = "select * from rol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Rol ObtenerRolIdDal(int idrol)
        {
            string consulta = "select * from rol where idrol=" + idrol;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                rol.IdRol = Convert.ToInt32(table.Rows[0]["idrol"]);
                rol.Nombre = table.Rows[0]["nombre"].ToString();
            }
            return rol;
        }
        public void EditarRolDal(Rol r)
        {
            string consulta = "update rol set nombre='" + r.Nombre + "'" +
                                                "where idrol=" + r.IdRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarRolDal(int idrol)
        {
            string consulta = "delete from rol where idrol=" + idrol;
            conexion.Ejecutar(consulta);
        }
    }
}
