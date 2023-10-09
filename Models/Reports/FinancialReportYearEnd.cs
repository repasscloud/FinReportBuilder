using System.ComponentModel.DataAnnotations;

namespace FinReportBuilder.Models.Reports
{
	public class FinancialReportYearEnd
	{
        [Key]
        public int Id { get; set; }

        public Guid CustomerId { get; set; } = new();

        // report name
        public string ReportName { get; } = "FINANCIAL REPORT\nFOR THE YEAR ENDED";

        // agency details
        public string FirmName { get; set; } = "Business Accounting and Tax Solutions";
        public string FirmPartnerName { get; set; } = "Faranak Farnosh";
        public string FirmAddress { get; set; } = "52 Benaroon Ave, ST IVES, NSW 2755";
        public string ReportGeneratedDate { get; set; } = DateTime.Today.ToString("dd MMMM yyyy");

        [RegularExpression(@"^\d{4}", ErrorMessage = "Year must be 4 digits.")]
        public string YearEndedStatement { get; set; } = null!;

        [RegularExpression(@"^.{2,}$", ErrorMessage = "Client name must be minimum 2 characters.")]
        public string ClientName { get; set; } = null!;

        [RegularExpression(@"^.{2,}$", ErrorMessage = "Director's name must be minimum 2 characters.")]
        public string DirectorsName { get; set; } = null!;

        // client has ABN?
        public bool HasABN { get; set; } = false;
        [RegularExpression(@"^\d{11}$", ErrorMessage = "ABN must be 11 digits.")]
        public string ABN { get; set; } = null!;

        // summary for basis of report
        public string BasisOfReport { get; set; } = null!;

        // summary of significant accounting policies
        // property, plant and equipment
        public bool HasPropertyPlantEquipment { get; set; } = false;
        public string PropertyPlantEquipment { get; set; } = string.Empty;
        public string PropertyPlantEquipmentDepreciation { get; set; } = string.Empty;
    }
}

