using Hospital.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctors {get;set;}
        public DbSet<Insurance> Insurances { get;set;}
        public DbSet<Patient> Patients { get;set;}
        public DbSet<Test> Tests { get;set;}
    }
}
