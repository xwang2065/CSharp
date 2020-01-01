namespace PizzaOrderForm
{
    partial class OrderingForm
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
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.txtPizzaNumber = new System.Windows.Forms.TextBox();
            this.lblHowManyPizzas = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.grbCheese = new System.Windows.Forms.GroupBox();
            this.radHeavyCheese = new System.Windows.Forms.RadioButton();
            this.radNormalCheese = new System.Windows.Forms.RadioButton();
            this.radLightCheese = new System.Windows.Forms.RadioButton();
            this.radNoneCheese = new System.Windows.Forms.RadioButton();
            this.grbSauce = new System.Windows.Forms.GroupBox();
            this.radHeavySauce = new System.Windows.Forms.RadioButton();
            this.radNormalSauce = new System.Windows.Forms.RadioButton();
            this.radLightSauce = new System.Windows.Forms.RadioButton();
            this.radNoneSauce = new System.Windows.Forms.RadioButton();
            this.pnlPizzaPies = new System.Windows.Forms.Panel();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGreenOlives = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.pnlStartOrder = new System.Windows.Forms.Panel();
            this.pnlSelections = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbCheese.SuspendLayout();
            this.grbSauce.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.pnlStartOrder.SuspendLayout();
            this.pnlSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOrder.Location = new System.Drawing.Point(94, 49);
            this.btnStartOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(87, 25);
            this.btnStartOrder.TabIndex = 3;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.BtnStartOrder_Click);
            // 
            // txtPizzaNumber
            // 
            this.txtPizzaNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPizzaNumber.Location = new System.Drawing.Point(154, 21);
            this.txtPizzaNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPizzaNumber.Name = "txtPizzaNumber";
            this.txtPizzaNumber.Size = new System.Drawing.Size(28, 20);
            this.txtPizzaNumber.TabIndex = 2;
            // 
            // lblHowManyPizzas
            // 
            this.lblHowManyPizzas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHowManyPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowManyPizzas.Location = new System.Drawing.Point(11, 18);
            this.lblHowManyPizzas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHowManyPizzas.Name = "lblHowManyPizzas";
            this.lblHowManyPizzas.Size = new System.Drawing.Size(139, 20);
            this.lblHowManyPizzas.TabIndex = 1;
            this.lblHowManyPizzas.Text = "How many pizzas?";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(15, 565);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(299, 30);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialInstructions.Location = new System.Drawing.Point(15, 406);
            this.txtSpecialInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(299, 137);
            this.txtSpecialInstructions.TabIndex = 3;
            this.txtSpecialInstructions.Tag = "Special Instruction:";
            this.txtSpecialInstructions.Leave += new System.EventHandler(this.TxtSpecialInstructions_Leave);
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Location = new System.Drawing.Point(19, 391);
            this.lblSpecialInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(134, 17);
            this.lblSpecialInstructions.TabIndex = 3;
            this.lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // grbCheese
            // 
            this.grbCheese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbCheese.Controls.Add(this.radHeavyCheese);
            this.grbCheese.Controls.Add(this.radNormalCheese);
            this.grbCheese.Controls.Add(this.radLightCheese);
            this.grbCheese.Controls.Add(this.radNoneCheese);
            this.grbCheese.Location = new System.Drawing.Point(15, 293);
            this.grbCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCheese.Name = "grbCheese";
            this.grbCheese.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCheese.Size = new System.Drawing.Size(301, 76);
            this.grbCheese.TabIndex = 2;
            this.grbCheese.TabStop = false;
            this.grbCheese.Text = "Cheese";
            // 
            // radHeavyCheese
            // 
            this.radHeavyCheese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radHeavyCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHeavyCheese.Location = new System.Drawing.Point(220, 31);
            this.radHeavyCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radHeavyCheese.Name = "radHeavyCheese";
            this.radHeavyCheese.Size = new System.Drawing.Size(67, 20);
            this.radHeavyCheese.TabIndex = 4;
            this.radHeavyCheese.TabStop = true;
            this.radHeavyCheese.Tag = "Cheese: Heavy";
            this.radHeavyCheese.Text = "Heavy";
            this.radHeavyCheese.UseVisualStyleBackColor = true;
            this.radHeavyCheese.CheckedChanged += new System.EventHandler(this.RadCheese_CheckedChanged);
            // 
            // radNormalCheese
            // 
            this.radNormalCheese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNormalCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNormalCheese.Location = new System.Drawing.Point(153, 31);
            this.radNormalCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNormalCheese.Name = "radNormalCheese";
            this.radNormalCheese.Size = new System.Drawing.Size(67, 20);
            this.radNormalCheese.TabIndex = 3;
            this.radNormalCheese.TabStop = true;
            this.radNormalCheese.Tag = "Cheese: Normal";
            this.radNormalCheese.Text = "Normal";
            this.radNormalCheese.UseVisualStyleBackColor = true;
            this.radNormalCheese.CheckedChanged += new System.EventHandler(this.RadCheese_CheckedChanged);
            // 
            // radLightCheese
            // 
            this.radLightCheese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLightCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLightCheese.Location = new System.Drawing.Point(87, 31);
            this.radLightCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLightCheese.Name = "radLightCheese";
            this.radLightCheese.Size = new System.Drawing.Size(67, 20);
            this.radLightCheese.TabIndex = 2;
            this.radLightCheese.TabStop = true;
            this.radLightCheese.Tag = "Cheese: Light";
            this.radLightCheese.Text = "Light";
            this.radLightCheese.UseVisualStyleBackColor = true;
            this.radLightCheese.CheckedChanged += new System.EventHandler(this.RadCheese_CheckedChanged);
            // 
            // radNoneCheese
            // 
            this.radNoneCheese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNoneCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNoneCheese.Location = new System.Drawing.Point(20, 31);
            this.radNoneCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNoneCheese.Name = "radNoneCheese";
            this.radNoneCheese.Size = new System.Drawing.Size(67, 20);
            this.radNoneCheese.TabIndex = 1;
            this.radNoneCheese.TabStop = true;
            this.radNoneCheese.Tag = "Cheese: None";
            this.radNoneCheese.Text = "None";
            this.radNoneCheese.UseVisualStyleBackColor = true;
            this.radNoneCheese.CheckedChanged += new System.EventHandler(this.RadCheese_CheckedChanged);
            // 
            // grbSauce
            // 
            this.grbSauce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbSauce.Controls.Add(this.radHeavySauce);
            this.grbSauce.Controls.Add(this.radNormalSauce);
            this.grbSauce.Controls.Add(this.radLightSauce);
            this.grbSauce.Controls.Add(this.radNoneSauce);
            this.grbSauce.Location = new System.Drawing.Point(15, 31);
            this.grbSauce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbSauce.Name = "grbSauce";
            this.grbSauce.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbSauce.Size = new System.Drawing.Size(301, 76);
            this.grbSauce.TabIndex = 0;
            this.grbSauce.TabStop = false;
            this.grbSauce.Text = "Sauce";
            // 
            // radHeavySauce
            // 
            this.radHeavySauce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radHeavySauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHeavySauce.Location = new System.Drawing.Point(220, 29);
            this.radHeavySauce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radHeavySauce.Name = "radHeavySauce";
            this.radHeavySauce.Size = new System.Drawing.Size(67, 20);
            this.radHeavySauce.TabIndex = 4;
            this.radHeavySauce.TabStop = true;
            this.radHeavySauce.Tag = "Sauce: Heavy";
            this.radHeavySauce.Text = "Heavy";
            this.radHeavySauce.UseVisualStyleBackColor = true;
            this.radHeavySauce.CheckedChanged += new System.EventHandler(this.RadSauce_CheckedChanged);
            // 
            // radNormalSauce
            // 
            this.radNormalSauce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNormalSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNormalSauce.Location = new System.Drawing.Point(153, 29);
            this.radNormalSauce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNormalSauce.Name = "radNormalSauce";
            this.radNormalSauce.Size = new System.Drawing.Size(67, 20);
            this.radNormalSauce.TabIndex = 3;
            this.radNormalSauce.TabStop = true;
            this.radNormalSauce.Tag = "Sauce: Normal";
            this.radNormalSauce.Text = "Normal";
            this.radNormalSauce.UseVisualStyleBackColor = true;
            this.radNormalSauce.CheckedChanged += new System.EventHandler(this.RadSauce_CheckedChanged);
            // 
            // radLightSauce
            // 
            this.radLightSauce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLightSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLightSauce.Location = new System.Drawing.Point(87, 29);
            this.radLightSauce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radLightSauce.Name = "radLightSauce";
            this.radLightSauce.Size = new System.Drawing.Size(67, 20);
            this.radLightSauce.TabIndex = 2;
            this.radLightSauce.TabStop = true;
            this.radLightSauce.Tag = "Sauce: Light";
            this.radLightSauce.Text = "Light";
            this.radLightSauce.UseVisualStyleBackColor = true;
            this.radLightSauce.CheckedChanged += new System.EventHandler(this.RadSauce_CheckedChanged);
            // 
            // radNoneSauce
            // 
            this.radNoneSauce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNoneSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNoneSauce.Location = new System.Drawing.Point(20, 29);
            this.radNoneSauce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNoneSauce.Name = "radNoneSauce";
            this.radNoneSauce.Size = new System.Drawing.Size(67, 20);
            this.radNoneSauce.TabIndex = 1;
            this.radNoneSauce.TabStop = true;
            this.radNoneSauce.Tag = "Sauce: None";
            this.radNoneSauce.Text = "None";
            this.radNoneSauce.UseVisualStyleBackColor = true;
            this.radNoneSauce.CheckedChanged += new System.EventHandler(this.RadSauce_CheckedChanged);
            // 
            // pnlPizzaPies
            // 
            this.pnlPizzaPies.AutoScroll = true;
            this.pnlPizzaPies.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPizzaPies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizzaPies.Enabled = false;
            this.pnlPizzaPies.Location = new System.Drawing.Point(15, 117);
            this.pnlPizzaPies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPizzaPies.Name = "pnlPizzaPies";
            this.pnlPizzaPies.Size = new System.Drawing.Size(207, 527);
            this.pnlPizzaPies.TabIndex = 5;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(15, 27);
            this.chkPepperoni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(110, 20);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Tag = "";
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(15, 51);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(110, 20);
            this.chkMushrooms.TabIndex = 16;
            this.chkMushrooms.Tag = "";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlives.Location = new System.Drawing.Point(15, 101);
            this.chkBlackOlives.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(110, 20);
            this.chkBlackOlives.TabIndex = 1024;
            this.chkBlackOlives.Tag = "";
            this.chkBlackOlives.Text = "Olives, Black";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            this.chkBlackOlives.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(15, 76);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(110, 20);
            this.chkGreenPeppers.TabIndex = 128;
            this.chkGreenPeppers.Tag = "";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkBacon
            // 
            this.chkBacon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBacon.Location = new System.Drawing.Point(122, 28);
            this.chkBacon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(110, 20);
            this.chkBacon.TabIndex = 4;
            this.chkBacon.Tag = "";
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(229, 27);
            this.chkHam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(67, 20);
            this.chkHam.TabIndex = 8;
            this.chkHam.Tag = "";
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPineapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(122, 52);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(110, 20);
            this.chkPineapple.TabIndex = 32;
            this.chkPineapple.Tag = "";
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(122, 76);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(110, 20);
            this.chkOnion.TabIndex = 256;
            this.chkOnion.Tag = "";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkGreenOlives
            // 
            this.chkGreenOlives.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkGreenOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenOlives.Location = new System.Drawing.Point(122, 100);
            this.chkGreenOlives.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkGreenOlives.Name = "chkGreenOlives";
            this.chkGreenOlives.Size = new System.Drawing.Size(110, 20);
            this.chkGreenOlives.TabIndex = 2048;
            this.chkGreenOlives.Tag = "Topping: Olives, Green";
            this.chkGreenOlives.Text = "Olives, Green";
            this.chkGreenOlives.UseVisualStyleBackColor = true;
            this.chkGreenOlives.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkTomato
            // 
            this.chkTomato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomato.Location = new System.Drawing.Point(229, 52);
            this.chkTomato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(67, 20);
            this.chkTomato.TabIndex = 64;
            this.chkTomato.Tag = "";
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // chkSpinach
            // 
            this.chkSpinach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkSpinach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpinach.Location = new System.Drawing.Point(229, 77);
            this.chkSpinach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(67, 20);
            this.chkSpinach.TabIndex = 512;
            this.chkSpinach.Tag = "";
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.CheckedChanged += new System.EventHandler(this.ChkTopping_CheckedChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbToppings.Controls.Add(this.chkSpinach);
            this.grbToppings.Controls.Add(this.chkTomato);
            this.grbToppings.Controls.Add(this.chkGreenOlives);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkPineapple);
            this.grbToppings.Controls.Add(this.chkHam);
            this.grbToppings.Controls.Add(this.chkBacon);
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkBlackOlives);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkPepperoni);
            this.grbToppings.Location = new System.Drawing.Point(15, 132);
            this.grbToppings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbToppings.Size = new System.Drawing.Size(301, 137);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // pnlStartOrder
            // 
            this.pnlStartOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartOrder.Controls.Add(this.btnStartOrder);
            this.pnlStartOrder.Controls.Add(this.txtPizzaNumber);
            this.pnlStartOrder.Controls.Add(this.lblHowManyPizzas);
            this.pnlStartOrder.Location = new System.Drawing.Point(15, 27);
            this.pnlStartOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlStartOrder.Name = "pnlStartOrder";
            this.pnlStartOrder.Size = new System.Drawing.Size(207, 81);
            this.pnlStartOrder.TabIndex = 0;
            // 
            // pnlSelections
            // 
            this.pnlSelections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelections.Controls.Add(this.btnCheckOut);
            this.pnlSelections.Controls.Add(this.lblSpecialInstructions);
            this.pnlSelections.Controls.Add(this.grbCheese);
            this.pnlSelections.Controls.Add(this.grbSauce);
            this.pnlSelections.Controls.Add(this.txtSpecialInstructions);
            this.pnlSelections.Controls.Add(this.grbToppings);
            this.pnlSelections.Enabled = false;
            this.pnlSelections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSelections.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlSelections.Location = new System.Drawing.Point(260, 27);
            this.pnlSelections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSelections.Name = "pnlSelections";
            this.pnlSelections.Size = new System.Drawing.Size(334, 617);
            this.pnlSelections.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(622, 657);
            this.Controls.Add(this.pnlSelections);
            this.Controls.Add(this.pnlStartOrder);
            this.Controls.Add(this.pnlPizzaPies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderingForm_Load);
            this.grbCheese.ResumeLayout(false);
            this.grbSauce.ResumeLayout(false);
            this.grbToppings.ResumeLayout(false);
            this.pnlStartOrder.ResumeLayout(false);
            this.pnlStartOrder.PerformLayout();
            this.pnlSelections.ResumeLayout(false);
            this.pnlSelections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHowManyPizzas;
        private System.Windows.Forms.TextBox txtPizzaNumber;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.GroupBox grbCheese;
        private System.Windows.Forms.GroupBox grbSauce;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.RadioButton radHeavyCheese;
        private System.Windows.Forms.RadioButton radNormalCheese;
        private System.Windows.Forms.RadioButton radLightCheese;
        private System.Windows.Forms.RadioButton radNoneCheese;
        private System.Windows.Forms.RadioButton radHeavySauce;
        private System.Windows.Forms.RadioButton radNormalSauce;
        private System.Windows.Forms.RadioButton radLightSauce;
        private System.Windows.Forms.RadioButton radNoneSauce;
        private System.Windows.Forms.Panel pnlPizzaPies;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkGreenOlives;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.Panel pnlStartOrder;
        private System.Windows.Forms.Panel pnlSelections;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

