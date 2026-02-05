namespace EmployeeApi.ViewModels
{
    public class EducationExaminationViewModel
    {
        public int IdClient { get; set; }

        public int Id { get; set; }

        public string ExamName { get; set; } = null!;

        public int IdEducationLevel { get; set; }
    }
}
