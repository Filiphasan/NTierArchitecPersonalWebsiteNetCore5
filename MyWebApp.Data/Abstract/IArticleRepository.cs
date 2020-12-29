using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
        Task<IList<Article>> GetAllOrderByDescIdAsync(Expression<Func<Article, bool>> predicate = null, params Expression<Func<Article, object>>[] includeProperties);
        Task<IList<Article>> Get3MostReadAsync(Expression<Func<Article, bool>> predicate = null, params Expression<Func<Article, object>>[] includeProperties);

    }
}
