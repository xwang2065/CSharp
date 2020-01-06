namespace XWang_Sokoban_GameboardDesignAndPlay
{
    partial class PlayForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlPlayBoard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfMoves = new System.Windows.Forms.TextBox();
            this.txtNumberOfPushes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlPlayBoard
            // 
            this.pnlPlayBoard.AutoScroll = true;
            this.pnlPlayBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlayBoard.Location = new System.Drawing.Point(0, 24);
            this.pnlPlayBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlayBoard.Name = "pnlPlayBoard";
            this.pnlPlayBoard.Size = new System.Drawing.Size(884, 432);
            this.pnlPlayBoard.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Moves";
            // 
            // txtNumberOfMoves
            // 
            this.txtNumberOfMoves.Location = new System.Drawing.Point(920, 107);
            this.txtNumberOfMoves.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfMoves.Name = "txtNumberOfMoves";
            this.txtNumberOfMoves.ReadOnly = true;
            this.txtNumberOfMoves.Size = new System.Drawing.Size(135, 20);
            this.txtNumberOfMoves.TabIndex = 4;
            this.txtNumberOfMoves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberOfPushes
            // 
            this.txtNumberOfPushes.Location = new System.Drawing.Point(920, 169);
            this.txtNumberOfPushes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfPushes.Name = "txtNumberOfPushes";
            this.txtNumberOfPushes.ReadOnly = true;
            this.txtNumberOfPushes.Size = new System.Drawing.Size(135, 20);
            this.txtNumberOfPushes.TabIndex = 6;
            this.txtNumberOfPushes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(917, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Pushes";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Location = new System.Drawing.Point(911, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 130);
            this.panel1.TabIndex = 7;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(2, 67);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.BtnDirection_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(110, 67);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.BtnDirection_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(56, 67);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(50, 50);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDirection_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(56, 13);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(50, 50);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnDirection_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumberOfPushes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPlayBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Play Form - Sokoban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlPlayBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfMoves;
        private System.Windows.Forms.TextBox txtNumberOfPushes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}