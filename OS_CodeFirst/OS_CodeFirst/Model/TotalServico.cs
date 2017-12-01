using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OS_CodeFirst.Model
{
    public class TotalServico
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "As horas da OS é obrigatório", AllowEmptyStrings = false)]
        public int totalHoras { get; set; }
        [Required(ErrorMessage = "A data limite da OS é obrigatório", AllowEmptyStrings = false)]
        public DateTime DataLimite { get; set; }

        public int OS_id { get; set; }

        [ForeignKey("OS_id")]
        public OS OS { get; set; }
    }
}
