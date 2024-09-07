using EFCore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DAL
{
    public class EFContext :DbContext
    {
        DbSet<Class> Classes { get; set; }
        DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=EFEXp;Trusted_Connection=True;");
        }
    }
}
