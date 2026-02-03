namespace EmployeeApi.ViewModels
{
    public class SectionViewModel
    {
        public int IdClient { get; set; }

        public int Id { get; set; }

        public string SectionName { get; set; } = null!;

        public string? SectionNameBangla { get; set; }

        public string ShortName { get; set; } = null!;
    }
}
