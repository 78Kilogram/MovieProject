using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface IVisitorStatisticRepository
    {

    }
    public class VisitorStatisticRepository : RepositoryBase<Ads>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
