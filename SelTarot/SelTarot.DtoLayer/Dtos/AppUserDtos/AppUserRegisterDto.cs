using SelTarot.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Kullanıcı adı en az 3 karakter uzunluğunda olmalıdır.")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az {2} karakter uzunluğunda olmalıdır.")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
