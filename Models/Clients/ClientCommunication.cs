namespace FinReportBuilder.Models.Clients
{
    public class ClientCommunication
    {
        public int Id { get; set; } = 0;
        public string CommunicationMedium { get; set; } = null!;
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public string? SpokeWith { get; set; }
        public string? PhoneNumberCalled { get; set; }
        public DateTime RecordCreated { get; set; }
    }
}
