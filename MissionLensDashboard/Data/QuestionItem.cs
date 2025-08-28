namespace MissionLensDashboard.Data
{
    public class QuestionItem
    {
        public string UserName { get; set; } = "";
        public string Question { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        public string TrainingAnswer { get; set; } = "";
        public DateTime UpdatedDate { get; set; }
        public string UserResponse { get; set; } = "";
    }
}
