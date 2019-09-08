using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Data.Infrastructure;
using MovieProject.Model.Models;

namespace MovieProject.Data.Repository
{
   public interface IMovieRepository
    {
      
    }
    public class MovieRepository : RepositoryBase<Movie>,IAdsRepository
    {
        public MovieRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
