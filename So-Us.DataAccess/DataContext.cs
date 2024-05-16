using Microsoft.EntityFrameworkCore;
using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Us.DataAccess
{
    public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Resident> Residents { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<SoUs.Entities.Task> Tasks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<CareCenter> CareCenters { get; set; }
    public DbSet<Address> Addresss { get; set; }
    //[11:59] Noah Obi Alexander Hauge
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=So-UsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

}

}
