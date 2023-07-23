namespace api_survey.Models
{
    public class Survey
    {
        public String Title { get; set; }
        public String Question { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
