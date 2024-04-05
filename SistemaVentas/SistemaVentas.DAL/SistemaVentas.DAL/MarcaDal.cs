using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class MarcaDal
    {
        Marca marca = new Marca();
        public DataTable ListarMarcasDal()
        {
            string consulta = "select * from marca";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Marca ObtenerMarcaIdDal(int idmarca)
        {
            string consulta = "select * from marca where idmarca=" + idmarca;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(table.Rows[0]["idmarca"]);
                marca.Nombre = table.Rows[0]["nombre"].ToString();
            }
            return marca;
        }
        public void EditarMarcaDal(Marca m)
        {
            string consulta = "update marca set nombre='" + m.Nombre + "'" +
                                                "where idmarca=" + m.IdMarca;
            conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int idmarca)
        {
            string consulta = "delete from marca where idmarca=" + idmarca;
            conexion.Ejecutar(consulta);
        }
    }
}
