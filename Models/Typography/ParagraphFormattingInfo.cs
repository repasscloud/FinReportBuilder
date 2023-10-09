namespace FinReportBuilder.Models.Typography
{
    public class ParagraphFormattingInfo
    {
        public int Id { get; set; } = 0;
        public string BackColor { get; set; } = "Black";
        public float AfterSpacing = 1.2f;
        public float BeforeSpacing = 1.2f;
        public float LineSpacing = 12f;
        public int LeftIndentation { get; set; } = 0;
        public int RightIndentation { get; set; } = 0;
        public int FirstLineIndentation { get; set; } = 0;
        public bool Keep { get; set; } = false;
    }
}
