namespace PizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSmall_Size = new System.Windows.Forms.RadioButton();
            this.rdbLarg_Size = new System.Windows.Forms.RadioButton();
            this.rdbMeduim_Size = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbThin_Crust = new System.Windows.Forms.RadioButton();
            this.rdbThink_Crust = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlive = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbTakeAway = new System.Windows.Forms.RadioButton();
            this.rdbEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEatingPlace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConferm = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSmall_Size);
            this.groupBox1.Controls.Add(this.rdbLarg_Size);
            this.groupBox1.Controls.Add(this.rdbMeduim_Size);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(178, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rdbSmall_Size
            // 
            this.rdbSmall_Size.AutoSize = true;
            this.rdbSmall_Size.Location = new System.Drawing.Point(21, 34);
            this.rdbSmall_Size.Name = "rdbSmall_Size";
            this.rdbSmall_Size.Size = new System.Drawing.Size(88, 32);
            this.rdbSmall_Size.TabIndex = 1;
            this.rdbSmall_Size.Tag = "3";
            this.rdbSmall_Size.Text = "Small";
            this.rdbSmall_Size.UseVisualStyleBackColor = true;
            this.rdbSmall_Size.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbLarg_Size
            // 
            this.rdbLarg_Size.AutoSize = true;
            this.rdbLarg_Size.Location = new System.Drawing.Point(21, 98);
            this.rdbLarg_Size.Name = "rdbLarg_Size";
            this.rdbLarg_Size.Size = new System.Drawing.Size(75, 32);
            this.rdbLarg_Size.TabIndex = 2;
            this.rdbLarg_Size.Tag = "8";
            this.rdbLarg_Size.Text = "Larg";
            this.rdbLarg_Size.UseVisualStyleBackColor = true;
            this.rdbLarg_Size.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbMeduim_Size
            // 
            this.rdbMeduim_Size.AutoSize = true;
            this.rdbMeduim_Size.Checked = true;
            this.rdbMeduim_Size.Location = new System.Drawing.Point(21, 66);
            this.rdbMeduim_Size.Name = "rdbMeduim_Size";
            this.rdbMeduim_Size.Size = new System.Drawing.Size(113, 32);
            this.rdbMeduim_Size.TabIndex = 1;
            this.rdbMeduim_Size.TabStop = true;
            this.rdbMeduim_Size.Tag = "5";
            this.rdbMeduim_Size.Text = "Meduim";
            this.rdbMeduim_Size.UseVisualStyleBackColor = true;
            this.rdbMeduim_Size.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbThin_Crust);
            this.groupBox2.Controls.Add(this.rdbThink_Crust);
            this.groupBox2.Location = new System.Drawing.Point(15, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(178, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // rdbThin_Crust
            // 
            this.rdbThin_Crust.AutoSize = true;
            this.rdbThin_Crust.Checked = true;
            this.rdbThin_Crust.Location = new System.Drawing.Point(21, 32);
            this.rdbThin_Crust.Name = "rdbThin_Crust";
            this.rdbThin_Crust.Size = new System.Drawing.Size(115, 29);
            this.rdbThin_Crust.TabIndex = 3;
            this.rdbThin_Crust.TabStop = true;
            this.rdbThin_Crust.Tag = "0";
            this.rdbThin_Crust.Text = "Thin Crust";
            this.rdbThin_Crust.UseVisualStyleBackColor = true;
            this.rdbThin_Crust.CheckedChanged += new System.EventHandler(this.rdbThin_Crust_CheckedChanged);
            // 
            // rdbThink_Crust
            // 
            this.rdbThink_Crust.AutoSize = true;
            this.rdbThink_Crust.Location = new System.Drawing.Point(21, 67);
            this.rdbThink_Crust.Name = "rdbThink_Crust";
            this.rdbThink_Crust.Size = new System.Drawing.Size(124, 29);
            this.rdbThink_Crust.TabIndex = 4;
            this.rdbThink_Crust.Tag = "1";
            this.rdbThink_Crust.Text = "Think Crust";
            this.rdbThink_Crust.UseVisualStyleBackColor = true;
            this.rdbThink_Crust.CheckedChanged += new System.EventHandler(this.rdbThink_Crust_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkPeppers);
            this.groupBox3.Controls.Add(this.chkOlive);
            this.groupBox3.Controls.Add(this.chkTomatoes);
            this.groupBox3.Controls.Add(this.chkOnion);
            this.groupBox3.Controls.Add(this.chkMushrooms);
            this.groupBox3.Controls.Add(this.chkChees);
            this.groupBox3.Location = new System.Drawing.Point(222, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 163);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(172, 115);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(99, 29);
            this.chkPeppers.TabIndex = 10;
            this.chkPeppers.Tag = "1";
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkOlive
            // 
            this.chkOlive.AutoSize = true;
            this.chkOlive.Location = new System.Drawing.Point(172, 75);
            this.chkOlive.Name = "chkOlive";
            this.chkOlive.Size = new System.Drawing.Size(73, 29);
            this.chkOlive.TabIndex = 9;
            this.chkOlive.Tag = "1";
            this.chkOlive.Text = "Olive";
            this.chkOlive.UseVisualStyleBackColor = true;
            this.chkOlive.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(172, 40);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(115, 29);
            this.chkTomatoes.TabIndex = 8;
            this.chkTomatoes.Tag = "1";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(19, 115);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(80, 29);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(19, 75);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(131, 29);
            this.chkMushrooms.TabIndex = 6;
            this.chkMushrooms.Tag = "1";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.Location = new System.Drawing.Point(19, 40);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(129, 29);
            this.chkChees.TabIndex = 5;
            this.chkChees.Tag = "1";
            this.chkChees.Text = "Extra Chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbTakeAway);
            this.groupBox4.Controls.Add(this.rdbEatIn);
            this.groupBox4.Location = new System.Drawing.Point(227, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 130);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where to eat";
            // 
            // rdbTakeAway
            // 
            this.rdbTakeAway.AutoSize = true;
            this.rdbTakeAway.Location = new System.Drawing.Point(90, 32);
            this.rdbTakeAway.Name = "rdbTakeAway";
            this.rdbTakeAway.Size = new System.Drawing.Size(117, 29);
            this.rdbTakeAway.TabIndex = 11;
            this.rdbTakeAway.Text = "Take away";
            this.rdbTakeAway.UseVisualStyleBackColor = true;
            this.rdbTakeAway.CheckedChanged += new System.EventHandler(this.rdbTakeAway_CheckedChanged);
            // 
            // rdbEatIn
            // 
            this.rdbEatIn.AutoSize = true;
            this.rdbEatIn.Checked = true;
            this.rdbEatIn.Location = new System.Drawing.Point(90, 67);
            this.rdbEatIn.Name = "rdbEatIn";
            this.rdbEatIn.Size = new System.Drawing.Size(76, 29);
            this.rdbEatIn.TabIndex = 12;
            this.rdbEatIn.TabStop = true;
            this.rdbEatIn.Text = "Eat in";
            this.rdbEatIn.UseVisualStyleBackColor = true;
            this.rdbEatIn.CheckedChanged += new System.EventHandler(this.rdbEatIn_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbToppings);
            this.groupBox5.Controls.Add(this.lbSize);
            this.groupBox5.Controls.Add(this.lbCrustType);
            this.groupBox5.Controls.Add(this.lbPrice);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lbEatingPlace);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(590, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 324);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Your Order";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lbToppings
            // 
            this.lbToppings.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(118, 92);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(132, 55);
            this.lbToppings.TabIndex = 9;
            this.lbToppings.Text = "No Toppings";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(90, 54);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(61, 19);
            this.lbSize.TabIndex = 8;
            this.lbSize.Text = "Meduim";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(132, 151);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(42, 23);
            this.lbCrustType.TabIndex = 6;
            this.lbCrustType.Text = "Thin";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Roboto Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Green;
            this.lbPrice.Location = new System.Drawing.Point(166, 251);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(45, 35);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "5$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbEatingPlace
            // 
            this.lbEatingPlace.AutoSize = true;
            this.lbEatingPlace.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEatingPlace.Location = new System.Drawing.Point(101, 206);
            this.lbEatingPlace.Name = "lbEatingPlace";
            this.lbEatingPlace.Size = new System.Drawing.Size(65, 25);
            this.lbEatingPlace.TabIndex = 3;
            this.lbEatingPlace.Text = "Eat In";
            this.lbEatingPlace.Click += new System.EventHandler(this.lbEatingPlace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(116, 502);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 45);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConferm
            // 
            this.btnConferm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConferm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConferm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConferm.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferm.Location = new System.Drawing.Point(327, 502);
            this.btnConferm.Name = "btnConferm";
            this.btnConferm.Size = new System.Drawing.Size(140, 45);
            this.btnConferm.TabIndex = 13;
            this.btnConferm.Text = "Conferm Order";
            this.btnConferm.UseVisualStyleBackColor = false;
            this.btnConferm.Click += new System.EventHandler(this.btnConferm_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.Location = new System.Drawing.Point(590, 126);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(184, 33);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pizza Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::PizzaOrder.Properties.Resources.Screenshot_2024_02_22_223930;
            this.ClientSize = new System.Drawing.Size(914, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnConferm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLarg_Size;
        private System.Windows.Forms.RadioButton rdbMeduim_Size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSmall_Size;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkOlive;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.RadioButton rdbThin_Crust;
        private System.Windows.Forms.RadioButton rdbThink_Crust;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbTakeAway;
        private System.Windows.Forms.RadioButton rdbEatIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConferm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEatingPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}

