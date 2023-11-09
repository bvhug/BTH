using Microsoft.EntityFrameworkCore;
using BVietHung.Models;
using BVietHung.Controllers;
namespace BVietHung.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<BVietHung.Models.Employee> Employee { get; set; } = default!;
// khai báo việc ánh xạ class Person vào trong database
    }
}