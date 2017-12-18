using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class Dep_Func
    {
        [Key]
        public int Id { get; set; }

        public Int32 Funcionario_Id { get; set; }
        public Int32 Departamento_Id { get; set; }

        [ForeignKey("Funcionario_Id")]
        public Funcionario Funcionario { get; set; }
        [ForeignKey("Departamento_Id")]
        public Departamento Departamento { get; set; }
    }
}
