using BestCV.JobSeeker.Models.Core;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Fields;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.IO;

namespace pdfgen
{
    public class Generator
    {

        public Generator()
        {

        }

        public PdfDocument CreateDocument()
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Pradeep Loganathan Resume";
            document.Info.Author = "Pradeep Loganathan";
            document.Info.Subject = "Created with code by Pradeep Loganathan";
            document.Info.Keywords = ".Net, Asp.Net";
            return document;

        }

        public PdfDocument CreateFirstPage(Candidate model, PdfDocument pdfDocument)
        {

            PdfPage pdfPage = new PdfPage();
            XSize size = PageSizeConverter.ToSize(PageSize.A4);
            pdfPage.Orientation = PageOrientation.Portrait;

            pdfPage.Width = size.Width;
            pdfPage.Height = size.Height;
            pdfPage.TrimMargins.Top = 10;
            pdfPage.TrimMargins.Right = 10;
            pdfPage.TrimMargins.Bottom = 10;
            pdfPage.TrimMargins.Left = 10;

            pdfDocument.Pages.Add(pdfPage);


            XGraphics gfx = XGraphics.FromPdfPage(pdfPage);            
            gfx.MUH = PdfFontEncoding.Unicode;
            gfx.MFEH = PdfFontEmbedding.Default;


            var document = new Document();
            var section = document.AddSection();

            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.TopMargin = "5cm";
            section.PageSetup.BottomMargin = "5cm";
            section.PageSetup.RightMargin = "5cm";
            section.PageSetup.LeftMargin = "5cm";

            var paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.Format.KeepTogether = true;
            paragraph.AddText(model.CandidateProfile.Profile);
            

            Image image = section.AddImage(@"D:\source\play\pdfgen\pdfgen\portrait-profile-007.jpg");
            image.Height = "1.5cm";
            image.Width = "4cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
            image.WrapFormat.Style = WrapStyle.Through;



            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true, PdfFontEmbedding.Always);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();


            MigraDoc.Rendering.DocumentRenderer docRenderer = new DocumentRenderer(document);
            docRenderer.PrepareDocument();
            docRenderer.RenderObject(gfx, XUnit.FromCentimeter(0), XUnit.FromCentimeter(0), "18cm", paragraph);

            return pdfDocument;
        }


        public PdfDocument Generate(Candidate model)
        {            
            return CreateFirstPage(model, CreateDocument());
        }
    }
}
