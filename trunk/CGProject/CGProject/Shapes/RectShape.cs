using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    [Serializable]
    public class RectShape : BaseShape
    {
        public RectShape(BaseShape shape) : base(shape)
        {
        }

        public RectShape(RectangleF rect) : base(rect)
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

            g.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height); 
            g.DrawRectangle(new Pen(BorderColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height); 
        }
    }
}