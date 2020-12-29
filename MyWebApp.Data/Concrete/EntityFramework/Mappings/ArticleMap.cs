using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(150);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.ShortContent).IsRequired();
            builder.Property(x => x.ShortContent).HasMaxLength(400);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Thumbnail).HasMaxLength(250);
            builder.Property(x => x.ViewsCount).IsRequired();
            builder.Property(x => x.SeoDescription).HasMaxLength(150);
            builder.Property(x => x.SeoDescription).IsRequired();
            builder.Property(x => x.SeoTags).IsRequired();
            builder.Property(x => x.SeoTags).HasMaxLength(70);
            builder.HasOne<Category>(x => x.Category).WithMany(x => x.Articles).HasForeignKey(x => x.CategoryId);
            builder.ToTable("Articles");
            builder.HasData(new Article
            {
                Id = 1,
                Title = "C# 9.0 ve .Net 5.0 Yenilikleri",
                ShortContent = "",
                Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                Thumbnail = "",
                ViewsCount = 0,
                CategoryId = 1,
                SeoDescription = "C# 9.0 ve .Net 5.0 Yenilikleri",
                SeoTags = "C#, C#9, .NET5",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate"
            });
        }
    }
}
