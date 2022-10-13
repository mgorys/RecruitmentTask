using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Numerics;
using TaskMG.Models;

namespace TaskMG.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Sentence> Sentences { get; set; }
    }

}
