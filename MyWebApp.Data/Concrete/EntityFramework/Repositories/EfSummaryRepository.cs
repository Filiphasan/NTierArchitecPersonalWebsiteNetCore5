using Microsoft.EntityFrameworkCore;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfSummaryRepository : EfEntityRepositoryBase<Summary>, ISummaryRepository
    {
        public EfSummaryRepository(DbContext context) : base(context)
        {
        }
    }
}
