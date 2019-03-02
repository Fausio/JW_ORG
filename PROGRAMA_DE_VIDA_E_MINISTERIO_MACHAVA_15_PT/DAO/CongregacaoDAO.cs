using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.AppContext;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.DAO
{
    public class CongregacaoDAO
    {
        public IList<Congregacao> ListaDeCongregacao()
        {
            MACHAVA15Context context = new MACHAVA15Context();
            return context.Congregacao.ToList();
        }
    }
}