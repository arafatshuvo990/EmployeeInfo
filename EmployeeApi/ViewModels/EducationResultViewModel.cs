namespace EmployeeApi.ViewModels
{
    public class EducationResultViewModel
    {
        public int IdClient { get; set; }

        public int Id { get; set; }

        public string ResultName { get; set; } = null!;

        public string? Description { get; set; }
    }
}
