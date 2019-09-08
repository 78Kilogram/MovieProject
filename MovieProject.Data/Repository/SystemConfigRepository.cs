using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface ISystemConfigRepository
    {

    }
    public class SystemConfigRepository : RepositoryBase<Ads>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
