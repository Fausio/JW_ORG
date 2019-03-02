using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }

        public string Nome { get; set; }

        public virtual Estado Estado { get; set; }
        public int? EstadoID { get; set; }

        public virtual Congregacao Congregacao { get; set; }
        public int? CongregacaoID { get; set; }


    }
}