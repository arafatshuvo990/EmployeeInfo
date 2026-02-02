using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Model
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
