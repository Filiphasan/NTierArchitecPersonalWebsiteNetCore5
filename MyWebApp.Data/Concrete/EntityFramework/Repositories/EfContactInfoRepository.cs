using Microsoft.EntityFrameworkCore;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfContactInfoRepository : EfEntityRepositoryBase<ContactInfo>, IContactInfoRepository
    {
        public EfContactInfoRepository(DbContext context) : base(context)
        {
        }
    }
}
