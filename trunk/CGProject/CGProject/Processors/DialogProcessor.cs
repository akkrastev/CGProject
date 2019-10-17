using CGProject.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Processors
{
    public class DialogProcessor : DisplayProcessor
    {
        private List<BaseShape> selectedItems = new List<BaseShape>();
        public List<BaseShape> SelectedItems
        {
            get { return selectedItems; }
            set { selectedItems = value; }
        }

        private bool isDragging;
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        private PointF lastLocation;
        public PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }
        
        public BaseShape ContainsPoint(PointF point)
        {
            foreach (var item in Shapes)
            {
                if(item.ContainsPoint(point))
                {
                    return item;
                }
            }
            return null;
        }
        // translate shape
        public void Translate(PointF p)
        {
            foreach (var item in SelectedItems)
            {
                item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
            }

            lastLocation = p;

        }
        // draw shape
        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);
            
            foreach (var item in SelectedItems)
            {
                grfx.DrawRectangle(Pens.Black, item.Location.X - 3, item.Location.Y - 3, item.Width + 6, item.Height + 6);
            }
        }
        // creating group of shapes
        public void CreateGroup()
        {
            if (SelectedItems.Count < 2) return; // 

            //  min and max X,Y 
            float minimumX = float.PositiveInfinity;
            float minimumY = float.PositiveInfinity;
            float maximumX = float.NegativeInfinity;
            float maximumY = float.NegativeInfinity;

            // set min and max X,Y of the selected items
            foreach (var item in SelectedItems)
            {
                if (minimumX > item.Location.X) minimumX = item.Location.X;
                if (minimumY > item.Location.Y) minimumY = item.Location.Y;
                if (maximumX < item.Location.X + item.Width) maximumX = item.Location.X + item.Width;
                if (maximumY < item.Location.Y + item.Height) maximumY = item.Location.Y + item.Height;
            }
            // creating object of type GroupShape with x,y = min x,y i wdith  and height = max x,y - min x,y
            GroupShape group = new GroupShape(new RectangleF(minimumX, minimumY, maximumX - minimumX, maximumY - minimumY));
            group.SubItems = SelectedItems;

            // add new group element to the list of selected items
            SelectedItems = new List<BaseShape>();
            SelectedItems.Add(group); 

            
            foreach (var item in group.SubItems)
            {
                Shapes.Remove(item);
            }

            Shapes.Add(group);
        }
        
        public void SplitGroup()
        {
            List<BaseShape> shapesToAdd = new List<BaseShape>();
            List<BaseShape> shapestoDelete = new List<BaseShape>();
            foreach (var item in SelectedItems)
            {
                if (item.GetType().ToString().Contains("GroupShape"))
                {

                    foreach (var subItem in item.SubItems)
                    {
                        shapesToAdd.Add(subItem);
                    }
                    
                    Shapes.Remove(item);
                    shapestoDelete.Add(item);
                }
            }
        
            foreach (var item in shapestoDelete)
            {
                SelectedItems.Remove(item);
            }
            foreach (var item in shapesToAdd)
            {
                Shapes.Add(item);
                SelectedItems.Add(item);
            }

        }

        public void IncreaseSize()
        {
            foreach (var item in SelectedItems)
            {
                if(item.GetType().ToString() == "CGProject.Shapes.LineShape")
                {
                    
                }
                else if(item.GetType().ToString() == "CGProject.Shapes.GroupShape")
                {
                    foreach(var subItem in item.SubItems)
                    {
                        if(subItem.GetType().ToString() == "CGProject.Shapes.LineShape")
                        {
                            subItem.Width += 30;
                        }
                        else
                        {
                            subItem.Width += 30;
                            subItem.Height += 30;
                        }
                    }
                    item.Width += 30;
                    item.Height += 30;
                }
                else
                {
                    item.Width += 5;
                    item.Height += 5;
                }
            }
        }

        public void ReduceSize()
        {
            foreach (var item in SelectedItems)
            {
                if (item.GetType().ToString() == "CGProject.Shapes.LineShape" && item.Width >= 10)
                {
                  
                }
                else if (item.GetType().ToString() == "CGProject.Shapes.GroupShape")
                {
                    if (item.Width >= 10 && item.Height >= 10)
                    {
                        foreach (var subItem in item.SubItems)
                        {
                            if(subItem.GetType().ToString() == "CGProject.Shapes.LineShape" && subItem.Width >= 10)
                            {
                                subItem.Width -= 5;
                            }
                            else if (subItem.Width >= 10 && subItem.Height >= 10)
                            {
                                subItem.Width -= 5;
                                subItem.Height -= 5;
                            }
                            else
                            {
                                return;
                            }
                        }
                        item.Width -= 5;
                        item.Height -= 5;
                    }
                }
                else if (item.Width >= 10 && item.Height >= 10)
                {
                    item.Width -= 5;
                    item.Height -= 5;
                }
            }
        }
        public void AddRandomCustomShape()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            CustomShape polygon = new CustomShape(new Rectangle(x, y, 100, 200));

            Shapes.Add(polygon);
        }
    }
}
