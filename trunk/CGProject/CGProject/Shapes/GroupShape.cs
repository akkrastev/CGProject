using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    [Serializable]
    public class GroupShape : BaseShape
    {
        public GroupShape(RectangleF rect) : base(rect)
        {
        }

        public GroupShape(BaseShape shape) : base(shape)
        {
        }

        public override PointF Location
        {
            set
            {
                float dx = value.X - Location.X;
                float dy = value.Y - Location.Y;

                base.Location = value;
                foreach (var item in SubItems)
                {
                    item.Location = new PointF(item.Location.X + dx,item.Location.Y + dy);
                }
            }
        }
        public override Color FillColor
        {
            set
            {
                foreach (var item in SubItems)
                {
                    item.FillColor = value;
                }
            }
        }

        public override bool ContainsPoint(PointF point)
        {
            if (base.ContainsPoint(point))
            {
                foreach (var item in SubItems)
                {
                    if (item.ContainsPoint(point)) return true;
                }
                return true;
            }
            else
                return false;
        }

        public override void DrawSelf(Graphics g)
        {
            base.DrawSelf(g);

            foreach (var item in SubItems)
            {
                item.DrawSelf(g);
            }
        }
    }
}
