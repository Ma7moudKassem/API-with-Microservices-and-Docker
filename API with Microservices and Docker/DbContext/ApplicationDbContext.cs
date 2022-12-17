namespace API_with_Microservices_and_Docker;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
}
