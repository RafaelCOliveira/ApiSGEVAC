using System.ComponentModel.DataAnnotations;

namespace ApiSGEVAC.Models
{
    public class Cargo
    {
        [Key]
        public int IdCargo { get; set; }

        public string DescCargo { get; set; }
    }
}