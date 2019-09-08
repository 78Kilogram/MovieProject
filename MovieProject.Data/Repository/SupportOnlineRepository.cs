using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface ISupportOnlineRepository
    {

    }
    public class SupportOnlineRepository : RepositoryBase<Ads>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
