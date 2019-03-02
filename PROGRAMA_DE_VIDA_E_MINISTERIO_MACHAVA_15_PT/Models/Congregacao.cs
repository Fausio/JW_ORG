using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models
{
    public class Congregacao
    {

        public int CongregacaoID { get; set; }

        public string NomeCongregacao { get; set; }

        public List<Pessoa> Pessoas { get; set; }

    }
}