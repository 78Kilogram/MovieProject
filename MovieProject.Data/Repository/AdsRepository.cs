using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface IAdsRepository
    {

    }
    public class AdsRepository : RepositoryBase<Ads>, IAdsRepository
    {
        public AdsRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
