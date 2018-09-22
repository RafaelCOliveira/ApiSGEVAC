using System.ComponentModel.DataAnnotations;

namespace ApiSGEVAC.Models
{
    public class MotivoCancelamento
    {
        [Key]
        public int IdMotivoCancelamento { get; set; }

        public string DescMotivoCancelamento { get; set; }
    }
}