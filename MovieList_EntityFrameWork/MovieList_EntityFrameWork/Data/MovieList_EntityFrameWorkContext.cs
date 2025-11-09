using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieList_EntityFrameWork.Models;

namespace MovieList_EntityFrameWork.Data
{
    public class MovieList_EntityFrameWorkContext : DbContext
    {
        public MovieList_EntityFrameWorkContext (DbContextOptions<MovieList_EntityFrameWorkContext> options)
            : base(options)
        {
        }

        public DbSet<MovieList_EntityFrameWork.Models.Movies> Movies { get; set; } = default!;
    }
}
