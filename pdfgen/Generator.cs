using BestCV.JobSeeker.Models.Core;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.IO;

namespace pdfgen
{
    class Generator
    {
        Document document;
        TextFrame addressFrame;
        Table table;

        static readonly Color TableBorder = new Color(81, 125, 192);
        static readonly Color TableBlue = new Color(235, 240, 249);
        static readonly Color TableGray = new Color(242, 242, 242);

        public void DefineStyles()
        {
            // Get the predefined style Normal.
            Style style = this.document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Verdana";

            style = this.document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = this.document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = this.document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = this.document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);

        }

        public void CreatePage()
        {
            // Each MigraDoc document needs at least one section.
            Section section = this.document.AddSection();

            // Put a logo in the header
            Image image = section.Headers.Primary.AddImage("../../portrait-profile-007.jpg");
            image.Height = "2.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
            image.WrapFormat.Style = WrapStyle.Through;
           
        }

        public void FillContent()
        {

        }



        public Document Generate(Candidate model)
        {
            // Create a new MigraDoc document
            this.document = new Document();
            document.Info.Title = "Resume Sample";
            document.Info.Author = "Pradeep Loganathan";
            document.Info.Subject = "Creating a sample using pdfsharp and migradoc";
            document.Info.Keywords = "Bestcv, resume";

            DefineStyles();

            CreatePage();

            FillContent();

            return this.document;


            //    string filename = Directory.GetCurrentDirectory() + "\\" + Path.GetRandomFileName() + ".pdf";

            //    PdfDocument document = new PdfDocument();
            //    document.Info.Title = "Resume Sample";
            //    document.Info.Author = "Pradeep Loganathan";
            //    document.Info.Subject = "Creating a sample using pdfsharp and migradoc";
            //    document.Info.Keywords = "Bestcv, resume";


            //    PdfPage page = document.AddPage();
            //    XGraphics gfx = XGraphics.FromPdfPage(page);
            //    gfx.MUH = PdfFontEncoding.Unicode;
            //    gfx.MFEH = PdfFontEmbedding.Default;

            //    XFont font = new XFont("Verdana", 13, XFontStyle.Bold);

            //    Chart chart = table.Rows[1].Cells[2].AddChart(MigraDoc.DocumentObjectModel.Shapes.Charts.ChartType.Bar2D);
            //    chart.Width = Unit.FromPoint(100);
            //    chart.Height = Unit.FromPoint(9);
            //    chart.FillFormat.Color = Colors.MediumSeaGreen;


            //    Document doc = new Document();
            //    Section section = doc.AddSection();
            //    section.PageSetup = doc.DefaultPageSetup.Clone();
            //    section.PageSetup.PageFormat = PageFormat.A4;

            //    int sectionWidth = (int)(section.PageSetup.PageWidth - section.PageSetup.LeftMargin - section.PageSetup.RightMargin);
            //    int columnWidth = sectionWidth / 2;


            //    // Add a single paragraph with some text and format information.
            //    Paragraph para = section.AddParagraph();
            //    para.Format.Alignment = ParagraphAlignment.Justify;
            //    para.Format.Font.Name = "Times New Roman";
            //    para.Format.Font.Size = 12;
            //    para.Format.Font.Color = Colors.DarkGray;
            //    para.Format.Font.Color = Colors.DarkGray;
            //    para.AddText(model.CandidateTag.Tag);
            //    para.AddFormattedText(model.CandidateName.FirstName + model.CandidateName.LastName, TextFormat.Bold);
            //    para.AddText(model.CandidateProfile.Profile);
            //    para.Format.Borders.Distance = "5pt";
            //    para.Format.Borders.Color = Colors.Gold;

            //    // Create a renderer and prepare (=layout) the document
            //    DocumentRenderer docRenderer = new DocumentRenderer(doc);
            //    docRenderer.PrepareDocument();

            //    // Render the paragraph. You can render tables or shapes the same way.
            //    docRenderer.RenderObject(gfx, XUnit.FromCentimeter(5), XUnit.FromCentimeter(10), "12cm", para);


            //    document.Save(filename);

            //    Process.Start(filename);
        }
    }
}
