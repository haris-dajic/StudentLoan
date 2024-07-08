using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentLoan.Domain;

namespace StudentLoan.Infrastructure.Database;

public class StudentLoanDbContext: IdentityDbContext<User>
{
    public StudentLoanDbContext(DbContextOptions<StudentLoanDbContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(StudentLoanDbContext).Assembly);
    }
}