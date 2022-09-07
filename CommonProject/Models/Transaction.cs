
using System.ComponentModel.DataAnnotations;

namespace DatabaseProject.Models
{
    public class Transaction
    {
        [Key]
        public int Key { get; set; }
        public string Name { get; set; }
        public Payment Payment { get; set; }
    }
}
