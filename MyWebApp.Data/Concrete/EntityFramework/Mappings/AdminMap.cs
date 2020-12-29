using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
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
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.PasswordHash).HasMaxLength(200);
            builder.Property(x => x.SecurituQuestion).IsRequired();
            builder.Property(x => x.SecurituQuestion).HasMaxLength(100);
            builder.Property(x => x.SQAnswerHash).IsRequired();
            builder.Property(x => x.SQAnswerHash).HasMaxLength(200);
            builder.ToTable("Admin");
            builder.HasData(new Admin
            {
                Id = 1,
                Email = "hasaerda@hotmail.com",
                PasswordHash = "6449f8c4593cfb33c2404abdbc0c51e8",
                SecurituQuestion = "Anne kızlık soyadı (küçük harflerle)?",
                SQAnswerHash = "fb01c2637b1583bd8e911f6ff47017c7",
                CreatedByName = "InitialCreate",
                ModifiedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                Note = "InitialCreate"
            });
        }
    }
}
