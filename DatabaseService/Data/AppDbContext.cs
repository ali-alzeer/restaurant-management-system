using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseService.Interfaces;
using DatabaseService.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseService.Data
{
  public class AppDbContext(DbContextOptions options) : DbContext(options), IAppDbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
  }
}