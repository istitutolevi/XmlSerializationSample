using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationSample
{
public class Person
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int Age { get; set; }
    public Person Mom { get; set; }
    public Person Dad { get; set; }
}
}
