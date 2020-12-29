using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Entities.Dtos.SummaryDtos
{
    public class SummaryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Yetenek & Beceri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MinLength(100, ErrorMessage = "{0} en az {1} karakter olmalıdır!")]
        public string Content { get; set; }
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
