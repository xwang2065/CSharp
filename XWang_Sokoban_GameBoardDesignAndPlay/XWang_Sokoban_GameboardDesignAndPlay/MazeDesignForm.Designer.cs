namespace XWang_Sokoban_GameboardDesignAndPlay
{
    partial class MazeDesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeDesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblToolBox = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlTiles = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.rdbDestination = new System.Windows.Forms.RadioButton();
            this.rdbBox = new System.Windows.Forms.RadioButton();
            this.rdbWall = new System.Windows.Forms.RadioButton();
            this.rdbHero = new System.Windows.Forms.RadioButton();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.pnlToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1515, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "none.jpg");
            this.imageList1.Images.SetKeyName(1, "hero.png");
            this.imageList1.Images.SetKeyName(2, "wall.png");
            this.imageList1.Images.SetKeyName(3, "box.png");
            this.imageList1.Images.SetKeyName(4, "destination.png");
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Location = new System.Drawing.Point(76, 88);
            this.lblToolBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(85, 25);
            this.lblToolBox.TabIndex = 0;
            this.lblToolBox.Text = "ToolBox";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(375, 84);
            this.lblRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(50, 25);
            this.lblRow.TabIndex = 7;
            this.lblRow.Text = "Row";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(437, 80);
            this.txtRow.Margin = new System.Windows.Forms.Padding(4);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(132, 30);
            this.txtRow.TabIndex = 8;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(688, 84);
            this.lblColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(80, 25);
            this.lblColumn.TabIndex = 9;
            this.lblColumn.Text = "Column";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(780, 82);
            this.txtColumn.Margin = new System.Windows.Forms.Padding(4);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(132, 30);
            this.txtColumn.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1016, 78);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 38);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // pnlTiles
            // 
            this.pnlTiles.AutoSize = true;
            this.pnlTiles.Location = new System.Drawing.Point(380, 134);
            this.pnlTiles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Size = new System.Drawing.Size(736, 440);
            this.pnlTiles.TabIndex = 13;
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Controls.Add(this.rdbDestination);
            this.pnlToolBox.Controls.Add(this.rdbBox);
            this.pnlToolBox.Controls.Add(this.rdbWall);
            this.pnlToolBox.Controls.Add(this.rdbHero);
            this.pnlToolBox.Controls.Add(this.rdbNone);
            this.pnlToolBox.Location = new System.Drawing.Point(29, 134);
            this.pnlToolBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(223, 440);
            this.pnlToolBox.TabIndex = 14;
            // 
            // rdbDestination
            // 
            this.rdbDestination.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbDestination.BackColor = System.Drawing.SystemColors.Control;
            this.rdbDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdbDestination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbDestination.ImageIndex = 4;
            this.rdbDestination.ImageList = this.imageList1;
            this.rdbDestination.Location = new System.Drawing.Point(29, 357);
            this.rdbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDestination.Name = "rdbDestination";
            this.rdbDestination.Size = new System.Drawing.Size(160, 50);
            this.rdbDestination.TabIndex = 2;
            this.rdbDestination.TabStop = true;
            this.rdbDestination.Text = "Destination";
            this.rdbDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbDestination.UseVisualStyleBackColor = true;
            this.rdbDestination.CheckedChanged += new System.EventHandler(this.RdbTool_CheckedChanged);
            // 
            // rdbBox
            // 
            this.rdbBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbBox.BackColor = System.Drawing.SystemColors.Control;
            this.rdbBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdbBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbBox.ImageIndex = 3;
            this.rdbBox.ImageList = this.imageList1;
            this.rdbBox.Location = new System.Drawing.Point(29, 274);
            this.rdbBox.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBox.Name = "rdbBox";
            this.rdbBox.Size = new System.Drawing.Size(160, 50);
            this.rdbBox.TabIndex = 2;
            this.rdbBox.TabStop = true;
            this.rdbBox.Text = "Box";
            this.rdbBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbBox.UseVisualStyleBackColor = true;
            this.rdbBox.CheckedChanged += new System.EventHandler(this.RdbTool_CheckedChanged);
            // 
            // rdbWall
            // 
            this.rdbWall.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbWall.BackColor = System.Drawing.SystemColors.Control;
            this.rdbWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdbWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbWall.ImageKey = "wall.png";
            this.rdbWall.ImageList = this.imageList1;
            this.rdbWall.Location = new System.Drawing.Point(29, 191);
            this.rdbWall.Margin = new System.Windows.Forms.Padding(4);
            this.rdbWall.Name = "rdbWall";
            this.rdbWall.Size = new System.Drawing.Size(160, 50);
            this.rdbWall.TabIndex = 2;
            this.rdbWall.TabStop = true;
            this.rdbWall.Text = "Wall";
            this.rdbWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbWall.UseVisualStyleBackColor = true;
            this.rdbWall.CheckedChanged += new System.EventHandler(this.RdbTool_CheckedChanged);
            // 
            // rdbHero
            // 
            this.rdbHero.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbHero.BackColor = System.Drawing.SystemColors.Control;
            this.rdbHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdbHero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbHero.ImageKey = "hero.png";
            this.rdbHero.ImageList = this.imageList1;
            this.rdbHero.Location = new System.Drawing.Point(29, 108);
            this.rdbHero.Margin = new System.Windows.Forms.Padding(4);
            this.rdbHero.Name = "rdbHero";
            this.rdbHero.Size = new System.Drawing.Size(160, 50);
            this.rdbHero.TabIndex = 2;
            this.rdbHero.TabStop = true;
            this.rdbHero.Text = "Hero";
            this.rdbHero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbHero.UseVisualStyleBackColor = true;
            this.rdbHero.CheckedChanged += new System.EventHandler(this.RdbTool_CheckedChanged);
            // 
            // rdbNone
            // 
            this.rdbNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNone.BackColor = System.Drawing.SystemColors.Control;
            this.rdbNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbNone.ImageIndex = 0;
            this.rdbNone.ImageList = this.imageList1;
            this.rdbNone.Location = new System.Drawing.Point(29, 25);
            this.rdbNone.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(160, 50);
            this.rdbNone.TabIndex = 2;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "None";
            this.rdbNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbNone.UseVisualStyleBackColor = true;
            this.rdbNone.CheckedChanged += new System.EventHandler(this.RdbTool_CheckedChanged);
            // 
            // MazeDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1515, 601);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.pnlTiles);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblToolBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MazeDesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Design Form - Sokoban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlToolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlTiles;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.RadioButton rdbHero;
        private System.Windows.Forms.RadioButton rdbWall;
        private System.Windows.Forms.RadioButton rdbBox;
        private System.Windows.Forms.RadioButton rdbDestination;
        private System.Windows.Forms.Panel pnlToolBox;
        protected internal System.Windows.Forms.ImageList imageList1;
    }
}