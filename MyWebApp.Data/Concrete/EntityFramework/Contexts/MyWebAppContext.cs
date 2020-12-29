using Microsoft.EntityFrameworkCore;
using MyWebApp.Data.Concrete.EntityFramework.Mappings;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Contexts
{
    public class MyWebAppContext : DbContext
    {
        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<HomePageSlider> HomePageSliders { get; set; }
        public DbSet<Interested> Interesteds { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SiteIdentity> SiteIdentities { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }
        public DbSet<Summary> Summaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-59CJCI3;Database=MyWebApp;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutMeMap());
            modelBuilder.ApplyConfiguration(new AdminMap());
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new ContactInfoMap());
            modelBuilder.ApplyConfiguration(new EducationMap());
            modelBuilder.ApplyConfiguration(new ExperienceMap());
            modelBuilder.ApplyConfiguration(new HomePageSliderMap());
            modelBuilder.ApplyConfiguration(new InterestedMap());
            modelBuilder.ApplyConfiguration(new MessageMap());
            modelBuilder.ApplyConfiguration(new SiteIdentityMap());
            modelBuilder.ApplyConfiguration(new SkillMap());
            modelBuilder.ApplyConfiguration(new SocialMediaAccountMap());
            modelBuilder.ApplyConfiguration(new SummaryMap());
        }
    }
}
