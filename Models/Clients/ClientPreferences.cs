namespace FinReportBuilder.Models.Clients
{
    public class ClientPreferences
    {
        public int Id { get; set; }
        public string? PreferredCommunicationMethod { get; set; }
        public string? SundayAppointments { get; set; }
        public string? MondayAppointments { get; set; }
        public string? TuesdayAppointments { get; set; }
        public string? WednesdayAppointments { get; set; }
        public string? ThursdayAppointments { get; set; }
        public string? FridayAppointments { get; set; }
        public string? SaturdayAppointments { get; set; }
    }
}
