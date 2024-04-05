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
    public class TipoProdBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ListarTipoProdBss()
        {
            return dal.ListarTipoProdsDal();
        }
        public void InsertarTipoProdBss(TipoProd tipoProd)
        {
            dal.InsertarTipoProdDal(tipoProd);
        }
        public TipoProd ObtenerTipoProdIdBss(int idtipoprod)
        {
            return dal.ObtenerTipoProdIdDal(idtipoprod);
        }
        public void EditarTipoProdBss(TipoProd tp)
        {
            dal.EditarTipoProdDal(tp);
        }
        public void EliminarTipoProdBss(int idtipoprod)
        {
            dal.EliminarTipoProdDal(idtipoprod);
        }
    }
}
