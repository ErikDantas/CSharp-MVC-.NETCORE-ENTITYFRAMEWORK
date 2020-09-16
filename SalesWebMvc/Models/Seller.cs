using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public String Name { get; set; }

        [Display(Name="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name ="Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }


        public Seller()
        {

        }

        public Seller(int id, string name, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public override bool Equals(object obj)
        {
            return obj is Seller seller &&
                   Id == seller.Id &&
                   Name == seller.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
