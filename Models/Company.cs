using System.Collections.Generic;

namespace NWTest1.Models
{
  public class Company
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Person> Person { get; set; } = new List<Person>();
  }
}