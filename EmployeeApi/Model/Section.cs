using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Model
{
    public class Section
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
