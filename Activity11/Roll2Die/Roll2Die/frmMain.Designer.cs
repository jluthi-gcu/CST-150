namespace Roll2Die
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
            this.btnRollDie = new System.Windows.Forms.Button();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRollDie
            // 
            this.btnRollDie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRollDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDie.ForeColor = System.Drawing.Color.White;
            this.btnRollDie.Location = new System.Drawing.Point(33, 120);
            this.btnRollDie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRollDie.Name = "btnRollDie";
            this.btnRollDie.Size = new System.Drawing.Size(124, 30);
            this.btnRollDie.TabIndex = 3;
            this.btnRollDie.Text = "Roll Dice 🎲";
            this.btnRollDie.UseVisualStyleBackColor = false;
            this.btnRollDie.Click += new System.EventHandler(this.btnRollDie_Click);
            // 
            // lblDie1
            // 
            this.lblDie1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.ForeColor = System.Drawing.Color.White;
            this.lblDie1.Location = new System.Drawing.Point(42, 36);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(30, 30);
            this.lblDie1.TabIndex = 7;
            this.lblDie1.Text = "-";
            this.lblDie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDie2
            // 
            this.lblDie2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.ForeColor = System.Drawing.Color.White;
            this.lblDie2.Location = new System.Drawing.Point(112, 36);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(30, 30);
            this.lblDie2.TabIndex = 8;
            this.lblDie2.Text = "-";
            this.lblDie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.btnRollDie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Roll 2 Die";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollDie;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
    }
}

