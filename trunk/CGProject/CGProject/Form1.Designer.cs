namespace CGProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSelectedShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitSelectedGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.selectBtn = new System.Windows.Forms.ToolStripButton();
            this.RectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.CircleBtn = new System.Windows.Forms.ToolStripButton();
            this.LineBtn = new System.Windows.Forms.ToolStripButton();
            this.ColorBtn = new System.Windows.Forms.ToolStripButton();
            this.createGroupShape = new System.Windows.Forms.ToolStripButton();
            this.splitGroups = new System.Windows.Forms.ToolStripButton();
            this.selectAllShapes = new System.Windows.Forms.ToolStripButton();
            this.DeleteAllShapes = new System.Windows.Forms.ToolStripButton();
            this.deleteSelectedShapes = new System.Windows.Forms.ToolStripButton();
            this.IncreaseSizeButton = new System.Windows.Forms.ToolStripButton();
            this.ReduceSizeButton = new System.Windows.Forms.ToolStripButton();
            this.colorNameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ColorNameButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllShapesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedShapesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllShapesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomShape = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorDialog
            // 
            this.ColorDialog.Color = System.Drawing.Color.White;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // currentStatus
            // 
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(77, 17);
            this.currentStatus.Text = "currentStatus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.shapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllShapesToolStripMenuItem,
            this.deleteAllShapesToolStripMenuItem,
            this.deleteSelectedShapesToolStripMenuItem,
            this.groupSelectedShapesToolStripMenuItem,
            this.splitSelectedGroupsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllShapesToolStripMenuItem
            // 
            this.selectAllShapesToolStripMenuItem.Name = "selectAllShapesToolStripMenuItem";
            this.selectAllShapesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.selectAllShapesToolStripMenuItem.Text = "Select All Shape(s)";
            this.selectAllShapesToolStripMenuItem.Click += new System.EventHandler(this.SelectAllShapesToolStripMenuItem_Click);
            // 
            // deleteAllShapesToolStripMenuItem
            // 
            this.deleteAllShapesToolStripMenuItem.Name = "deleteAllShapesToolStripMenuItem";
            this.deleteAllShapesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deleteAllShapesToolStripMenuItem.Text = "Delete All Shape(s)";
            this.deleteAllShapesToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllShapesToolStripMenuItem_Click);
            // 
            // deleteSelectedShapesToolStripMenuItem
            // 
            this.deleteSelectedShapesToolStripMenuItem.Name = "deleteSelectedShapesToolStripMenuItem";
            this.deleteSelectedShapesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deleteSelectedShapesToolStripMenuItem.Text = "Delete Selected Shape(s)";
            this.deleteSelectedShapesToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedShapesToolStripMenuItem_Click);
            // 
            // groupSelectedShapesToolStripMenuItem
            // 
            this.groupSelectedShapesToolStripMenuItem.Name = "groupSelectedShapesToolStripMenuItem";
            this.groupSelectedShapesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.groupSelectedShapesToolStripMenuItem.Text = "Group Selected Shape(s)";
            this.groupSelectedShapesToolStripMenuItem.Click += new System.EventHandler(this.GroupSelectedShapesToolStripMenuItem_Click);
            // 
            // splitSelectedGroupsToolStripMenuItem
            // 
            this.splitSelectedGroupsToolStripMenuItem.Name = "splitSelectedGroupsToolStripMenuItem";
            this.splitSelectedGroupsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.splitSelectedGroupsToolStripMenuItem.Text = "Split Selected Group(s)";
            this.splitSelectedGroupsToolStripMenuItem.Click += new System.EventHandler(this.SplitSelectedGroupsToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCircleToolStripMenuItem,
            this.addRectangleToolStripMenuItem,
            this.addLineToolStripMenuItem});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // addCircleToolStripMenuItem
            // 
            this.addCircleToolStripMenuItem.Name = "addCircleToolStripMenuItem";
            this.addCircleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addCircleToolStripMenuItem.Text = "Add Circle";
            this.addCircleToolStripMenuItem.Click += new System.EventHandler(this.AddCircleToolStripMenuItem_Click);
            // 
            // addRectangleToolStripMenuItem
            // 
            this.addRectangleToolStripMenuItem.Name = "addRectangleToolStripMenuItem";
            this.addRectangleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addRectangleToolStripMenuItem.Text = "Add Rectangle";
            this.addRectangleToolStripMenuItem.Click += new System.EventHandler(this.AddRectangleToolStripMenuItem_Click);
            // 
            // addLineToolStripMenuItem
            // 
            this.addLineToolStripMenuItem.Name = "addLineToolStripMenuItem";
            this.addLineToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addLineToolStripMenuItem.Text = "Add Line";
            this.addLineToolStripMenuItem.Click += new System.EventHandler(this.AddLineToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectBtn,
            this.RectangleBtn,
            this.CircleBtn,
            this.LineBtn,
            this.ColorBtn,
            this.createGroupShape,
            this.splitGroups,
            this.selectAllShapes,
            this.DeleteAllShapes,
            this.deleteSelectedShapes,
            this.IncreaseSizeButton,
            this.ReduceSizeButton,
            this.colorNameTextBox,
            this.ColorNameButton,
            this.CustomShape});
            this.toolStrip1.Location = new System.Drawing.Point(0, 512);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1009, 50);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // selectBtn
            // 
            this.selectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectBtn.Image")));
            this.selectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(27, 47);
            this.selectBtn.Text = "Select";
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click_1);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("RectangleBtn.Image")));
            this.RectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(27, 47);
            this.RectangleBtn.Text = "Create Rectangle";
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click_1);
            // 
            // CircleBtn
            // 
            this.CircleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleBtn.Image = ((System.Drawing.Image)(resources.GetObject("CircleBtn.Image")));
            this.CircleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(27, 47);
            this.CircleBtn.Text = "Create Circle";
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click_1);
            // 
            // LineBtn
            // 
            this.LineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBtn.Image = ((System.Drawing.Image)(resources.GetObject("LineBtn.Image")));
            this.LineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(27, 47);
            this.LineBtn.Text = "Create Line";
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click_1);
            // 
            // ColorBtn
            // 
            this.ColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("ColorBtn.Image")));
            this.ColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(27, 47);
            this.ColorBtn.Text = "Change Color";
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // createGroupShape
            // 
            this.createGroupShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createGroupShape.Image = ((System.Drawing.Image)(resources.GetObject("createGroupShape.Image")));
            this.createGroupShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createGroupShape.Name = "createGroupShape";
            this.createGroupShape.Size = new System.Drawing.Size(27, 47);
            this.createGroupShape.Text = "Create Group";
            this.createGroupShape.Click += new System.EventHandler(this.CreateGroupShape_Click);
            // 
            // splitGroups
            // 
            this.splitGroups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.splitGroups.Image = ((System.Drawing.Image)(resources.GetObject("splitGroups.Image")));
            this.splitGroups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.splitGroups.Name = "splitGroups";
            this.splitGroups.Size = new System.Drawing.Size(27, 47);
            this.splitGroups.Text = "Split Selected Groups";
            this.splitGroups.Click += new System.EventHandler(this.SplitGroups_Click);
            // 
            // selectAllShapes
            // 
            this.selectAllShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllShapes.Image = ((System.Drawing.Image)(resources.GetObject("selectAllShapes.Image")));
            this.selectAllShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllShapes.Name = "selectAllShapes";
            this.selectAllShapes.Size = new System.Drawing.Size(27, 47);
            this.selectAllShapes.Text = "Select All Shapes ";
            this.selectAllShapes.Click += new System.EventHandler(this.SelectAllShapes_Click);
            // 
            // DeleteAllShapes
            // 
            this.DeleteAllShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteAllShapes.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAllShapes.Image")));
            this.DeleteAllShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteAllShapes.Name = "DeleteAllShapes";
            this.DeleteAllShapes.Size = new System.Drawing.Size(27, 47);
            this.DeleteAllShapes.Text = "Delete All Shapes";
            this.DeleteAllShapes.Click += new System.EventHandler(this.DeleteAllShapes_Click);
            // 
            // deleteSelectedShapes
            // 
            this.deleteSelectedShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteSelectedShapes.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedShapes.Image")));
            this.deleteSelectedShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteSelectedShapes.Name = "deleteSelectedShapes";
            this.deleteSelectedShapes.Size = new System.Drawing.Size(27, 47);
            this.deleteSelectedShapes.Text = "Delete Selected Shapes";
            this.deleteSelectedShapes.Click += new System.EventHandler(this.DeleteSelectedShapes_Click);
            // 
            // IncreaseSizeButton
            // 
            this.IncreaseSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncreaseSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseSizeButton.Image")));
            this.IncreaseSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncreaseSizeButton.Name = "IncreaseSizeButton";
            this.IncreaseSizeButton.Size = new System.Drawing.Size(27, 47);
            this.IncreaseSizeButton.Text = "Increase Size";
            this.IncreaseSizeButton.Click += new System.EventHandler(this.IncreaseSizeButton_Click);
            // 
            // ReduceSizeButton
            // 
            this.ReduceSizeButton.CheckOnClick = true;
            this.ReduceSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReduceSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("ReduceSizeButton.Image")));
            this.ReduceSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReduceSizeButton.Name = "ReduceSizeButton";
            this.ReduceSizeButton.Size = new System.Drawing.Size(27, 47);
            this.ReduceSizeButton.Text = "Reduce Size";
            this.ReduceSizeButton.Click += new System.EventHandler(this.ReduceSizeButton_Click);
            // 
            // colorNameTextBox
            // 
            this.colorNameTextBox.Name = "colorNameTextBox";
            this.colorNameTextBox.Size = new System.Drawing.Size(100, 50);
            // 
            // ColorNameButton
            // 
            this.ColorNameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorNameButton.Image = ((System.Drawing.Image)(resources.GetObject("ColorNameButton.Image")));
            this.ColorNameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorNameButton.Name = "ColorNameButton";
            this.ColorNameButton.Size = new System.Drawing.Size(27, 47);
            this.ColorNameButton.Text = "toolStripButton1";
            this.ColorNameButton.Click += new System.EventHandler(this.ColorNameButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "CGP files (*.cgp)|*.cgp";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllShapesToolStripMenuItem1,
            this.deleteSelectedShapesToolStripMenuItem1,
            this.deleteAllShapesToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 136);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // selectAllShapesToolStripMenuItem1
            // 
            this.selectAllShapesToolStripMenuItem1.Name = "selectAllShapesToolStripMenuItem1";
            this.selectAllShapesToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.selectAllShapesToolStripMenuItem1.Text = "Select All Shapes";
            this.selectAllShapesToolStripMenuItem1.Click += new System.EventHandler(this.SelectAllShapesToolStripMenuItem1_Click);
            // 
            // deleteSelectedShapesToolStripMenuItem1
            // 
            this.deleteSelectedShapesToolStripMenuItem1.Name = "deleteSelectedShapesToolStripMenuItem1";
            this.deleteSelectedShapesToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.deleteSelectedShapesToolStripMenuItem1.Text = "Delete Selected Shapes";
            this.deleteSelectedShapesToolStripMenuItem1.Click += new System.EventHandler(this.DeleteSelectedShapesToolStripMenuItem1_Click);
            // 
            // deleteAllShapesToolStripMenuItem1
            // 
            this.deleteAllShapesToolStripMenuItem1.Name = "deleteAllShapesToolStripMenuItem1";
            this.deleteAllShapesToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.deleteAllShapesToolStripMenuItem1.Text = "Delete All Shapes";
            this.deleteAllShapesToolStripMenuItem1.Click += new System.EventHandler(this.DeleteAllShapesToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // CustomShape
            // 
            this.CustomShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CustomShape.Image = ((System.Drawing.Image)(resources.GetObject("CustomShape.Image")));
            this.CustomShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CustomShape.Name = "CustomShape";
            this.CustomShape.Size = new System.Drawing.Size(27, 47);
            this.CustomShape.Text = "toolStripButton1";
            this.CustomShape.Click += new System.EventHandler(this.CustomShape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 584);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentStatus;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton selectBtn;
        private System.Windows.Forms.ToolStripButton RectangleBtn;
        private System.Windows.Forms.ToolStripButton CircleBtn;
        private System.Windows.Forms.ToolStripButton LineBtn;
        private System.Windows.Forms.ToolStripButton ColorBtn;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem addLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton selectAllShapes;
        private System.Windows.Forms.ToolStripButton DeleteAllShapes;
        private System.Windows.Forms.ToolStripButton deleteSelectedShapes;
        private System.Windows.Forms.ToolStripMenuItem selectAllShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton createGroupShape;
        private System.Windows.Forms.ToolStripMenuItem groupSelectedShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitSelectedGroupsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton splitGroups;
        private System.Windows.Forms.ToolStripButton IncreaseSizeButton;
        private System.Windows.Forms.ToolStripButton ReduceSizeButton;
        private System.Windows.Forms.ToolStripTextBox colorNameTextBox;
        private System.Windows.Forms.ToolStripButton ColorNameButton;
        private System.Windows.Forms.ToolStripMenuItem selectAllShapesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedShapesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllShapesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton CustomShape;
    }
}

