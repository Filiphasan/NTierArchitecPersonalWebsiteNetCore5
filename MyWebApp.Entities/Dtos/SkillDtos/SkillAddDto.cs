using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.SkillDtos
{
    public class SkillAddDto
    {
        [DisplayName("Yetenek & Beceri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(30, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Yetenek & Beceri Yüzdesi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [Range(0,100,ErrorMessage ="{0} alanı 0 ile 100 aralığında olmalıdır!")]
        public int PercentageValue { get; set; }
    }
}
