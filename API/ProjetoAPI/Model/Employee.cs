using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Employee(string name, int age) { 
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
        }
    }
}
