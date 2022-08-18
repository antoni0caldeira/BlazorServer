using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Data.Models;

namespace WiredBrainCoffee.EmployeeManager.Data
{
    public class EmplyeeManagerDbContext : DbContext
    {
        public EmplyeeManagerDbContext(DbContextOptions<EmplyeeManagerDbContext> options) : base(options) {}
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Departement> Departements => Set<Departement>();
    }
}
