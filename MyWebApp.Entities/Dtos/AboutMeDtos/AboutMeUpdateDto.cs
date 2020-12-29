using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.AboutMeDtos
{
    public class AboutMeUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("İsim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(20,ErrorMessage = "{0} alanı en fazla {1} karakter olabilir!")]
        [MinLength(2,ErrorMessage ="{0} alanı {1} karakterden az olmamalıdır!")]
        public string FirstName { get; set; }
        //
        [DisplayName("Soyisim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir!")]
        [MinLength(2, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string LastName { get; set; }
        //
        [DisplayName("Resim Yolu")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir!")]
        public string ImagePath { get; set; }
        //
        [DisplayName("Meslek")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(40, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir!")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string MyJob { get; set; }
        //
        [DisplayName("Meslek Resmi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir!")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string MyJobFA { get; set; }
        //
        [DisplayName("Doğum Tarihi")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        public DateTime BirthDate { get; set; }
        //
        [DisplayName("Özgeçmiş Dosyası")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir!")]
        public string MyCVPath { get; set; }
        //
        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        public bool IsActive { get; set; }
        //
        [DisplayName("Silinsin mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        public bool IsDeleted { get; set; }
    }
}
