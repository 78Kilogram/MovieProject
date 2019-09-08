using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
    public interface INewRepository
    {

    }
    public class NewRepository : RepositoryBase<Ads>, INewRepository
    {
        public NewRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
