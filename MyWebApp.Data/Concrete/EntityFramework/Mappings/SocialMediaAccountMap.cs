using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Mappings
{
    public class SocialMediaAccountMap : IEntityTypeConfiguration<SocialMediaAccount>
    {
        public void Configure(EntityTypeBuilder<SocialMediaAccount> builder)
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
            builder.Property(x => x.AccountFA).IsRequired();
            builder.Property(x => x.AccountFA).HasMaxLength(150);
            builder.Property(x => x.AccountUrl).IsRequired();
            builder.Property(x => x.AccountUrl).HasMaxLength(250);
            builder.ToTable("SocialMediaAccounts");
            builder.HasData(new SocialMediaAccount
            {
                Id = 1,
                AccountFA = "<i class=\"fab fa - facebook - square\"></i>",
                AccountUrl = "https://www.facebook.com/xxfiliphasanxx",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate"
            }, new SocialMediaAccount
            {
                Id = 2,
                AccountFA = "<i class=\"fab fa - twitter - square\"></i>",
                AccountUrl = "https://twitter.com/hasaerda",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate"
            }, new SocialMediaAccount
            {
                Id = 3,
                AccountFA = "<i class=\"fab fa - linkedin\"></i>",
                AccountUrl = "https://www.linkedin.com/in/hasan-erdal-2b57a3136/",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate"
            }, new SocialMediaAccount
            {
                Id = 4,
                AccountFA = "<i class=\"fab fa - github - square\"></i>",
                AccountUrl = "https://github.com/Filiphasan",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedTime = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedTime = DateTime.Now,
                Note = "InitialCreate"
            }, new SocialMediaAccount
            {
                Id = 5,
                AccountFA = "<i class=\"fab fa - youtube\"></i>",
                AccountUrl = "https://www.youtube.com/channel/UCKgQs4J8PEFS97iOGop_X4w",
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
