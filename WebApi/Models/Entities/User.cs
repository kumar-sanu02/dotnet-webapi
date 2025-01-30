using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Entities
{
    public class User
    {
        public Employee Employees { get; set; }
        [ForeignKey("Employee")]
        public int Id{get;set;}
        [Required][MaxLength(60)]
        public int Address { get; set; }
    }
}