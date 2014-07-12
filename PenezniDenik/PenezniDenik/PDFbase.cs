using System;
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PenezniDenik;

namespace Graphics
{
    /// <summary>
    /// The base class with some helper functions.
    /// </summary>
    public class PDFbase
    {
        protected XColor backColor = XColor.FromKnownColor(XKnownColor.WhiteSmoke);
        protected XColor backColor2;
        protected XColor shadowColor = XColor.FromKnownColor(XKnownColor.DarkGray);
        protected double borderWidth;
        protected XPen borderPen;
        protected int width = 595;
        protected int height = 842;

        protected PDFbase()
        {
            this.backColor = XColors.Ivory;
            this.backColor2 = XColors.WhiteSmoke;

            this.backColor = XColor.FromArgb(212, 224, 240);
            this.backColor2 = XColor.FromArgb(253, 254, 254);

            this.shadowColor = XColors.Gainsboro;
            this.borderWidth = 4.5;
            this.borderPen = new XPen(XColor.FromArgb(94, 118, 151), this.borderWidth);//new XPen(XColors.SteelBlue, this.borderWidth);
        }

   

        /// <summary>
        /// Draws a sample box.
        /// </summary>
        public void BeginBox(XGraphics gfx, int number)
        {
            //obracene XY
            gfx.RotateAtTransform(90.0, new XPoint(height / 4, width / 4));
            gfx.TranslateTransform(+62, +63);
            //const int dEllipse = 15;
            XRect rect = new XRect(0, 0, height /2 -2, width/2 -2);
            
            if (number % 2 == 0)
                rect.X += height/2 +2;
            rect.Y =  ((number - 1) / 2) * (-width/2 - 3);
            //rect.Inflate(-10, -10);
            //XRect rect2 = rect;


            XPen pen = new XPen(XColors.Black, 1);

            gfx.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

            //rect2.Offset(this.borderWidth, this.borderWidth);
            //gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), rect2, new XSize(dEllipse + 8, dEllipse + 8));
            //XLinearGradientBrush brush = new XLinearGradientBrush(rect, this.backColor, this.backColor2, XLinearGradientMode.Vertical);
            //gfx.DrawRoundedRectangle(this.borderPen, brush, rect, new XSize(dEllipse, dEllipse));
            //rect.Inflate(-5, -5);

          

            //rect.Inflate(-10, -5);
            //rect.Y += 20;
            //rect.Height -= 20;
            ////gfx.DrawRectangle(XPens.Red, rect);

            
        //    gfx.TranslateTransform(rect.X, rect.Y);
       
          
            this.state = gfx.Save();
           
        }

        public void EndBox(XGraphics gfx)
        {
           
            gfx.Restore(this.state);
            gfx.TranslateTransform(-62, -63);
            gfx.RotateAtTransform(-90.0, new XPoint(height / 4, width / 4));
        }

      

        XGraphicsState state;
    }
}
