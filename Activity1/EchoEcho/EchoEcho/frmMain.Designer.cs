namespace EchoEcho
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblManualResponse = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cboPreGeneratedResponse = new System.Windows.Forms.ComboBox();
            this.lblPreGeneratedResponse = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblManualResponse);
            this.splitContainer1.Panel1.Controls.Add(this.txtResponse);
            this.splitContainer1.Panel1.Controls.Add(this.cboPreGeneratedResponse);
            this.splitContainer1.Panel1.Controls.Add(this.lblPreGeneratedResponse);
            this.splitContainer1.Panel1.Controls.Add(this.btnSend);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutput);
            this.splitContainer1.Panel2.Controls.Add(this.lbOutput);
            this.splitContainer1.Size = new System.Drawing.Size(509, 499);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblManualResponse
            // 
            this.lblManualResponse.AutoSize = true;
            this.lblManualResponse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManualResponse.Location = new System.Drawing.Point(49, 54);
            this.lblManualResponse.Name = "lblManualResponse";
            this.lblManualResponse.Size = new System.Drawing.Size(103, 15);
            this.lblManualResponse.TabIndex = 4;
            this.lblManualResponse.Text = "Manual Response:";
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtResponse.Location = new System.Drawing.Point(158, 51);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(339, 23);
            this.txtResponse.TabIndex = 1;
            // 
            // cboPreGeneratedResponse
            // 
            this.cboPreGeneratedResponse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cboPreGeneratedResponse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreGeneratedResponse.FormattingEnabled = true;
            this.cboPreGeneratedResponse.Items.AddRange(new object[] {
            "",
            "Hello!",
            "How you doing?",
            "Good Morning!",
            "Good Afternoon",
            "Good Evening! ",
            "Good Night."});
            this.cboPreGeneratedResponse.Location = new System.Drawing.Point(158, 18);
            this.cboPreGeneratedResponse.Name = "cboPreGeneratedResponse";
            this.cboPreGeneratedResponse.Size = new System.Drawing.Size(339, 23);
            this.cboPreGeneratedResponse.TabIndex = 0;
            this.cboPreGeneratedResponse.SelectedIndexChanged += new System.EventHandler(this.cboPreGeneratedResponse_SelectedIndexChanged);
            // 
            // lblPreGeneratedResponse
            // 
            this.lblPreGeneratedResponse.AutoSize = true;
            this.lblPreGeneratedResponse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPreGeneratedResponse.Location = new System.Drawing.Point(15, 21);
            this.lblPreGeneratedResponse.Name = "lblPreGeneratedResponse";
            this.lblPreGeneratedResponse.Size = new System.Drawing.Size(137, 15);
            this.lblPreGeneratedResponse.TabIndex = 3;
            this.lblPreGeneratedResponse.Text = "Pre Generated Response:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(372, 82);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(241, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOutput.Location = new System.Drawing.Point(12, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(87, 15);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Echo\'d Output:";
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 15;
            this.lbOutput.Location = new System.Drawing.Point(12, 31);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(485, 274);
            this.lbOutput.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(372, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 499);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Echo Echo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblOutput;
        private Label lblManualResponse;
        private TextBox txtResponse;
        private ComboBox cboPreGeneratedResponse;
        private Label lblPreGeneratedResponse;
        private Button btnSend;
        private ListBox lbOutput;
        private Button btnClear;
        private Button btnExit;
    }
}