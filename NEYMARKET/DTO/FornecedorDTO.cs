using System.ComponentModel.DataAnnotations;

namespace NEYMARKET.DTO
{
    public class FornecedorDTO
    {
        [Required]

        public int Id {get; set;}
        [Required(ErrorMessage="Nome do fornecedor é obrigatório")]
        [StringLength(100,ErrorMessage="Nome de categoria muito grande, tente um nome menor!")]
        [MinLength(2,ErrorMessage="Nome de caterogira muito pequeno, tente um nome maior!")]

        public string Nome {get; set;}
        [Required(ErrorMessage="E-mail de fornecedor é obrigatório")]
        [EmailAddress(ErrorMessage="E-mail inválido")]

        public string Email {get; set;}
        [Required(ErrorMessage="E-mail de fornecedor é obrigatório")]
        [Phone(ErrorMessage="Número de telefone inválido")]
        public string Telefone {get; set;}
    }
}