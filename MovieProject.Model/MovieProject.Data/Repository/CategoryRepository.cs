using System.Collections.Generic;
using System.Linq;
using MovieProject.Data.Infrastructure;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<Category> GetByAlias(string alias)
        {
            return this.DbContext.Category.Where(x => x.Alias == alias);
        }
    }
}
