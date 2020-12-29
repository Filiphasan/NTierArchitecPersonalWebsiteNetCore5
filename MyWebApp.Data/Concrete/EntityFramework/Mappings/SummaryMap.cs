using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class SummaryMap : IEntityTypeConfiguration<Summary>
    {
        public void Configure(EntityTypeBuilder<Summary> builder)
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
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Summary");
            builder.HasData(new Summary
            {
                Id = 1,
                Content = "Merhaba siteme hoşgeldiniz. Ben Elektrik Elektronik Mühendisliği okuyan aynı zamanda yazılıma gönül vermiş birisiyim. C# ve .NET alanlarında yoğun bir şekilde kendimi geliştiriyorum. Python ve JavaScript dillerinde ise yavaş ve planlı şekilde gelişimime devam ediyorum. Gelişime açık ve hızlı öğrenen birisi olduğumu düşünüyorum. Geleceğimi yazılım üzerine şekillendireceğime eminim. Bu yolda elimden gelenin en iyisini değil, her şeyi yapacağım. Yazılım üzerine birçok hayalim, uzun ve kısa vadeli planlarım var. Açıkçası yazılımın hayatımın her alanına yeterli ölçüde etki etmesini istiyorum. Bilgisayar eskiden beridir tutkum olan bir alan. Bilgisayardan bir şeyler yazarak bunun somut sonuçlarını görmek beni mutlu ediyor.",
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
