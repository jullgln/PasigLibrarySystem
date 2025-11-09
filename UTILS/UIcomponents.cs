using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasigLibrarySystem
{
    public static class UIRounder
    {
       public static void FormRounder(Form form, int radius)
        {
            if (form == null || form.Width <= 0 || form.Height <= 0) return;

            Rectangle bounds = new Rectangle(0, 0, form.Width, form.Height);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            form.Region = new Region(path);
            form.Resize += (s, e) => FormRounder(form, radius);
        }
        public static void RoundBtn(Button button, int radius)
        {
            if (button == null || button.Width <= 0 || button.Height <= 0) return;
            Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
            button.Resize += (s, e) => RoundBtn(button, radius);
        }
    }
    public static class UIColors
    {
        //Color Palette
        public static readonly Color DarkBlue = ColorTranslator.FromHtml("#0f2e67");
        public static readonly Color VividAzure = ColorTranslator.FromHtml("#148cf0");
        public static readonly Color LightGray = ColorTranslator.FromHtml("#eeeeee");
        public static readonly Color White = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color Crimson = ColorTranslator.FromHtml("#DC143C");
    }
}
