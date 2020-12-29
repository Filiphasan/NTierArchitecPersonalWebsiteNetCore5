using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class ExperienceMap : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
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
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.Workplace).IsRequired();
            builder.Property(x => x.Workplace).HasMaxLength(100);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.ToTable("Experiences");
            builder.HasData(new Experience
            {
                Id = 1,
                Title = "Freelance Web Developer",
                Workplace = "Freelance",
                Duration = "Haziran 2020--Devam Ediyor",
                Description = "Haziran 2020'den beridir, arkadaşlar ve çevrwm için web sitesi yapıyorum. Birkaç tanesini yayına aldım.",
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
