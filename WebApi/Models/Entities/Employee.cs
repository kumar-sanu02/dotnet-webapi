

using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        //minimum length of name should 3 but less than 50
       [Required][MinLength(3)][MaxLength(50)]
        public  string Name { get; set; }
        [Required]
        public required string Email { get; set; }
        public required string Phone { get; set; }
        [Required]
        public decimal Salary { get; set; }

    }
}