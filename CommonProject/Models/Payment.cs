using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseProject.Models
{
    public class Payment
    {
        [Key]
        public Guid Key { get; set; }
        public double Amount { get; set; }
    }
}
