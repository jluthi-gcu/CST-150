namespace LuckyNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cboBirthYear = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.cboBirthMonth = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new System.Windows.Forms.Label();
            this.cboBirthDay = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new System.Windows.Forms.Label();
            this.cboFavoriteColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(333, 330);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 37);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.BackColor = System.Drawing.Color.Gray;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(74, 330);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(250, 37);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check Lucky Number";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cboBirthYear
            // 
            this.cboBirthYear.BackColor = System.Drawing.Color.Gray;
            this.cboBirthYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBirthYear.ForeColor = System.Drawing.Color.White;
            this.cboBirthYear.FormattingEnabled = true;
            this.cboBirthYear.Location = new System.Drawing.Point(204, 120);
            this.cboBirthYear.Name = "cboBirthYear";
            this.cboBirthYear.Size = new System.Drawing.Size(263, 33);
            this.cboBirthYear.TabIndex = 13;
            this.cboBirthYear.SelectedIndexChanged += new System.EventHandler(this.cboBirthYear_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(90, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 24);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Birth Year:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(76, 162);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 24);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Birth Month:";
            // 
            // cboBirthMonth
            // 
            this.cboBirthMonth.BackColor = System.Drawing.Color.Gray;
            this.cboBirthMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBirthMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBirthMonth.ForeColor = System.Drawing.Color.White;
            this.cboBirthMonth.FormattingEnabled = true;
            this.cboBirthMonth.Location = new System.Drawing.Point(204, 159);
            this.cboBirthMonth.Name = "cboBirthMonth";
            this.cboBirthMonth.Size = new System.Drawing.Size(263, 33);
            this.cboBirthMonth.TabIndex = 15;
            this.cboBirthMonth.SelectedIndexChanged += new System.EventHandler(this.cboBirthMonth_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSize = true;
            this.labelControl3.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(96, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 24);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Birth Day:";
            // 
            // cboBirthDay
            // 
            this.cboBirthDay.BackColor = System.Drawing.Color.Gray;
            this.cboBirthDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBirthDay.ForeColor = System.Drawing.Color.White;
            this.cboBirthDay.FormattingEnabled = true;
            this.cboBirthDay.Location = new System.Drawing.Point(204, 197);
            this.cboBirthDay.Name = "cboBirthDay";
            this.cboBirthDay.Size = new System.Drawing.Size(263, 33);
            this.cboBirthDay.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSize = true;
            this.labelControl4.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(55, 239);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(141, 24);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Favorite Color:";
            // 
            // cboFavoriteColor
            // 
            this.cboFavoriteColor.BackColor = System.Drawing.Color.Gray;
            this.cboFavoriteColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFavoriteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFavoriteColor.ForeColor = System.Drawing.Color.White;
            this.cboFavoriteColor.FormattingEnabled = true;
            this.cboFavoriteColor.Location = new System.Drawing.Point(204, 236);
            this.cboFavoriteColor.Name = "cboFavoriteColor";
            this.cboFavoriteColor.Size = new System.Drawing.Size(263, 33);
            this.cboFavoriteColor.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 395);
            this.Controls.Add(this.cboFavoriteColor);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cboBirthDay);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cboBirthMonth);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboBirthYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lucky Number 🪄";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cboBirthYear;
        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.Label labelControl2;
        private System.Windows.Forms.ComboBox cboBirthMonth;
        private System.Windows.Forms.Label labelControl3;
        private System.Windows.Forms.ComboBox cboBirthDay;
        private System.Windows.Forms.Label labelControl4;
        private System.Windows.Forms.ComboBox cboFavoriteColor;
    }
}

