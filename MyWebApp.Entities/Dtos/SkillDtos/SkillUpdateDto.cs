using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.SkillDtos
{
    public class SkillUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Yetenek & Beceri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(30, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(1, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Yetenek & Beceri Yüzdesi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [Range(0, 100, ErrorMessage = "{0} alanı 0 ile 100 aralığında olmalıdır!")]
        public int PercentageValue { get; set; }
        //
        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]
        public bool IsActive { get; set; }
        //
        [DisplayName("Silindi mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]
        public bool IsDeleted { get; set; }
    }
}
