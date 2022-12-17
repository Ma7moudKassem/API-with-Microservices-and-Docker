namespace API_with_Microservices_and_Docker;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EmployeesController(ApplicationDbContext context) => _context = context;

    [HttpGet]
    public List<Employee> Get() => _context.Employees.ToList();

    [HttpPost]
    public async Task Post(Employee employee)
    {
        await _context.Employees.AddAsync(employee);

        await _context.SaveChangesAsync();
    }
}
