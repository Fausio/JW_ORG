using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PROGRAMA_DE_VIDA_E_MINISTERIO_MACHAVA_15_PT.Models
{
    public class Tempo
    {

        [Required]
        public DateTime Time { get; set; }
    }
}