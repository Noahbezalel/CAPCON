using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ArtanComponent
{
    public class ArtanPanel : Panel
    {
        //fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //constructor
        public ArtanPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        //properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
        }

        //methods
        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        //override OnResize to update the region
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            if (borderRadius > 2)
            {
                var rectangleF = new RectangleF(0, 0, Width, Height);
                using (var graphicsPath = GetArtanPath(rectangleF, borderRadius))
                {
                    this.Region = new Region(graphicsPath);
                }
            }
            else
            {
                this.Region = null;
            }
        }

        //override method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brushArtan = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.gradientAngle))
            {
                e.Graphics.FillRectangle(brushArtan, ClientRectangle);
            }

            //borderradius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (var graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (var pen = new Pen(this.Parent.BackColor, 2))
                {
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
        }
    }
}