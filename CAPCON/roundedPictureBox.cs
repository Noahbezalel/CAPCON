using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CAPCON
{
    internal class roundedPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pe);
        }
    }
}
