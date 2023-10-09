namespace FinReportBuilder.Models.Clients.Attachments
{
    public class DocumentManagement
    {
        public int Id { get; set; }
        public string EntityOwner { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string DocumentName { get; set; } = null!;
        public string DocumentPath { get; set; } = null!;
        public byte[]? DocumentData { get; set; }
    }
}
