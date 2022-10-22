namespace J_sBurgers
{
    partial class frmMain
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
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnAddBurger = new System.Windows.Forms.Button();
            this.rdbToGo = new System.Windows.Forms.RadioButton();
            this.rdbDineIn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chxMildSauce = new System.Windows.Forms.CheckBox();
            this.chxMediumSauce = new System.Windows.Forms.CheckBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAddFry = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.chxHotSauce = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTip10 = new System.Windows.Forms.RadioButton();
            this.rdbTip15 = new System.Windows.Forms.RadioButton();
            this.rdbTip20 = new System.Windows.Forms.RadioButton();
            this.rdbNoTip = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCart
            // 
            this.lbCart.BackColor = System.Drawing.SystemColors.Info;
            this.lbCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 20;
            this.lbCart.Location = new System.Drawing.Point(12, 12);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(272, 224);
            this.lbCart.TabIndex = 0;
            // 
            // btnAddBurger
            // 
            this.btnAddBurger.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBurger.ForeColor = System.Drawing.Color.White;
            this.btnAddBurger.Location = new System.Drawing.Point(32, 257);
            this.btnAddBurger.Name = "btnAddBurger";
            this.btnAddBurger.Size = new System.Drawing.Size(75, 60);
            this.btnAddBurger.TabIndex = 1;
            this.btnAddBurger.Text = "Add Burger";
            this.btnAddBurger.UseVisualStyleBackColor = false;
            this.btnAddBurger.Click += new System.EventHandler(this.btnAddBurger_Click);
            // 
            // rdbToGo
            // 
            this.rdbToGo.AutoSize = true;
            this.rdbToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbToGo.ForeColor = System.Drawing.Color.White;
            this.rdbToGo.Location = new System.Drawing.Point(431, 224);
            this.rdbToGo.Name = "rdbToGo";
            this.rdbToGo.Size = new System.Drawing.Size(71, 24);
            this.rdbToGo.TabIndex = 9;
            this.rdbToGo.Text = "To Go";
            this.rdbToGo.UseVisualStyleBackColor = true;
            // 
            // rdbDineIn
            // 
            this.rdbDineIn.AutoSize = true;
            this.rdbDineIn.Checked = true;
            this.rdbDineIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDineIn.ForeColor = System.Drawing.Color.White;
            this.rdbDineIn.Location = new System.Drawing.Point(333, 224);
            this.rdbDineIn.Name = "rdbDineIn";
            this.rdbDineIn.Size = new System.Drawing.Size(78, 24);
            this.rdbDineIn.TabIndex = 8;
            this.rdbDineIn.TabStop = true;
            this.rdbDineIn.Text = "Dine In";
            this.rdbDineIn.UseVisualStyleBackColor = true;
            // 
            // chxMildSauce
            // 
            this.chxMildSauce.AutoSize = true;
            this.chxMildSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxMildSauce.ForeColor = System.Drawing.Color.White;
            this.chxMildSauce.Location = new System.Drawing.Point(334, 18);
            this.chxMildSauce.Name = "chxMildSauce";
            this.chxMildSauce.Size = new System.Drawing.Size(164, 24);
            this.chxMildSauce.TabIndex = 4;
            this.chxMildSauce.Text = "Mild Dipping Sauce";
            this.chxMildSauce.UseVisualStyleBackColor = true;
            // 
            // chxMediumSauce
            // 
            this.chxMediumSauce.AutoSize = true;
            this.chxMediumSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxMediumSauce.ForeColor = System.Drawing.Color.White;
            this.chxMediumSauce.Location = new System.Drawing.Point(334, 48);
            this.chxMediumSauce.Name = "chxMediumSauce";
            this.chxMediumSauce.Size = new System.Drawing.Size(192, 24);
            this.chxMediumSauce.TabIndex = 5;
            this.chxMediumSauce.Text = "Medium Dipping Sauce";
            this.chxMediumSauce.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(333, 278);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(169, 39);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAddFry
            // 
            this.btnAddFry.BackColor = System.Drawing.Color.DimGray;
            this.btnAddFry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFry.ForeColor = System.Drawing.Color.White;
            this.btnAddFry.Location = new System.Drawing.Point(113, 257);
            this.btnAddFry.Name = "btnAddFry";
            this.btnAddFry.Size = new System.Drawing.Size(75, 60);
            this.btnAddFry.TabIndex = 2;
            this.btnAddFry.Text = "Add Fry";
            this.btnAddFry.UseVisualStyleBackColor = false;
            this.btnAddFry.Click += new System.EventHandler(this.btnAddFry_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.BackColor = System.Drawing.Color.DimGray;
            this.btnAddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrink.ForeColor = System.Drawing.Color.White;
            this.btnAddDrink.Location = new System.Drawing.Point(194, 257);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(75, 60);
            this.btnAddDrink.TabIndex = 3;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = false;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // chxHotSauce
            // 
            this.chxHotSauce.AutoSize = true;
            this.chxHotSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxHotSauce.ForeColor = System.Drawing.Color.White;
            this.chxHotSauce.Location = new System.Drawing.Point(334, 78);
            this.chxHotSauce.Name = "chxHotSauce";
            this.chxHotSauce.Size = new System.Drawing.Size(162, 24);
            this.chxHotSauce.TabIndex = 6;
            this.chxHotSauce.Text = "Hot Dipping Sauce";
            this.chxHotSauce.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTip20);
            this.groupBox1.Controls.Add(this.rdbNoTip);
            this.groupBox1.Controls.Add(this.rdbTip10);
            this.groupBox1.Controls.Add(this.rdbTip15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(320, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip";
            // 
            // rdbTip10
            // 
            this.rdbTip10.AutoSize = true;
            this.rdbTip10.ForeColor = System.Drawing.Color.White;
            this.rdbTip10.Location = new System.Drawing.Point(32, 25);
            this.rdbTip10.Name = "rdbTip10";
            this.rdbTip10.Size = new System.Drawing.Size(59, 24);
            this.rdbTip10.TabIndex = 0;
            this.rdbTip10.Text = "10%";
            this.rdbTip10.UseVisualStyleBackColor = true;
            // 
            // rdbTip15
            // 
            this.rdbTip15.AutoSize = true;
            this.rdbTip15.ForeColor = System.Drawing.Color.White;
            this.rdbTip15.Location = new System.Drawing.Point(97, 25);
            this.rdbTip15.Name = "rdbTip15";
            this.rdbTip15.Size = new System.Drawing.Size(63, 24);
            this.rdbTip15.TabIndex = 1;
            this.rdbTip15.Text = "15 %";
            this.rdbTip15.UseVisualStyleBackColor = true;
            // 
            // rdbTip20
            // 
            this.rdbTip20.AutoSize = true;
            this.rdbTip20.ForeColor = System.Drawing.Color.White;
            this.rdbTip20.Location = new System.Drawing.Point(32, 59);
            this.rdbTip20.Name = "rdbTip20";
            this.rdbTip20.Size = new System.Drawing.Size(59, 24);
            this.rdbTip20.TabIndex = 2;
            this.rdbTip20.Text = "20%";
            this.rdbTip20.UseVisualStyleBackColor = true;
            // 
            // rdbNoTip
            // 
            this.rdbNoTip.AutoSize = true;
            this.rdbNoTip.Checked = true;
            this.rdbNoTip.ForeColor = System.Drawing.Color.White;
            this.rdbNoTip.Location = new System.Drawing.Point(97, 59);
            this.rdbNoTip.Name = "rdbNoTip";
            this.rdbNoTip.Size = new System.Drawing.Size(72, 24);
            this.rdbNoTip.TabIndex = 3;
            this.rdbNoTip.TabStop = true;
            this.rdbNoTip.Text = "No Tip";
            this.rdbNoTip.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(553, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chxHotSauce);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.btnAddFry);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.chxMediumSauce);
            this.Controls.Add(this.chxMildSauce);
            this.Controls.Add(this.rdbDineIn);
            this.Controls.Add(this.rdbToGo);
            this.Controls.Add(this.btnAddBurger);
            this.Controls.Add(this.lbCart);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "J\'s Burgers 🍔";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Button btnAddBurger;
        private System.Windows.Forms.RadioButton rdbToGo;
        private System.Windows.Forms.RadioButton rdbDineIn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chxMildSauce;
        private System.Windows.Forms.CheckBox chxMediumSauce;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAddFry;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.CheckBox chxHotSauce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTip20;
        private System.Windows.Forms.RadioButton rdbTip10;
        private System.Windows.Forms.RadioButton rdbTip15;
        private System.Windows.Forms.RadioButton rdbNoTip;
    }
}

