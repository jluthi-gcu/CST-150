namespace CaloriesTracker
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
            this.txtFatGrams = new System.Windows.Forms.TextBox();
            this.btnCalcFatCalories = new System.Windows.Forms.Button();
            this.lblFatGrams = new System.Windows.Forms.Label();
            this.lblCarbGrams = new System.Windows.Forms.Label();
            this.lblCarbCalories = new System.Windows.Forms.Label();
            this.lblOutputFatCalories = new System.Windows.Forms.Label();
            this.lblFatCalories = new System.Windows.Forms.Label();
            this.gbFat = new System.Windows.Forms.GroupBox();
            this.gbCarb = new System.Windows.Forms.GroupBox();
            this.txtCarbGrams = new System.Windows.Forms.TextBox();
            this.lblOutputCarbCalories = new System.Windows.Forms.Label();
            this.btnCalcCarbCalories = new System.Windows.Forms.Button();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.lblOutputTotalCalories = new System.Windows.Forms.Label();
            this.gbFat.SuspendLayout();
            this.gbCarb.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFatGrams
            // 
            this.txtFatGrams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFatGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatGrams.ForeColor = System.Drawing.Color.Black;
            this.txtFatGrams.Location = new System.Drawing.Point(111, 20);
            this.txtFatGrams.Margin = new System.Windows.Forms.Padding(4);
            this.txtFatGrams.Name = "txtFatGrams";
            this.txtFatGrams.Size = new System.Drawing.Size(254, 22);
            this.txtFatGrams.TabIndex = 0;
            // 
            // btnCalcFatCalories
            // 
            this.btnCalcFatCalories.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcFatCalories.ForeColor = System.Drawing.Color.White;
            this.btnCalcFatCalories.Location = new System.Drawing.Point(241, 68);
            this.btnCalcFatCalories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcFatCalories.Name = "btnCalcFatCalories";
            this.btnCalcFatCalories.Size = new System.Drawing.Size(124, 30);
            this.btnCalcFatCalories.TabIndex = 2;
            this.btnCalcFatCalories.Text = "Calculate";
            this.btnCalcFatCalories.UseVisualStyleBackColor = false;
            this.btnCalcFatCalories.Click += new System.EventHandler(this.btnCalcFatCalories_Click);
            // 
            // lblFatGrams
            // 
            this.lblFatGrams.AutoSize = true;
            this.lblFatGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatGrams.ForeColor = System.Drawing.Color.White;
            this.lblFatGrams.Location = new System.Drawing.Point(32, 23);
            this.lblFatGrams.Name = "lblFatGrams";
            this.lblFatGrams.Size = new System.Drawing.Size(72, 16);
            this.lblFatGrams.TabIndex = 3;
            this.lblFatGrams.Text = "Fat Grams:";
            // 
            // lblCarbGrams
            // 
            this.lblCarbGrams.AutoSize = true;
            this.lblCarbGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbGrams.ForeColor = System.Drawing.Color.White;
            this.lblCarbGrams.Location = new System.Drawing.Point(22, 23);
            this.lblCarbGrams.Name = "lblCarbGrams";
            this.lblCarbGrams.Size = new System.Drawing.Size(82, 16);
            this.lblCarbGrams.TabIndex = 3;
            this.lblCarbGrams.Text = "Carb Grams:";
            // 
            // lblCarbCalories
            // 
            this.lblCarbCalories.AutoSize = true;
            this.lblCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbCalories.ForeColor = System.Drawing.Color.White;
            this.lblCarbCalories.Location = new System.Drawing.Point(12, 51);
            this.lblCarbCalories.Name = "lblCarbCalories";
            this.lblCarbCalories.Size = new System.Drawing.Size(92, 16);
            this.lblCarbCalories.TabIndex = 4;
            this.lblCarbCalories.Text = "Carb Calories:";
            // 
            // lblOutputFatCalories
            // 
            this.lblOutputFatCalories.AutoSize = true;
            this.lblOutputFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFatCalories.ForeColor = System.Drawing.Color.Black;
            this.lblOutputFatCalories.Location = new System.Drawing.Point(107, 48);
            this.lblOutputFatCalories.Name = "lblOutputFatCalories";
            this.lblOutputFatCalories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOutputFatCalories.Size = new System.Drawing.Size(11, 16);
            this.lblOutputFatCalories.TabIndex = 1;
            this.lblOutputFatCalories.Text = "-";
            // 
            // lblFatCalories
            // 
            this.lblFatCalories.AutoSize = true;
            this.lblFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatCalories.ForeColor = System.Drawing.Color.White;
            this.lblFatCalories.Location = new System.Drawing.Point(22, 48);
            this.lblFatCalories.Name = "lblFatCalories";
            this.lblFatCalories.Size = new System.Drawing.Size(82, 16);
            this.lblFatCalories.TabIndex = 4;
            this.lblFatCalories.Text = "Fat Calories:";
            // 
            // gbFat
            // 
            this.gbFat.Controls.Add(this.txtFatGrams);
            this.gbFat.Controls.Add(this.lblOutputFatCalories);
            this.gbFat.Controls.Add(this.lblFatGrams);
            this.gbFat.Controls.Add(this.lblFatCalories);
            this.gbFat.Controls.Add(this.btnCalcFatCalories);
            this.gbFat.ForeColor = System.Drawing.Color.White;
            this.gbFat.Location = new System.Drawing.Point(17, 12);
            this.gbFat.Name = "gbFat";
            this.gbFat.Size = new System.Drawing.Size(379, 111);
            this.gbFat.TabIndex = 0;
            this.gbFat.TabStop = false;
            // 
            // gbCarb
            // 
            this.gbCarb.Controls.Add(this.txtCarbGrams);
            this.gbCarb.Controls.Add(this.lblOutputCarbCalories);
            this.gbCarb.Controls.Add(this.btnCalcCarbCalories);
            this.gbCarb.Controls.Add(this.lblCarbCalories);
            this.gbCarb.Controls.Add(this.lblCarbGrams);
            this.gbCarb.ForeColor = System.Drawing.Color.White;
            this.gbCarb.Location = new System.Drawing.Point(17, 129);
            this.gbCarb.Name = "gbCarb";
            this.gbCarb.Size = new System.Drawing.Size(379, 111);
            this.gbCarb.TabIndex = 1;
            this.gbCarb.TabStop = false;
            // 
            // txtCarbGrams
            // 
            this.txtCarbGrams.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCarbGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarbGrams.ForeColor = System.Drawing.Color.Black;
            this.txtCarbGrams.Location = new System.Drawing.Point(111, 20);
            this.txtCarbGrams.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarbGrams.Name = "txtCarbGrams";
            this.txtCarbGrams.Size = new System.Drawing.Size(254, 22);
            this.txtCarbGrams.TabIndex = 0;
            // 
            // lblOutputCarbCalories
            // 
            this.lblOutputCarbCalories.AutoSize = true;
            this.lblOutputCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputCarbCalories.ForeColor = System.Drawing.Color.Black;
            this.lblOutputCarbCalories.Location = new System.Drawing.Point(107, 51);
            this.lblOutputCarbCalories.Name = "lblOutputCarbCalories";
            this.lblOutputCarbCalories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOutputCarbCalories.Size = new System.Drawing.Size(11, 16);
            this.lblOutputCarbCalories.TabIndex = 1;
            this.lblOutputCarbCalories.Text = "-";
            // 
            // btnCalcCarbCalories
            // 
            this.btnCalcCarbCalories.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCarbCalories.ForeColor = System.Drawing.Color.White;
            this.btnCalcCarbCalories.Location = new System.Drawing.Point(241, 68);
            this.btnCalcCarbCalories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcCarbCalories.Name = "btnCalcCarbCalories";
            this.btnCalcCarbCalories.Size = new System.Drawing.Size(124, 30);
            this.btnCalcCarbCalories.TabIndex = 2;
            this.btnCalcCarbCalories.Text = "Calculate";
            this.btnCalcCarbCalories.UseVisualStyleBackColor = false;
            this.btnCalcCarbCalories.Click += new System.EventHandler(this.btnCalcCarbCalories_Click);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalories.ForeColor = System.Drawing.Color.White;
            this.lblTotalCalories.Location = new System.Drawing.Point(25, 253);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(94, 16);
            this.lblTotalCalories.TabIndex = 4;
            this.lblTotalCalories.Text = "Total Calories:";
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalcTotal.Location = new System.Drawing.Point(221, 283);
            this.btnCalcTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(175, 30);
            this.btnCalcTotal.TabIndex = 3;
            this.btnCalcTotal.Text = "Calculate Total";
            this.btnCalcTotal.UseVisualStyleBackColor = false;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // lblOutputTotalCalories
            // 
            this.lblOutputTotalCalories.AutoSize = true;
            this.lblOutputTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputTotalCalories.ForeColor = System.Drawing.Color.Black;
            this.lblOutputTotalCalories.Location = new System.Drawing.Point(125, 253);
            this.lblOutputTotalCalories.Name = "lblOutputTotalCalories";
            this.lblOutputTotalCalories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOutputTotalCalories.Size = new System.Drawing.Size(11, 16);
            this.lblOutputTotalCalories.TabIndex = 2;
            this.lblOutputTotalCalories.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 339);
            this.Controls.Add(this.lblOutputTotalCalories);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.gbCarb);
            this.Controls.Add(this.gbFat);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calories Tracker";
            this.gbFat.ResumeLayout(false);
            this.gbFat.PerformLayout();
            this.gbCarb.ResumeLayout(false);
            this.gbCarb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFatGrams;
        private System.Windows.Forms.Button btnCalcFatCalories;
        private System.Windows.Forms.Label lblFatGrams;
        private System.Windows.Forms.Label lblCarbGrams;
        private System.Windows.Forms.Label lblCarbCalories;
        private System.Windows.Forms.Label lblOutputFatCalories;
        private System.Windows.Forms.Label lblFatCalories;
        private System.Windows.Forms.GroupBox gbFat;
        private System.Windows.Forms.GroupBox gbCarb;
        private System.Windows.Forms.TextBox txtCarbGrams;
        private System.Windows.Forms.Label lblOutputCarbCalories;
        private System.Windows.Forms.Button btnCalcCarbCalories;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.Label lblOutputTotalCalories;
    }
}

