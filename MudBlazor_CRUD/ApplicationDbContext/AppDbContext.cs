using Microsoft.EntityFrameworkCore;
using MudBlazor_CRUD.Models;

namespace MudBlazor_CRUD.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
