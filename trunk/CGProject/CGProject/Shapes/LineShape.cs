using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    [Serializable]
    public class LineShape : BaseShape
    {
        public float X;
        public float Y;
        public LineShape(BaseShape shape) : base(shape)
        {
        }

        public LineShape(RectangleF rect, float X, float Y) : base(rect)
        {
            this.X = X;
            this.Y = Y;
        }
        public LineShape(RectangleF rect,PointF endLinePoint) : base(rect,endLinePoint)
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
            g.DrawLine(new Pen(FillColor,3), Rectangle.X, Rectangle.Y, EndLinePoint.X, EndLinePoint.Y); 

        }
    }
}
