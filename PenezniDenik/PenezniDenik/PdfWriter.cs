using System;
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp;
using PdfSharp.Pdf.IO;
namespace Graphics
{

    public class PdfWriter : PDFbase
    {
        PdfDocument document;
        public PdfWriter()
        {    // Create a new PDF document
            document = new PdfDocument();
        }
        public void HelloWord() {

           document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            //XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            // Create a font
            XFont font = new XFont("Times New Roman", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            // Save the document...
            const string filename = "HelloWorld_tempfile.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        
        }
        public void PrijmovyPokladniDoklad() {


            string filename = String.Format("tempfile.pdf", Guid.NewGuid().ToString("D").ToUpper());


            int cislo = 1234554666;
            String datum ="24.07.2014";
            double DPH = 21;
            double cenaBezDPH = 100;
            double DPHzCeny = (DPH / 100) * cenaBezDPH;
            double cenenaCelkem = DPHzCeny + cenaBezDPH;
            String cenaSlovy= "stodvacetjedna";
            String prijatoOd="Apple asdjaosidjaosidasoidjasoijdoasij dasibdoaisjdbisuahd ajbsdoahus bj";
            double DIC=12222222;
            String ucelPlatby="vypalne";
       
            int number = 1;

            PdfPage page = document.AddPage();
            page.Size = PageSize.A4;
            XGraphics gfx = XGraphics.FromPdfPage(page);


          
            XFont font = new XFont("Tahoma", 15, XFontStyle.Bold,new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always));
            XFont font2 = new XFont("Tahoma", 11, XFontStyle.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always));

           

             BeginBox(gfx, number);
             
             gfx.DrawString("Prijmový pokladní doklad", font, XBrushes.Black, new XRect(24,11,195,18), XStringFormats.TopLeft);
                   
             gfx.DrawString("č."+ cislo.ToString(), font2, XBrushes.Black, new XRect(222, 14, 71, 13), XStringFormats.TopLeft);

             gfx.DrawString("ze dne " + datum, font2, XBrushes.Black, new XRect(295, 14, 104, 13), XStringFormats.TopLeft);
                         
            //razitko
            XRect r = new XRect(24, 35, 204, 86);
            gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), r, new XSize(15 + 8, 15 + 8));
            r.Inflate(-2, -2);
            gfx.DrawRoundedRectangle(new XSolidBrush(this.backColor2), r, new XSize(15 + 8, 15 + 8));
            

            gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), new XRect(310, 38, 80, 21), new XSize(3 + 8, 3 + 8));
            gfx.DrawString("Cena bez DPH", font2, XBrushes.Black, new XRect(235, 42, 70, 13), XStringFormats.TopLeft);
            gfx.DrawString(cenaBezDPH.ToString()+" Kč", font2, XBrushes.Black, new XRect(315, 42, 70, 13), XStringFormats.TopLeft);
           
            
            gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), new XRect(310, 68, 80, 21), new XSize(3 + 8, 3 + 8));
            gfx.DrawString("+ "+DPH+"% DPH", font2, XBrushes.Black, new XRect(235, 72, 70, 13), XStringFormats.TopLeft);
            gfx.DrawString(DPHzCeny.ToString() + " Kč", font2, XBrushes.Black, new XRect(315, 72, 70, 13), XStringFormats.TopLeft);

            gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), new XRect(310, 98, 80, 21), new XSize(3 + 8, 3 + 8));
            gfx.DrawString("Celkem Kč", font2, XBrushes.Black, new XRect(235, 102, 70, 13), XStringFormats.TopLeft);
            gfx.DrawString(cenenaCelkem.ToString() , font2, XBrushes.Black, new XRect(315, 102, 70, 13), XStringFormats.TopLeft);

            gfx.DrawString("Slovy", font2, XBrushes.Black, new XRect(24, 132, 40, 21), XStringFormats.TopLeft);
            gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), new XRect(55, 128, 335, 21), new XSize(3 + 8, 3 + 8));
            gfx.DrawString(cenaSlovy, font2, XBrushes.Black, new XRect(55, 128, 335, 21), XStringFormats.Center);

            gfx.DrawString("Přijato od ", font2, XBrushes.Black, new XRect(24, 168, 30, 21), XStringFormats.TopLeft);
            if (prijatoOd.Length > 60)
            {
                int devider = prijatoOd.IndexOf(" ", 50);
          
                gfx.DrawString( prijatoOd.Substring(0, devider), font2, XBrushes.Black, new XRect(76, 168, 335, 21), XStringFormats.TopLeft);
                gfx.DrawString(prijatoOd.Substring(devider,prijatoOd.Length-devider), font2, XBrushes.Black, new XRect(24, 188, 240, 21), XStringFormats.Center);
            }
            gfx.DrawString("DIČ "+DIC, font2, XBrushes.Black, new XRect(275, 193, 335, 21), XStringFormats.TopLeft);

            gfx.DrawString("Účel platby ", font2, XBrushes.Black, new XRect(24, 220, 30, 21), XStringFormats.TopLeft);
            gfx.DrawString(ucelPlatby, font2, XBrushes.Black, new XRect(85, 220, 335, 21), XStringFormats.TopLeft);

            gfx.DrawString("Přijal:", font2, XBrushes.Black, new XRect(207, 242, 219, 45), XStringFormats.TopLeft);


            EndBox(gfx);


       // Save the s_document...
            try
            {
                document.Save(filename);
            }
            catch(Exception e){
                filename += "(1)";
            }
      // ...and start a viewer
      Process.Start(filename);

        }
     
    }


}
