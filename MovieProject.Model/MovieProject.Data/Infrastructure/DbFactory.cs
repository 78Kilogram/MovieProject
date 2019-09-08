using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MovieProjectDbContext dbContext;
        public MovieProjectDbContext Init()
        {
            return dbContext ?? (dbContext = new MovieProjectDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
