using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class EducationMap : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
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
            builder.Property(x => x.School).IsRequired();
            builder.Property(x => x.School).HasMaxLength(120);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(50);
            builder.Property(x => x.Avarage).IsRequired();
            builder.Property(x => x.Avarage).HasMaxLength(30);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.ToTable("Educations");
            builder.HasData(new Education
            {
                Id = 1,
                Title = "Lisans Derecesi",
                School = "Uludağ Üniversitesi-Elektrik Elektronik Müh",
                Duration = "Eylül 2016--Devam Ediyor",
                Avarage = "2.65 GANO",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem recusandae quibusdam expedita, vitae veniam aut",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate",
            }, new Education
            {
                Id = 2,
                Title = "Lise Mezun",
                School = "Türkan Halit Aykılıç Fen Lisesi-Fen Bilimleri",
                Duration = "Eylül 2012--Temmuz 2016",
                Avarage = "81.63 ORT",
                Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem recusandae quibusdam expedita, vitae veniam aut",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate",
            }
            );
        }
    }
}
