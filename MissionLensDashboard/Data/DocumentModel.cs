namespace MissionLensDashboard.Data
{
    public class DocumentModel
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Category { get; set; }
        public string? Version { get; set; }
        public string? EmbeddingsGenerated { get; set; }
        public string Status { get; set; }
        public string Approved { get; set; }

        public string Available { get; set; } = "";
        public DateTime? ExpiryDate { get; set; }
    }
}
