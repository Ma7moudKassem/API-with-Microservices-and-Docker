namespace API_with_Microservices_and_Docker;

public class Employee
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(100)] public string Name { get; set; }
    [Required, MaxLength(15)] public string Mobile { get; set; }
    [Required] public double Age { get; set; }
}
