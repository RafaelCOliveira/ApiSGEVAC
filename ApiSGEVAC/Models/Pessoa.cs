using System.ComponentModel.DataAnnotations;

namespace ApiSGEVAC.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa  { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string cep { get; set; }
        public string Email { get; set; }
        
    }
}