using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class AboutMeMap : IEntityTypeConfiguration<AboutMe>
    {
        public void Configure(EntityTypeBuilder<AboutMe> builder)
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
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(20);
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(20);
            builder.Property(x => x.ImagePath).IsRequired();
            builder.Property(x => x.ImagePath).HasMaxLength(250);
            builder.Property(x => x.MyJob).IsRequired();
            builder.Property(x => x.MyJob).HasMaxLength(40);
            builder.Property(x => x.MyJobFA).IsRequired();
            builder.Property(x => x.MyJobFA).HasMaxLength(150);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.MyCVPath).IsRequired();
            builder.Property(x => x.MyCVPath).HasMaxLength(250);
            builder.ToTable("AboutMe");
            builder.HasData(new AboutMe
            {
                Id =1,
                FirstName = "Hasan",
                LastName = "Erdal",
                ImagePath = "",
                MyJobFA = "<i class=\"fas fa - laptop - code\"></i>",
                MyJob = "Full-stack Web Developer",
                BirthDate = DateTime.Parse("17.06.1998"),
                MyCVPath = "",
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                Note = "InitialCreate"
            });
        }
    }
}
