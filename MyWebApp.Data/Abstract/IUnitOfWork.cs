using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IAboutMeRepository AboutMe { get; }
        IAdminRepository Admin { get; }
        IArticleRepository Article { get; }
        ICategoryRepository Category { get; }
        ICommentRepository Comment { get; }
        IContactInfoRepository ContactInfo { get; }
        IEducationRepository Education { get; }
        IExperienceRepository Experience { get; }
        IHomePageSliderRepository HomePageSlider { get; }
        IInterestedRepository Interested { get; }
        IMessageRepository Message { get; }
        ISiteIdentityRepository SiteIdentity { get; }
        ISkillRepository Skill { get; }
        ISocialMediaAccountRepository SocialMediaAccount { get; }
        ISummaryRepository Summary { get; }
        Task<int> SaveAsync();
    }
}
