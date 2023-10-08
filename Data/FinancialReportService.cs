using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;

namespace FinReportBuilder.Data
{
	public class FinancialReportService
	{
        public MemoryStream CreateFinancialReportForYearEnded(
            string clientName,
            string yearEndingStatement,
            string basisOfPreparationText,
            bool hasPlantPropertyEquipment,
            string plantPropertyEquipmentText,
            string plantPropertyEquipmentDepreciationText,

            bool hasAbn = true,
            string abnNumber = "00000000000")
        {
            string formattedAbnNumber = string.Empty;
            if (hasAbn)
            {
                formattedAbnNumber = $"{long.Parse(abnNumber):00 000 000 000}";
            }

            //Creating a new document.
            using (WordDocument document = new WordDocument())
            {
                // add title section to word document
                IWSection section = document.AddSection();

                // setup page options
                section.PageSetup.Orientation = PageOrientation.Portrait;
                section.PageSetup.Margins.All = 36;

                // create paragraph style
                IWParagraphStyle style = document.AddParagraphStyle("FinancialReport_FrontPage_Style");
                style.ParagraphFormat.BackColor = Color.White;
                style.ParagraphFormat.AfterSpacing = 18f;
                style.ParagraphFormat.BeforeSpacing = 18f;
                style.ParagraphFormat.LineSpacing = 15f;
                style.CharacterFormat.FontName = "Times New Roman";
                style.CharacterFormat.FontSize = 16f;
                style.CharacterFormat.Bold = true;

                // add company paragraph to the section
                IWParagraph paragraph = section.AddParagraph();

                // append text to the paragraph
                paragraph.AppendText("\n\n\n\n"); // lead in
                paragraph.AppendText($"{clientName.ToUpperInvariant()}");
                paragraph.ApplyStyle("FinancialReport_FrontPage_Style");
                paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

                // ABN provision
                if (hasAbn)
                {
                    paragraph.AppendBreak(BreakType.LineBreak);
                    paragraph.AppendText($"ABN {formattedAbnNumber}");
                }

                // report details
                paragraph.AppendText("\n\n\n\n"); // lead in
                paragraph.AppendText("FINANCIAL REPORT");
                paragraph.AppendBreak(BreakType.LineBreak);
                paragraph.AppendText("FOR THE YEAR ENDED");
                paragraph.AppendBreak(BreakType.LineBreak);
                paragraph.AppendText($"{yearEndingStatement.ToUpperInvariant()}");
                paragraph.AppendText("\n\n\n\n\n\n"); // lead in
                paragraph.ParagraphFormat.Keep = true;

                // frontPageSubStyle
                IWParagraphStyle frontPageSubStyle = document.AddParagraphStyle("FinancialReport_FrontPage_SubStyle");
                frontPageSubStyle.ParagraphFormat.BackColor = Color.White;
                frontPageSubStyle.ParagraphFormat.AfterSpacing = 14f;
                frontPageSubStyle.ParagraphFormat.BeforeSpacing = 14f;
                frontPageSubStyle.ParagraphFormat.LineSpacing = 14f;
                frontPageSubStyle.CharacterFormat.FontName = "Times New Roman";
                frontPageSubStyle.CharacterFormat.FontSize = 12f;
                frontPageSubStyle.CharacterFormat.Bold = true;

                // frontpage sub-section
                IWParagraph paragraph1 = section.AddParagraph();
                paragraph1.ApplyStyle("FinancialReport_FrontPage_SubStyle");
                paragraph1.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

                // append liability statement
                paragraph1.AppendBreak(BreakType.LineBreak);
                paragraph1.AppendText("Liability limited by a scheme approved under");
                paragraph1.AppendBreak(BreakType.LineBreak);
                paragraph1.AppendText("Professional Standards Legislation");

                // page5 - Notes to the financial statements
                IWParagraphStyle page5Style = document.AddParagraphStyle("Page5_Style");
                page5Style.ParagraphFormat.BackColor = Color.LightGray;
                page5Style.ParagraphFormat.AfterSpacing = 14f;
                page5Style.ParagraphFormat.BeforeSpacing = 14f;
                page5Style.ParagraphFormat.LineSpacing = 14f;
                page5Style.CharacterFormat.FontName = "Times New Roman";
                page5Style.CharacterFormat.FontSize = 12f;
                page5Style.CharacterFormat.Bold = true;

                IWParagraphStyle page5TextStyle = document.AddParagraphStyle("Page5Text_Style");
                page5TextStyle.ParagraphFormat.BackColor = Color.LightGray;
                page5TextStyle.ParagraphFormat.AfterSpacing = 12f;
                page5TextStyle.ParagraphFormat.BeforeSpacing = 12f;
                page5TextStyle.ParagraphFormat.LineSpacing = 12f;
                page5TextStyle.CharacterFormat.FontName = "Times New Roman";
                page5TextStyle.CharacterFormat.FontSize = 10f;
                page5TextStyle.CharacterFormat.Bold = false;

                IWParagraph pageBreakPara = section.AddParagraph();
                pageBreakPara.AppendBreak(BreakType.PageBreak);

                IWParagraph page5 = section.AddParagraph();
                page5.ApplyStyle("Page5_Style");
                page5.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
                page5.AppendText($"{clientName.ToUpperInvariant()}");
                if (hasAbn)
                {
                    page5.AppendText("\n");
                    page5.AppendText($"ABN {formattedAbnNumber}");
                }
                page5.AppendText("\n");
                page5.AppendText("NOTES TO THE FINANCIAL STATEMENTS");
                page5.AppendBreak(BreakType.LineBreak);
                page5.AppendText($"FOR THE YEAR ENDED {yearEndingStatement.ToUpperInvariant()}");

                Shape line = page5.AppendShape(AutoShapeType.Line, 800, 1);
                line.VerticalPosition = 52;
                line.HorizontalAlignment = ShapeHorizontalAlignment.Center;


                IWParagraph page5Text = section.AddParagraph();
                page5Text.ApplyStyle("Page5Text_Style");
                page5Text.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;
                page5Text.AppendText("\n");
                page5Text.AppendText($"The financial statements cover the business of " +
                    $"{clientName.ToUpperInvariant()}" +
                    $" and have been prepared to meet the needs of stakeholders and to assist in the preparation of the tax return." +
                    $"\n" +
                    $"Comparatives are consistent with prior years, unless otherwise stated.");


                IWParagraphStyle page5TextStyle2 = document.AddParagraphStyle("Page5Text_Style2");
                page5TextStyle2.ParagraphFormat.BackColor = Color.LightGray;
                page5TextStyle2.ParagraphFormat.AfterSpacing = 14f;
                page5TextStyle2.ParagraphFormat.BeforeSpacing = 14f;
                page5TextStyle2.ParagraphFormat.LineSpacing = 14f;
                page5TextStyle2.CharacterFormat.FontName = "Times New Roman";
                page5TextStyle2.CharacterFormat.FontSize = 12f;
                page5TextStyle2.CharacterFormat.Bold = true;

                // Define a tab stop with a custom position(e.g., 36 points for a 0.5 - inch hanging indent)
                Tab tabStop = page5.ParagraphFormat.Tabs.AddTab(position: 31f, TabJustification.Left, TabLeader.NoLeader);

                IWParagraph page5Text2 = section.AddParagraph();
                page5Text2.ApplyStyle("Page5Text_Style2");
                page5Text2.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;
                page5Text2.AppendText("1.\tBasis of Preparation");

                IWParagraphStyle page5TextStyle3 = document.AddParagraphStyle("Page5Text_Style3");
                page5TextStyle3.ParagraphFormat.BackColor = Color.LightGray;
                page5TextStyle3.ParagraphFormat.AfterSpacing = 12f;
                page5TextStyle3.ParagraphFormat.BeforeSpacing = 12f;
                page5TextStyle3.ParagraphFormat.LineSpacing = 12f;
                page5TextStyle3.CharacterFormat.FontName = "Times New Roman";
                page5TextStyle3.CharacterFormat.FontSize = 10f;
                page5TextStyle3.CharacterFormat.Bold = false;
                page5TextStyle3.ParagraphFormat.Keep = true;
                page5TextStyle3.ParagraphFormat.LeftIndent = 36f;

                IWParagraphStyle page5TextStyle4 = document.AddParagraphStyle("Page5Text_Style4");
                page5TextStyle4.ParagraphFormat.BackColor = Color.LightGray;
                page5TextStyle4.ParagraphFormat.AfterSpacing = 12f;
                page5TextStyle4.ParagraphFormat.BeforeSpacing = 12f;
                page5TextStyle4.ParagraphFormat.LineSpacing = 12f;
                page5TextStyle4.CharacterFormat.FontName = "Times New Roman";
                page5TextStyle4.CharacterFormat.FontSize = 10f;
                page5TextStyle4.CharacterFormat.Bold = true;
                page5TextStyle4.ParagraphFormat.Keep = true;
                page5TextStyle4.ParagraphFormat.LeftIndent = 36f;

                IWParagraph page5Text3 = section.AddParagraph();
                page5Text3.ApplyStyle("Page5Text_Style3");
                page5Text3.AppendText(basisOfPreparationText);


                // summary of significant accounting policies
                IWParagraph page5Text4 = section.AddParagraph();
                page5Text4.ApplyStyle("Page5Text_Style2");
                page5Text4.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;
                page5Text4.AppendText("2.\tSummary of Significant Accounting Policies");

                if (hasPlantPropertyEquipment)
                {
                    IWParagraph page5Text5 = section.AddParagraph();
                    page5Text5.ApplyStyle("Page5Text_Style2");
                    page5Text5.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;
                    page5Text5.AppendText("\tPlant, Property and Equipment");

                    IWParagraph page5Text6 = section.AddParagraph();
                    page5Text6.ApplyStyle("Page5Text_Style3");
                    page5Text6.AppendText(plantPropertyEquipmentText);

                    IWParagraph page5Text7 = section.AddParagraph();
                    page5Text7.ApplyStyle("Page5Text_Style4");
                    page5Text7.AppendText("Depreciation");

                    IWParagraph page5Text8 = section.AddParagraph();
                    page5Text8.ApplyStyle("Page5Text_Style3");
                    page5Text8.AppendText(plantPropertyEquipmentDepreciationText);
                }
                

                // Saves the Word document to MemoryStream.
                MemoryStream stream = new MemoryStream();
                document.Save(stream, FormatType.Docx);
                stream.Position = 0;
                return stream;
            }
        }
    }
}

//Basis of Preparation

//The Company is non reporting since there are unlikely to be any users who would rely on the general purpose financial statements.

//The special purpose financial statements have been prepared in accordance with the significant accounting policies described below and do not comply with any Australian Accounting Standards unless otherwise stated.

//The financial statements have been prepared on an accruals basis and are based on historical costs modified, where applicable, by the measurement at fair value of selected non current assets, financial assets and financial liabilities.

//Significant accounting policies adopted in the preparation of these financial statements are presented below and are consistent with prior reporting periods unless otherwise stated.