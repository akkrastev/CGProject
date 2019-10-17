using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGProject.Processors;
using CGProject.Shapes;

namespace CGProject
{
    public partial class Form1 : Form
    {
        public int ToggleSelection = 1;
        public DialogProcessor dialogProcessor = new DialogProcessor();
        byte[] bytes;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            
        }
        // select
        private void SelectBtn_Click_1(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 1;
            selectBtn.Checked = true;
        }
        // creating rectangle
        private void RectangleBtn_Click_1(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 2;
            RectangleBtn.Checked = true;
        }
        // creating circle
        private void CircleBtn_Click_1(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 3;
            CircleBtn.Checked = true;
        }
        // creating line
        private void LineBtn_Click_1(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 4;
            LineBtn.Checked = true;
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;
        }
        // translating shapes
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if(dialogProcessor.SelectedItems.Count==1)
                {
                    currentStatus.Text = "Last action : Dragging shape";
                }
                else currentStatus.Text = "Last action : Dragging shapes";
                dialogProcessor.Translate(e.Location); 
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (ToggleSelection == 1)
            {
                string shapeType = "";
                var sel = dialogProcessor.ContainsPoint(e.Location); 
                if (sel == null) return;
                if (dialogProcessor.SelectedItems.Contains(sel)) 
                {
                    dialogProcessor.SelectedItems.Remove(sel);
                    shapeType = sel.GetType().ToString(); 
                     
                    if (shapeType.Contains("RectShape")) shapeType = "Last action : Deselected Rectangle";
                    else shapeType = "Last action : Deselected Circle";
                }
                 
                else if(sel.GetType().ToString().Contains("LineShape"))
                {
                    dialogProcessor.SelectedItems.Add((LineShape)sel);
                }
                 
                else
                {
                    dialogProcessor.SelectedItems.Add(sel);
                    shapeType = sel.GetType().ToString();
                    if (shapeType.Contains("RectShape")) shapeType = "Last action : Selected Rectangle";
                    else shapeType = "Last action : Selected Circle";
                }
                currentStatus.Text =  shapeType;
                dialogProcessor.IsDragging = true; 
                dialogProcessor.LastLocation = e.Location;
                Invalidate();

            }
            if (ToggleSelection == 2)
            {
                
                RectShape rect = new RectShape(new Rectangle(e.X - 25, e.Y-50,50,100)); 
                rect.FillColor = ColorDialog.Color; 
                rect.BorderColor = Color.Black; 
                currentStatus.Text = "Last action : Rectangle created"; 


                dialogProcessor.Shapes.Add(rect); 
                Invalidate();
            }
            
            if (ToggleSelection == 3)
            {
                CircleShape circle = new CircleShape(new Rectangle(e.X-25, e.Y-50, 100, 100));

                circle.FillColor = ColorDialog.Color;
                circle.BorderColor = Color.Black;
                dialogProcessor.Shapes.Add(circle);
                currentStatus.Text = "Last action : Circle created";
                Invalidate();
            }

            if (ToggleSelection == 4)
            {
                LineShape line = new LineShape(new Rectangle(e.X , e.Y, 100, 100),new PointF(e.X,e.Y));

                line.FillColor = ColorDialog.Color;
                if (ColorDialog.Color==Color.White) 
                {
                    line.FillColor = Color.Black;
                }
                line.BorderColor = Color.Black;
                dialogProcessor.Shapes.Add(line);
                currentStatus.Text = "Last action : Line created";
                Invalidate();
            }
            if( ToggleSelection == 5)
            {
                dialogProcessor.AddRandomCustomShape();
                Invalidate();
            }

            this.Refresh(); 
        }

        // Event method for drawing
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);

        }
        // color button
        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            foreach (var item in dialogProcessor.SelectedItems)
            {
                item.FillColor = ColorDialog.Color;

            }
            currentStatus.Text = "Last action : Changed color of selected shapes";
            Invalidate();
        }
        // exit 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
        }
        // saving file  
        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // using Binary formatter and filestream to save the file
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(this.SaveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None); // path of the file 
            formatter.Serialize(stream, dialogProcessor.Shapes); // serialize  path of the file and list of all shapes 
            stream.Close();
            currentStatus.Text = "Last action : Saved File";
        }

        // opening an existing file
        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(this.OpenFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            dialogProcessor.Shapes = (List<BaseShape>)formatter.Deserialize(stream); // Deserialization
            stream.Close();

            dialogProcessor.SelectedItems.Clear();
            SaveFileDialog.FileName = OpenFileDialog.FileName;
            currentStatus.Text = "Last action : Opened File";

            this.Refresh();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }

        // select all shapes
        private void SelectAllShapes_Click(object sender, EventArgs e)
        {
            if(dialogProcessor.SelectedItems!= dialogProcessor.Shapes)
            {
                dialogProcessor.SelectedItems = new List<BaseShape>(dialogProcessor.Shapes);
            }
            ClearCheckedButtons();
            ToggleSelection = 1;
            selectBtn.Checked = true;
            selectBtn.Select();
            Invalidate();
        }
        // delete all shapes
        private void DeleteAllShapes_Click(object sender, EventArgs e)
        {

            dialogProcessor.Shapes = new List<BaseShape>();
            dialogProcessor.SelectedItems.Clear();
            Invalidate();
        }
        // delete selected shapes
        private void DeleteSelectedShapes_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.SelectedItems)
            {
                if(dialogProcessor.Shapes.Contains(item)) 
                {
                    dialogProcessor.Shapes.Remove(item);
                }
            }
            dialogProcessor.SelectedItems.Clear();
            Invalidate();
        }

        //  clear all selected buttons in toolsrip
        private void ClearCheckedButtons()
        {
            try
            {
                foreach (ToolStripButton item in toolStrip1.Items)
                {
                    item.Checked = false;

                }
            }
            catch (Exception)
            {

            }  
        }
        // creating group of shapes
        private void CreateGroupShape_Click(object sender, EventArgs e)
        {
            dialogProcessor.CreateGroup();
            currentStatus.Text = "Created Group of Shapes";
            Invalidate();
        }

       

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, dialogProcessor.SelectedItems); 
            bytes = stream.ToArray(); 
            currentStatus.Text = "Last action : Copied Shapes";
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            stream.Write(bytes,0,bytes.Length); 
            stream.Position = 0;
            List<BaseShape> list = formatter.Deserialize(stream) as List<BaseShape>;  


            
            float offsetX = Cursor.Position.X - list.First().Location.X;
            float offsetY = Cursor.Position.Y - list.First().Location.Y;
            
            foreach (var item in list)
            {
                item.Location = new PointF(item.Location.X +offsetX, item.Location.Y + offsetY);
                dialogProcessor.Shapes.Add(item);
            }
            

            dialogProcessor.SelectedItems.Clear();
            currentStatus.Text = "Last action : Pasted Shapes";

            this.Refresh();
        }

        // split button
        private void SplitGroups_Click(object sender, EventArgs e)
        {
            dialogProcessor.SplitGroup();
            currentStatus.Text = "Splited Group of Shapes";
            Invalidate();
        }



        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // increasing size
        private void IncreaseSizeButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.IncreaseSize();
            currentStatus.Text = "Last action : Increased size of selected shapes";
            Invalidate();
        }
        // decreasing size 
        private void ReduceSizeButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.ReduceSize();
            currentStatus.Text = "Last action : Reduced size of selected shapes";
            Invalidate();
        }

        private void ColorNameButton_Click(object sender, EventArgs e)
        {
            foreach (var colorValue in Enum.GetValues(typeof(KnownColor)))
            {
                if (colorValue.ToString().ToLower() == colorNameTextBox.Text.ToLower())
                {
                    Color color = Color.FromName(colorValue.ToString());
                    ColorDialog.Color = color;
                    colorNameTextBox.Text = "";
                    foreach (var item in dialogProcessor.SelectedItems)
                    {
                        item.FillColor = ColorDialog.Color;
                    }
                    Invalidate();
                    return;
                }
 
            }
            MessageBox.Show("Color not found");
            colorNameTextBox.Text = "";
        }

        private void AddCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 3;
            CircleBtn.Checked = true;
        }

        private void AddRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 2;
            RectangleBtn.Checked = true;
        }

        private void AddLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 4;
            LineBtn.Checked = true;
        }

        private void SelectAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItems != dialogProcessor.Shapes)
            {
                dialogProcessor.SelectedItems = new List<BaseShape>(dialogProcessor.Shapes);
            }
            ClearCheckedButtons();
            ToggleSelection = 1;
            selectBtn.Checked = true;
            selectBtn.Select();
            Invalidate();
        }

        private void DeleteAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.Shapes = new List<BaseShape>();
            dialogProcessor.SelectedItems.Clear();
            Invalidate();
        }

        private void DeleteSelectedShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.SelectedItems)
            {
                if (dialogProcessor.Shapes.Contains(item)) 
                {
                    dialogProcessor.Shapes.Remove(item);
                }
            }
            dialogProcessor.SelectedItems.Clear();
            Invalidate();
        }

        private void SplitSelectedGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SplitGroup();
            currentStatus.Text = "Splited Group of Shapes";
            Invalidate();
        }

        private void GroupSelectedShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.CreateGroup();
            currentStatus.Text = "Created Group of Shapes";
            Invalidate();
        }

        private void SelectAllShapesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.SelectedItems != dialogProcessor.Shapes)
            {
                dialogProcessor.SelectedItems = new List<BaseShape>(dialogProcessor.Shapes);
            }
            ClearCheckedButtons();
            ToggleSelection = 1;
            selectBtn.Checked = true;
            selectBtn.Select();
            Invalidate();
        }

        private void DeleteSelectedShapesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.SelectedItems)
            {
                if (dialogProcessor.Shapes.Contains(item)) 
                {
                    dialogProcessor.Shapes.Remove(item);
                }
            }
            dialogProcessor.SelectedItems.Clear();
            Invalidate();
        }

        private void DeleteAllShapesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dialogProcessor.Shapes = new List<BaseShape>();
            dialogProcessor.SelectedItems.Clear();
            Invalidate();
        }

        private void CustomShape_Click(object sender, EventArgs e)
        {
            ClearCheckedButtons();
            ToggleSelection = 5;
            CustomShape.Checked = true;
        }
    }
}
