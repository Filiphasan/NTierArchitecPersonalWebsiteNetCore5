using MyWebApp.Data.Abstract;
using MyWebApp.Data.Concrete.EntityFramework.Contexts;
using MyWebApp.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyWebAppContext _context;
        private EfAboutMeRepository _efAboutMeRepository;
        private EfAdminRepository _efAdminRepository;
        private EfArticleRepository _efArticleRepository;
        private EfCategoryRepository _efCategoryRepository;
        private EfCommentRepository _efCommentRepository;
        private EfContactInfoRepository _efContactInfoRepository;
        private EfEducationRepository _efEducationRepository;
        private EfExperienceRepository _efExperienceRepository;
        private EfHomePageSliderRepository _efHomePageSliderRepository;
        private EfInterestedRepository _efInterestedRepository;
        private EfMessageRepository _efMessageRepository;
        private EfSiteIdentityRepository _efSiteIdentityRepository;
        private EfSkillRepository _efSkillRepository;
        private EfSocialMediaAccountRepository _efSocialMediaAccountRepository;
        private EfSummaryRepository _efSummaryRepository;

        public UnitOfWork(MyWebAppContext context)
        {
            _context = context;
        }

        public IAboutMeRepository AboutMe => _efAboutMeRepository ?? new EfAboutMeRepository(_context);

        public IAdminRepository Admin => _efAdminRepository ?? new EfAdminRepository(_context);

        public IArticleRepository Article => _efArticleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository Category => _efCategoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comment => _efCommentRepository ?? new EfCommentRepository(_context);

        public IContactInfoRepository ContactInfo => _efContactInfoRepository ?? new EfContactInfoRepository(_context);

        public IEducationRepository Education => _efEducationRepository ?? new EfEducationRepository(_context);

        public IExperienceRepository Experience => _efExperienceRepository ?? new EfExperienceRepository(_context);

        public IHomePageSliderRepository HomePageSlider => _efHomePageSliderRepository ?? new EfHomePageSliderRepository(_context);

        public IInterestedRepository Interested => _efInterestedRepository ?? new EfInterestedRepository(_context);

        public IMessageRepository Message => _efMessageRepository ?? new EfMessageRepository(_context);

        public ISiteIdentityRepository SiteIdentity => _efSiteIdentityRepository ?? new EfSiteIdentityRepository(_context);

        public ISkillRepository Skill => _efSkillRepository ?? new EfSkillRepository(_context);

        public ISocialMediaAccountRepository SocialMediaAccount => _efSocialMediaAccountRepository ?? new EfSocialMediaAccountRepository(_context);

        public ISummaryRepository Summary => _efSummaryRepository ?? new EfSummaryRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
