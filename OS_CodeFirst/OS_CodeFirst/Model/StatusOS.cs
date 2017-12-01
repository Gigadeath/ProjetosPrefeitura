using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class StatusOS
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "A descrição do Status da OS é obrigatório", AllowEmptyStrings = false)]
        public string Descricao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int OS_Id { get; set; }
        public int Status_Id { get; set; }

        [ForeignKey("OS_Id")]
        public OS OS { get; set; }

        [ForeignKey("Status_Id")]
        public Status Status { get; set; }
    }
}
