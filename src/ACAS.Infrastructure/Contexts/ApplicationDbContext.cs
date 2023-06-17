using ACAS.Application.Contexts;
using ACAS.Domain.Entities;

using Microsoft.EntityFrameworkCore;

using System.Data;

namespace ACAS.Infrastructure.Contexts
{
    internal class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public IDbConnection Connection => Database.GetDbConnection();

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
