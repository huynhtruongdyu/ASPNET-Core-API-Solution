using ACAS.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using System.Data;

namespace ACAS.Application.Contexts
{
    public interface IApplicationDbContext
    {
        IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        DbSet<Department> Departments { get; set; }
        DbSet<Employee> Employees { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
