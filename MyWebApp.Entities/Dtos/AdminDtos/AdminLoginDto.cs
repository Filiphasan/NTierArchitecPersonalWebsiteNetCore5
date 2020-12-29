using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.AdminDtos
{
    public class AdminLoginDto
    {
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır!")]
        [MinLength(10, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string Email { get; set; }
        //
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır!")]
        [MinLength(4, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string Password { get; set; }
    }
}
