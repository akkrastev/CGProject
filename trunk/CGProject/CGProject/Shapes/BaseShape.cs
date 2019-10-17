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
    public abstract class BaseShape 
    {
        #region Properties

        private RectangleF rectangle;
        public virtual RectangleF Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }

        private PointF endLinePoint;
        public virtual PointF EndLinePoint
        {
            get
            {
                endLinePoint = new PointF(Location.X+100 , Location.Y +100);
                return endLinePoint ;
            }
            set
            {
                endLinePoint = value;
            }
        }
        public virtual float Width
        {
            get { return Rectangle.Width; }
            set { rectangle.Width = value; }
        }

        public virtual float Height
        {
            get { return Rectangle.Height; }
            set { rectangle.Height = value; }
        }

        public virtual PointF Location
        {
            get { return Rectangle.Location; }
            set { rectangle.Location = value; }
        }

        private Color fillColor;
        public virtual Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        private Color borderColor;
        public virtual Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual List<BaseShape> SubItems { get; set; }

        #endregion

        public BaseShape(RectangleF rect)
        {
            rectangle = rect;
        }

        public BaseShape(BaseShape shape)
        {
            this.Height = shape.Height;
            this.Width = shape.Width;
            this.Location = shape.Location;
            this.rectangle = shape.rectangle;

            this.FillColor = shape.FillColor;
        }
        public BaseShape(RectangleF rect,PointF endlinepoint)
        {
            rectangle = rect;
            endLinePoint = endlinepoint;
        }


        public virtual bool ContainsPoint(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {
        }
    }
}
