using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWebApp.Entities.Dtos.ArticleDtos
{
    public class ArticleUpdateDto
    {
        [Required]
        public int Id { get; set; }
        //
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır!")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string Title { get; set; }
        //
        [DisplayName("Kısa İçerik Yazısı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(400, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır!")]
        [MinLength(100, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string ShortContent { get; set; }
        //
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string Content { get; set; }
        //
        [DisplayName("Resim")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır!")]
        public string Thumbnail { get; set; }
        //
        [DisplayName("Seo Etiketleri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır!")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string SeoTags { get; set; }
        //
        [DisplayName("Seo Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterden fazla olmamalıdır!")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır!")]
        public string SeoDescription { get; set; }
        //
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir!")]
        public int CategoryId { get; set; }
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
