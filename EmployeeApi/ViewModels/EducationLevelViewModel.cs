namespace EmployeeApi.ViewModels
{
    public class EducationLevelViewModel
    {
        public int IdClient { get; set; }

        public int Id { get; set; }

        public string EducationLevelName { get; set; } = null!;

        public string? Description { get; set; }
    }
}
