using System;

using SampleSecureWeb.Models;
using Microsoft.EntityFrameworkCore;
namespace SampleSecureWeb.Data
{

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Student> Students {get; set;} = null!;

    public DbSet<User> Users {get; set;} = null!;

}
}
