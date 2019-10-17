using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGProject.Shapes
{
    [Serializable]
    public class CircleShape : BaseShape
    {
        public CircleShape(BaseShape shape) : base(shape)
        {
        }

        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        public override bool ContainsPoint(PointF point)
        {
            if (base.ContainsPoint(point))
                return true;
            else
                return false;

        }

        public override void DrawSelf(Graphics g)
        {
            base.DrawSelf(g);

            g.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            g.DrawEllipse(new Pen(BorderColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            

        }
    }
}
