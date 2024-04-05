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
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClientesDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteIdDal(id);
        }
        public void EditarClienteBss(Cliente c)
        {
            dal.EditarClienteDal(c);
        }
        public void EliminarClienteBss(int idcliente)
        {
            dal.EliminarClienteDal(idcliente);
        }
        public DataTable ClienteDatosBss()
        {
            return dal.ClienteDatosDal();
        }
    }
}
