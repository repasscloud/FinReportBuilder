namespace FinReportBuilder.Models.Clients
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostCode { get; set; }
        public string? Country { get; set; }
        public string? MailingAddress1 { get; set; }
        public string? MailingAddress2 { get; set; }
        public string? MailingCity { get; set; }
        public string? MailingState { get; set;}
        public string? MailingPostCode { get; set; }
        public string? MailingCountry { get; set;}
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? PreferredContactMethod { get; set; }
    }
}
