using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.AppContext;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO
{
    public class EstadosDao
    {
        MACHAVA15Context contexto = new MACHAVA15Context();

        public IList<Estado> EstadoLista()
        {
            return contexto.Estado.ToList();
        }
    }
}