using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ClienteDal
    {
        Cliente cliente = new Cliente();
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values("+cliente.IdPersona+ ","+
                                                         "'" + cliente.TipoCliente + "'," +
                                                         "'" + cliente.CodigoCliente + "'," +                                                        
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(table.Rows[0]["idcliente"]);
                cliente.IdPersona = Convert.ToInt32(table.Rows[0]["idpersona"]);
                cliente.CodigoCliente = table.Rows[0]["codigocliente"].ToString();
            }
            return cliente;
        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set idpersona='" + c.IdPersona + "'," +
                                                        "tipocliente='"+ c.TipoCliente + "'," +
                                                        "codigocliente='" + c.CodigoCliente + "'" +
                                                "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int idcliente)
        {
            string consulta = "delete from cliente where idcliente=" + idcliente;
            conexion.Ejecutar(consulta);
        }
        public DataTable ClienteDatosDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE+''+ PERSONA.APELLIDO)NOMBRE_COMPLETO, CLIENTE.TIPOCLIENTE," +
                " CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO" +
                " FROM     CLIENTE " +
                "         INNER JOIN " +
                "         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
