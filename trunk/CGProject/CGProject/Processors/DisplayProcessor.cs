using CGProject.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGProject.Processors
{
    public class DisplayProcessor
    {
        private List<BaseShape> shapes = new List<BaseShape>();
        public List<BaseShape> Shapes
        {
            get { return shapes; }
            set { shapes = value; }
        }
        // methods for drawing on screen
        public void ReDraw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Draw(e.Graphics);
        }

        public virtual void Draw(Graphics g)
        {
            foreach (BaseShape item in Shapes)
            {
                DrawShape(g, item);
            }
        }

        public virtual void DrawShape(Graphics g, BaseShape item)
        {
            item.DrawSelf(g);
        }

        
    }
}