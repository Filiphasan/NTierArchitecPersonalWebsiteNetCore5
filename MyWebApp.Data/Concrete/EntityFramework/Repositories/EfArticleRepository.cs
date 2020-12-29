using Microsoft.EntityFrameworkCore;
using MyWebApp.Data.Abstract;
using MyWebApp.Data.Concrete.EntityFramework.Contexts;
using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PagedList.Core;

namespace MyWebApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
           
        }
        public async Task<IList<Article>> GetAllOrderByDescIdAsync(Expression<Func<Article, bool>> predicate = null, params Expression<Func<Article, object>>[] includeProperties)
        {
            IQueryable<Article> query = _context.Set<Article>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.OrderByDescending(x => x.Id).ToListAsync();
        }
        public async Task<IList<Article>> Get3MostReadAsync(Expression<Func<Article, bool>> predicate = null, params Expression<Func<Article, object>>[] includeProperties)
        {
            IQueryable<Article> query = _context.Set<Article>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.OrderByDescending(x => x.ViewsCount).Take(3).ToListAsync();
        }

        private MyWebAppContext MyWebAppContext
        {
            get
            {
                return _context as MyWebAppContext;
            }
        }
    }
}
