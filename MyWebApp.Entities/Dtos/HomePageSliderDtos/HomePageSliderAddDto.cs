using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.HomePageSliderDtos
{
    public class HomePageSliderAddDto
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(5, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Kısa Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(400, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string ShortDescription { get; set; }
        //
        [DisplayName("Uzun Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MinLength(10, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string LongDescription { get; set; }
    }
}
