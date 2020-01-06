namespace XWang_Sokoban_GameboardDesignAndPlay
{
    partial class SokobanControlPannelForm
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
            this.btnDesign = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesign
            // 
            this.btnDesign.Location = new System.Drawing.Point(141, 89);
            this.btnDesign.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(270, 70);
            this.btnDesign.TabIndex = 0;
            this.btnDesign.Text = "Design";
            this.btnDesign.UseVisualStyleBackColor = true;
            this.btnDesign.Click += new System.EventHandler(this.BtnDesign_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(690, 89);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(270, 70);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(416, 252);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // SokobanControlPannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 373);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDesign);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SokobanControlPannelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban Control Pannel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}

