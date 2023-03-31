using Day2.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Context;
public class TicketContext : DbContext
{

    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Developer> Developers => Set<Developer>();
    public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 

    }
}

