using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface ITrailerRepository
    {

    }
    public class TrailerRepository : RepositoryBase<Ads>, ITrailerRepository
    {
        public TrailerRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
