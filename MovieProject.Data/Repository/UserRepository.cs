using MovieProject.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Model.Models;
namespace MovieProject.Data.Repository
{
    public interface IUserRepository
    {

    }
    public class UserRepository : RepositoryBase<Ads>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
