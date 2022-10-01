namespace Pounds2Kilograms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPounds = new System.Windows.Forms.Label();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.lblKilograms = new System.Windows.Forms.Label();
            this.txtKilograms = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.chxRound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPounds.Location = new System.Drawing.Point(39, 15);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(50, 15);
            this.lblPounds.TabIndex = 5;
            this.lblPounds.Text = "Pounds:";
            // 
            // txtPounds
            // 
            this.txtPounds.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPounds.Location = new System.Drawing.Point(95, 12);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(287, 23);
            this.txtPounds.TabIndex = 0;
            // 
            // lblKilograms
            // 
            this.lblKilograms.AutoSize = true;
            this.lblKilograms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKilograms.Location = new System.Drawing.Point(26, 62);
            this.lblKilograms.Name = "lblKilograms";
            this.lblKilograms.Size = new System.Drawing.Size(63, 15);
            this.lblKilograms.TabIndex = 6;
            this.lblKilograms.Text = "Kilograms:";
            // 
            // txtKilograms
            // 
            this.txtKilograms.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtKilograms.Location = new System.Drawing.Point(95, 59);
            this.txtKilograms.Name = "txtKilograms";
            this.txtKilograms.Size = new System.Drawing.Size(287, 23);
            this.txtKilograms.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTo.Location = new System.Drawing.Point(229, 41);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(19, 15);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvert.Location = new System.Drawing.Point(257, 117);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 34);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // chxRound
            // 
            this.chxRound.AutoSize = true;
            this.chxRound.Checked = true;
            this.chxRound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxRound.Location = new System.Drawing.Point(95, 88);
            this.chxRound.Name = "chxRound";
            this.chxRound.Size = new System.Drawing.Size(79, 19);
            this.chxRound.TabIndex = 3;
            this.chxRound.Text = "Round Up";
            this.chxRound.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 163);
            this.Controls.Add(this.chxRound);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblKilograms);
            this.Controls.Add(this.txtKilograms);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.txtPounds);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pounds 2 Kilograms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPounds;
        private TextBox txtPounds;
        private Label lblKilograms;
        private TextBox txtKilograms;
        private Label lblTo;
        private Button btnConvert;
        private CheckBox chxRound;
    }
}