using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Data.Models;

namespace WiredBrainCoffee.EmployeeManager.Data
{
    public class EmplyeeManagerDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Departement> Departements => Set<Departement>();
    }
}
