using FinReportBuilder.Models.Clients.Attachments;
using FinReportBuilder.Models.Clients.BusinessParticulars;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinReportBuilder.Models.Clients
{
    public class ClientProfile
    {
        public int Id { get; set; }
        
        // who does this customer belong to?
        public string CustomerOf { get; set; } = null!;

        // the entity name, what is commonly known as
        public string EntityName { get; set; } = null!;

        // contact information for the entity, also searchable
        public ContactInfo? ContactInformation { get; set; }

        [RegularExpression(@"^$|^\d{9}$", ErrorMessage = "Tax File Number must be empty or 9 digits.")]
        public string? TaxFileNumber { get; set; }
        
        [RegularExpression(@"^$|^\d{11}$", ErrorMessage = "Tax File Number must be empty or 9 digits.")]
        public string? ABN { get; set; }

        [RegularExpression(@"^$|^\d{9}$", ErrorMessage = "Tax File Number must be empty or 9 digits.")]
        public string? ACN { get; set; }

        public BusinessInfo? BusinessInformation { get; set; } // Reference to BusinessInfo

        [NotMapped]
        public List<ClientCommunication> CommunicationHistory { get; set; }
        public List<DocumentManagement>? Documents { get; set; }
        public ClientPreferences? Preferences { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
