using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.SocialMediaAccountDtos
{
    public class SocialMediaAccountAddDto
    {
        [DisplayName("Sosyal Medya Fontawesome")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(150, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string AccountFA { get; set; }
        //
        [DisplayName("Sosyal Medya Linki")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(250, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string AccountUrl { get; set; }
    }
}
