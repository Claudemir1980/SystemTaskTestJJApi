using System.ComponentModel.DataAnnotations;

namespace SistemUseMvcTest
{
    public class User
    {

        [Display(Name = "Codigo do Usuário")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Usuário")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Sobre  Nome do Usuário")]
        public string? username { get; set; }


        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string? email  { get; set; }


    }
}
