using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Department()
        {

        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
