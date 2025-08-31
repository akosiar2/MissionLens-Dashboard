namespace MissionLensDashboard.Data
{
    public class TrainingManagementModel
    {
        public string Question { get; set; }
        public string BotAnswer { get; set; }
        public string Answer { get; set; }
        public string? EmbeddingsGenerated { get; set; }
        public string BotType { get; set; }
        public string UserResponse { get; set; }

        public string UserNotes { get; set; } = "";
    }
}
