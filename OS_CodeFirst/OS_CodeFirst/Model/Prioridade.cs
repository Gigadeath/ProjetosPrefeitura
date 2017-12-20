using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class Prioridade
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da Prioridade e obrigatório", AllowEmptyStrings = false)]
        public string Nivel { get; set; }
        [Required(ErrorMessage = "Status da Prioridade é obrigatório", AllowEmptyStrings = false)]
        public bool status { get; set; }


        public virtual ICollection<OS> OS{ get; set;}

       /* public Prioridade()
        {
            this.OS = new HashSet<OS>();
        }*/
    }
}
