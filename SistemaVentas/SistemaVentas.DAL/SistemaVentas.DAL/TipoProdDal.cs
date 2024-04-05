using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class TipoProdDal
    {
        TipoProd tipoprod = new TipoProd();
        public DataTable ListarTipoProdsDal()
        {
            string consulta = "select * from tipoprod";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "insert into tipoprod values('" + tipoProd.Nombre + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public TipoProd ObtenerTipoProdIdDal(int idtipoprod)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + idtipoprod;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                tipoprod.IdTipoProd = Convert.ToInt32(table.Rows[0]["idtipoprod"]);
                tipoprod.Nombre = table.Rows[0]["nombre"].ToString();
            }
            return tipoprod;
        }
        public void EditarTipoProdDal(TipoProd tp)
        {
            string consulta = "update tipoprod set nombre='" + tp.Nombre + "'" +
                                                "where idtipoprod=" + tp.IdTipoProd;
            conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int idtipoprod)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + idtipoprod;
            conexion.Ejecutar(consulta);
        }
    }
}
