using System.ComponentModel.DataAnnotations;

namespace ApiSGEVAC.Models
{
    public class Montadora
    {
        [Key]
        public int IdMontadora { get; set; }

        public string DescMontadora { get; set; }
    }
}