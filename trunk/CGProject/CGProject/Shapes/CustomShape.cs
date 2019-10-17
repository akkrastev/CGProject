using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    public class CustomShape : BaseShape
    {
        public CustomShape(RectangleF rect) : base(rect) {


        }

        public CustomShape(RectShape rectangle) : base(rectangle)
        {

        }


        public override bool ContainsPoint(PointF point)
        {
            if (base.ContainsPoint(point))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);


            Pen blackPen = new Pen(Color.Black, 2);

            int currentX = (int)Location.X;
            int currentY = (int)Location.Y;

            // Create points that define polygon.
            Point point1 = new Point(currentX + 50, currentY + 50);
            Point point2 = new Point(currentX + 50, currentY + 100);
            Point point3 = new Point(currentX + 100, currentY + 100);
            Point point4 = new Point(currentX + 100, currentY + 50);
            Point point5 = new Point(currentX + 75, currentY + 75);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
             };
            grfx.FillPolygon(new SolidBrush(FillColor), curvePoints);
            grfx.DrawPolygon(blackPen, curvePoints);
        }





    }
}
