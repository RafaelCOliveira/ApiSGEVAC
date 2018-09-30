using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSGEVAC.Models
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        [Required(ErrorMessage="O Cargo é obrigatório")]
        public int IdCargo { get; set; }
        public virtual Cargo Cargo { get; set; }
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public DateTime DtNascimento { get; set; }
        public string RG { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage="A CPF é obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "CPF do funcionário")]
        public string CPF { get; set; }
    }
}