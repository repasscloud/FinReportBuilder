using FinReportBuilder.Models.Clients;
using FinReportBuilder.Models.Clients.BusinessParticulars;
using FinReportBuilder.Models.Reports;
using FinReportBuilder.Models.Typography;
using Microsoft.EntityFrameworkCore;

namespace FinReportBuilder.Data
{
    public class AppDbContext : DbContext
    {
        // Reports
        public DbSet<FinancialReportYearEnd> FinancialReportYearEnds { get; set; }

        // Clients
        public DbSet<ClientProfile> ClientProfiles { get; set; }

        // Typography - Text
        public DbSet<TextFormattingInfo> TextFormattingInfos { get; set; }

        // Typography - Paragraph
        public DbSet<ParagraphFormattingInfo> ParagraphFormattingInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            base.OnModelCreating(modelBuilder);
        }
    }
}
