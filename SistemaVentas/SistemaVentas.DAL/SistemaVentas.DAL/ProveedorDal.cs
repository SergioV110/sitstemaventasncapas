using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ProveedorDal
    {
        Proveedor proveedor = new Proveedor();
        public DataTable ListarProveedoresDal()
        {
            string consulta = "select * from proveedor";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                         "'" + proveedor.Telefono + "'," +
                                                         "'" + proveedor.Direccion + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Proveedor ObtenerProveedorIdDal(int idproveedor)
        {
            string consulta = "select * from proveedor where idproveedor=" + idproveedor;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                proveedor.IdProveedor = Convert.ToInt32(table.Rows[0]["idproveedor"]);
                proveedor.Nombre = table.Rows[0]["nombre"].ToString();
                proveedor.Telefono = table.Rows[0]["telefono"].ToString();
                proveedor.Direccion = table.Rows[0]["direccion"].ToString();
            }
            return proveedor;
        }
        public void EditarProveedorDal(Proveedor p)
        {
            string consulta = "update proveedor set nombre='" + p.Nombre + "'," +
                                                "telefono='" + p.Telefono + "'," +
                                                "direccion='" + p.Direccion + "'"+
                                                "where idproveedor=" + p.IdProveedor;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProveedorDal(int idproveedor)
        {
            string consulta = "delete from proveedor where idproveedor=" + idproveedor;
            conexion.Ejecutar(consulta);
        }
    }
}
