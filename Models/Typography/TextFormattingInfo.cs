namespace FinReportBuilder.Models.Typography
{
    public class TextFormattingInfo
    {
        public int Id { get; set; } = 0;
        public string FontName { get; set; } = "Times New Roman";
        public float FontSize { get; set; } = 12f;
        public bool Bold { get; set; } = false;
        public bool Italic { get; set; } = false;
        public bool Underline { get; set; } = false;
    }
}
