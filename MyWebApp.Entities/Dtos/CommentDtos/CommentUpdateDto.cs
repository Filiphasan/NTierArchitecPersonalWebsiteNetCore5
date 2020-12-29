using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.CommentDtos
{
    public class CommentUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir!")]
        [MaxLength(25, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(2, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string FirstName { get; set; }
        //
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir!")]
        [MaxLength(20, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(2, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string LastName { get; set; }
        //
        [DisplayName("Yorum")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir!")]
        [MaxLength(512, ErrorMessage = "{0} en fazla {1} karakter olabilir!")]
        [MinLength(10, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string Text { get; set; }
        //
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} Boş geçilmemelidir!")]
        public int ArticleId { get; set; }
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
