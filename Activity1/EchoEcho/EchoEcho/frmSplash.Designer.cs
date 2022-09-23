namespace EchoEcho
{
    partial class frmSplash
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
            this.lblPreGeneratedResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPreGeneratedResponse
            // 
            this.lblPreGeneratedResponse.AutoSize = true;
            this.lblPreGeneratedResponse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreGeneratedResponse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPreGeneratedResponse.Location = new System.Drawing.Point(129, 44);
            this.lblPreGeneratedResponse.Name = "lblPreGeneratedResponse";
            this.lblPreGeneratedResponse.Size = new System.Drawing.Size(138, 37);
            this.lblPreGeneratedResponse.TabIndex = 10;
            this.lblPreGeneratedResponse.Text = "Echo Echo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "(C) 2022 Joel Luthi";
            // 
            // stMain
            // 
            this.stMain.Enabled = true;
            this.stMain.Interval = 3000;
            this.stMain.Tick += new System.EventHandler(this.stMain_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 263);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPreGeneratedResponse);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPreGeneratedResponse;
        private Label label1;
        private System.Windows.Forms.Timer stMain;
    }
}