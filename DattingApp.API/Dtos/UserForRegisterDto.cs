using System.ComponentModel.DataAnnotations;

namespace DattingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "É necessário informar o Nome do Usuário.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "É necessário informar a senha.")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "A senha deve conter entre 4 e 8 caracteres.")]
        public string Password { get; set; }
    }
}