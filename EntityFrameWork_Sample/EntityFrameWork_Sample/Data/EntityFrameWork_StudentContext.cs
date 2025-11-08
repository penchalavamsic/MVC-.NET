using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameWork_Sample.Models;

namespace EntityFrameWork_Sample.Data
{
    public class EntityFrameWork_StudentContext : DbContext
    {
        public EntityFrameWork_StudentContext (DbContextOptions<EntityFrameWork_StudentContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameWork_Sample.Models.Student> Student { get; set; } = default!;
    }
}
