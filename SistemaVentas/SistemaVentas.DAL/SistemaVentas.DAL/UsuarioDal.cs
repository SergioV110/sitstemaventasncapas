using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class UsuarioDal
    {
        Usuario usuario = new Usuario();
        public DataTable ListarUsuariosDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + "," +
                                                         "'" + usuario.NombreUser + "'," +
                                                         "'" + usuario.Contraseña + "'," +
                                                         "'" + usuario.FechaReg +"')";
            conexion.Ejecutar(consulta);
        }
        public Usuario ObtenerUsuarioIdDal(int idusuario)
        {
            string consulta = "select * from usuario where idusuario=" + idusuario;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                usuario.IdUsuario = Convert.ToInt32(table.Rows[0]["idusuario"]);
                usuario.IdPersona = Convert.ToInt32(table.Rows[0]["idpersona"]);
                usuario.NombreUser = table.Rows[0]["nombreuser"].ToString();
                usuario.Contraseña = table.Rows[0]["contraseña"].ToString();
                usuario.FechaReg = Convert.ToDateTime(table.Rows[0]["fechareg"].ToString());
            }
            return usuario;
        }
        public void EditarUsuarioDal(Usuario u)
        {
            string consulta = "update usuario set idpersona='" + u.IdPersona + "'," +
                                                        "nombreuser='" + u.NombreUser + "'," +
                                                        "contraseña='" + u.Contraseña + "'," +
                                                        "fechareg='" + u.FechaReg + "'" +
                                                "where idusuario=" + u.IdUsuario;
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioDal(int idusuario)
        {
            string consulta = "delete from usuario where idusuario=" + idusuario;
            conexion.Ejecutar(consulta);
        }
        public DataTable UsurioDatosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' '+ PERSONA.APELLIDO) NOMBRECOMPLETO, USUARIO.NOMBREUSER, " +
                              " ROL.NOMBRE AS NOMBREROL, USUARIOROL.FECHAASIGNA " +
                              "FROM     PERSONA INNER JOIN " +
                              "            USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN      " +
                              "            USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN      " +
                              "            ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
