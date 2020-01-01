namespace PizzaOrderForm
{
    partial class OrderSummary
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
            this.pnlOrderSummary = new System.Windows.Forms.Panel();
            this.btnEditCurrentOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartNewOrder = new System.Windows.Forms.Button();
            this.txtOrderSummary = new System.Windows.Forms.TextBox();
            this.pnlOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderSummary
            // 
            this.pnlOrderSummary.AutoSize = true;
            this.pnlOrderSummary.Controls.Add(this.btnEditCurrentOrder);
            this.pnlOrderSummary.Controls.Add(this.btnExit);
            this.pnlOrderSummary.Controls.Add(this.btnStartNewOrder);
            this.pnlOrderSummary.Controls.Add(this.txtOrderSummary);
            this.pnlOrderSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderSummary.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrderSummary.Name = "pnlOrderSummary";
            this.pnlOrderSummary.Size = new System.Drawing.Size(513, 661);
            this.pnlOrderSummary.TabIndex = 0;
            // 
            // btnEditCurrentOrder
            // 
            this.btnEditCurrentOrder.Location = new System.Drawing.Point(188, 589);
            this.btnEditCurrentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCurrentOrder.Name = "btnEditCurrentOrder";
            this.btnEditCurrentOrder.Size = new System.Drawing.Size(137, 38);
            this.btnEditCurrentOrder.TabIndex = 3;
            this.btnEditCurrentOrder.Text = "Edit Current Order";
            this.btnEditCurrentOrder.UseVisualStyleBackColor = true;
            this.btnEditCurrentOrder.Click += new System.EventHandler(this.BtnEditCurrentOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(368, 589);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnStartNewOrder
            // 
            this.btnStartNewOrder.Location = new System.Drawing.Point(8, 589);
            this.btnStartNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartNewOrder.Name = "btnStartNewOrder";
            this.btnStartNewOrder.Size = new System.Drawing.Size(137, 38);
            this.btnStartNewOrder.TabIndex = 1;
            this.btnStartNewOrder.Text = "Start A New Order";
            this.btnStartNewOrder.UseVisualStyleBackColor = true;
            this.btnStartNewOrder.Click += new System.EventHandler(this.BtnStartNewOrder_Click);
            // 
            // txtOrderSummary
            // 
            this.txtOrderSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderSummary.Location = new System.Drawing.Point(0, 0);
            this.txtOrderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderSummary.Multiline = true;
            this.txtOrderSummary.Name = "txtOrderSummary";
            this.txtOrderSummary.ReadOnly = true;
            this.txtOrderSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderSummary.Size = new System.Drawing.Size(513, 555);
            this.txtOrderSummary.TabIndex = 10;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 661);
            this.Controls.Add(this.pnlOrderSummary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Summary";
            this.Load += new System.EventHandler(this.OrderSummary_Load);
            this.pnlOrderSummary.ResumeLayout(false);
            this.pnlOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderSummary;
        private System.Windows.Forms.TextBox txtOrderSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartNewOrder;
        private System.Windows.Forms.Button btnEditCurrentOrder;
    }
}