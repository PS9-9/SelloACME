using System;
using System.Collections.Generic;

namespace SelloACME.Models
{
    public partial class Person
    {
        public Person()
        {
            Employee = new HashSet<Employee>();
        }

        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
