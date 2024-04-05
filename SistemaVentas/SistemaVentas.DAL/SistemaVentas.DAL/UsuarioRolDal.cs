using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolesDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario + "," +
                                                        ""+ usuarioRol.IdRol + "," +
                                                         "'" + usuarioRol.FechaAsigna + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "SELECT * FROM usuariorol WHERE idusuariorol = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            UsuarioRol usuariorol = new UsuarioRol();
            if (tabla.Rows.Count > 0)
            {
                usuariorol.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                usuariorol.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                usuariorol.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                usuariorol.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
            }
            return usuariorol;
        }

        public void EditarUsuarioRolDal(UsuarioRol ur)
        {
            string consulta = "UPDATE usuariorol SET idusuario = " + ur.IdUsuario.ToString() + ", idrol = " + ur.IdRol.ToString() + ", fechaasigna = " + ur.FechaAsigna.ToString()  + " WHERE idusuariorol = " + ur.IdUsuarioRol.ToString();
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioRolDal(int idusuariorol)
        {
            string consulta = "DELETE FROM usuariorol WHERE idusuariorol = " + idusuariorol;
            conexion.Ejecutar(consulta);
        }


        public DataTable UsurioRolDatosDal()
        {
            string consulta = "SELECT USUARIOROL.IDUSUARIOROL, USUARIO.NOMBREUSER, ROL.NOMBRE, USUARIOROL.FECHAASIGNA, ROL.ESTADO " +
                "    FROM     USUARIOROL INNER JOIN " +
                "    USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN " +
                "    ROL ON USUARIOROL.IDROL = ROL.IDROL ";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
