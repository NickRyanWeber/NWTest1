namespace NWTest1.Models
{
  public class Person
  {
    public int Id { get; set; }
    public bool Employed { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Salary { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
  }
}