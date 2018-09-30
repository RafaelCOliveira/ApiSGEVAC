using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiSGEVAC.Models
{
    public class Cargo
    {
        [Key]
        public int IdCargo { get; set; }

        [Required(ErrorMessage="A Descrição do Cargo é obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Descrição do Cargo")]
        public string DescCargo { get; set; }

    }
}