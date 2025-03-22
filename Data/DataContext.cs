using HomeAssignmentDotNet8EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAssignmentDotNet8EntityFramework.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
}