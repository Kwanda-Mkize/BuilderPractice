public class Employee
{
  public string Name { get; set; }
  public string Surname { get; set; }
  public string Email { get; set; }
  public int EmployeeNumber { get; set; }

  public class Builder
  {
    private readonly Employee employee = new Employee();

    public Builder SetName(string name)
    {
      employee.Name = name;
      return this;
    }

    public Builder SetSurname(string surname)
    {
      employee.Surname = surname;
      return this;
    }

    public Builder SetEmail(string email)
    {
      employee.Email = email;
      return this;
    }

    public Builder SetEmployeeNumber(int employeeNumber)
    {
      employee.EmployeeNumber = employeeNumber;
      return this;
    }

    public Employee Build()
    {
      return employee;
    }
  }


  public void DisplayEmployeeInformation()
  {
    Console.WriteLine($" Employee {Name} {Surname} with employee number {EmployeeNumber} and email {Email} was created");
  }
}