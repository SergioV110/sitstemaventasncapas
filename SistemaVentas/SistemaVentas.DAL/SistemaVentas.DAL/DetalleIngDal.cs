using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngsDal()
        {
            string consulta = "select * from detalleing";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into detalleing values(" + detalleIng.IdIngreso + ","+
                                                         detalleIng.IdProducto + ","+
                                                         "'" + detalleIng.FechaVenc + "'," +
                                                         "'" + detalleIng.Cantidad + "'," +
                                                         "'" + detalleIng.PrecioCosto + "'," +
                                                         "'" + detalleIng.PrecioVenta + "'," +
                                                         "'" + detalleIng.SubTotal + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
