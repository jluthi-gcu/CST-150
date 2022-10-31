namespace T_ShirtInventoryTracker
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rbtnSearchByDescription = new System.Windows.Forms.RadioButton();
            this.rbtnSearchByID = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblShirtsTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.lbShirts = new System.Windows.Forms.ListBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblShirtId = new System.Windows.Forms.Label();
            this.txtShirtId = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.scOuter = new System.Windows.Forms.SplitContainer();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOuter)).BeginInit();
            this.scOuter.Panel1.SuspendLayout();
            this.scOuter.Panel2.SuspendLayout();
            this.scOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.rbtnSearchByDescription);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnSearchByID);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnRestock);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.lblShirtsTitle);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnMoveDown);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnMoveUp);
            this.splitContainer1.Panel1.Controls.Add(this.lbShirts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.lblShirtId);
            this.splitContainer1.Panel2.Controls.Add(this.txtShirtId);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel2.Controls.Add(this.txtDescription);
            this.splitContainer1.Panel2.Controls.Add(this.rdbFemale);
            this.splitContainer1.Panel2.Controls.Add(this.rdbMale);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrice);
            this.splitContainer1.Panel2.Controls.Add(this.cboSize);
            this.splitContainer1.Panel2.Controls.Add(this.cboColor);
            this.splitContainer1.Panel2.Controls.Add(this.lblPrice);
            this.splitContainer1.Panel2.Controls.Add(this.lblSize);
            this.splitContainer1.Panel2.Controls.Add(this.lblColor);
            this.splitContainer1.Panel2.Controls.Add(this.btnPlus);
            this.splitContainer1.Panel2.Controls.Add(this.btnMinus);
            this.splitContainer1.Panel2.Controls.Add(this.lblQty);
            this.splitContainer1.Panel2.Controls.Add(this.txtQty);
            this.splitContainer1.Size = new System.Drawing.Size(1292, 600);
            this.splitContainer1.SplitterDistance = 657;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // rbtnSearchByDescription
            // 
            this.rbtnSearchByDescription.AutoSize = true;
            this.rbtnSearchByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchByDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnSearchByDescription.Location = new System.Drawing.Point(300, 52);
            this.rbtnSearchByDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSearchByDescription.Name = "rbtnSearchByDescription";
            this.rbtnSearchByDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnSearchByDescription.Size = new System.Drawing.Size(232, 29);
            this.rbtnSearchByDescription.TabIndex = 23;
            this.rbtnSearchByDescription.Text = ":Search By Description";
            this.rbtnSearchByDescription.UseVisualStyleBackColor = true;
            // 
            // rbtnSearchByID
            // 
            this.rbtnSearchByID.AutoSize = true;
            this.rbtnSearchByID.Checked = true;
            this.rbtnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSearchByID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnSearchByID.Location = new System.Drawing.Point(123, 52);
            this.rbtnSearchByID.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSearchByID.Name = "rbtnSearchByID";
            this.rbtnSearchByID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnSearchByID.Size = new System.Drawing.Size(154, 29);
            this.rbtnSearchByID.TabIndex = 22;
            this.rbtnSearchByID.TabStop = true;
            this.rbtnSearchByID.Text = ":Search By ID";
            this.rbtnSearchByID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(453, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Enabled = false;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.Location = new System.Drawing.Point(368, 534);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(113, 55);
            this.btnRestock.TabIndex = 5;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(247, 534);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 55);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblShirtsTitle
            // 
            this.lblShirtsTitle.AutoSize = true;
            this.lblShirtsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirtsTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShirtsTitle.Location = new System.Drawing.Point(36, 92);
            this.lblShirtsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShirtsTitle.Name = "lblShirtsTitle";
            this.lblShirtsTitle.Size = new System.Drawing.Size(68, 25);
            this.lblShirtsTitle.TabIndex = 4;
            this.lblShirtsTitle.Text = "Shirts:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(36, 20);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 25);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search:";
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(556, 304);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(73, 55);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(123, 534);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(129, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(556, 241);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(73, 55);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // lbShirts
            // 
            this.lbShirts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShirts.FormattingEnabled = true;
            this.lbShirts.ItemHeight = 25;
            this.lbShirts.Location = new System.Drawing.Point(36, 121);
            this.lbShirts.Margin = new System.Windows.Forms.Padding(4);
            this.lbShirts.Name = "lbShirts";
            this.lbShirts.Size = new System.Drawing.Size(496, 404);
            this.lbShirts.TabIndex = 2;
            this.lbShirts.SelectedIndexChanged += new System.EventHandler(this.lbShirts_SelectedIndexChanged);
            this.lbShirts.DoubleClick += new System.EventHandler(this.lbShirts_DoubleClick);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(73, 453);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(242, 55);
            this.btnCancelEdit.TabIndex = 22;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(317, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(242, 55);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblShirtId
            // 
            this.lblShirtId.AutoSize = true;
            this.lblShirtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirtId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShirtId.Location = new System.Drawing.Point(67, 59);
            this.lblShirtId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShirtId.Name = "lblShirtId";
            this.lblShirtId.Size = new System.Drawing.Size(82, 25);
            this.lblShirtId.TabIndex = 21;
            this.lblShirtId.Text = "Shirt ID:";
            // 
            // txtShirtId
            // 
            this.txtShirtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShirtId.Location = new System.Drawing.Point(164, 55);
            this.txtShirtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtShirtId.Name = "txtShirtId";
            this.txtShirtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShirtId.Size = new System.Drawing.Size(87, 30);
            this.txtShirtId.TabIndex = 0;
            this.txtShirtId.Text = "0";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(29, 98);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(164, 95);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Size = new System.Drawing.Size(393, 30);
            this.txtDescription.TabIndex = 1;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbFemale.Location = new System.Drawing.Point(365, 134);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbFemale.Size = new System.Drawing.Size(104, 29);
            this.rdbFemale.TabIndex = 3;
            this.rdbFemale.Text = ":Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbMale.Location = new System.Drawing.Point(233, 134);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbMale.Size = new System.Drawing.Size(82, 29);
            this.rdbMale.TabIndex = 2;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = ":Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(164, 267);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(393, 30);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "0";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(164, 223);
            this.cboSize.Margin = new System.Windows.Forms.Padding(4);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(393, 33);
            this.cboSize.TabIndex = 5;
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(164, 181);
            this.cboColor.Margin = new System.Windows.Forms.Padding(4);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(393, 33);
            this.cboColor.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(92, 271);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSize.Location = new System.Drawing.Point(97, 226);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 25);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Size:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblColor.Location = new System.Drawing.Point(89, 185);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(65, 25);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color:";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(485, 346);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(73, 55);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(404, 346);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(73, 55);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQty.Location = new System.Drawing.Point(107, 310);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 25);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Qty:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(164, 306);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(393, 30);
            this.txtQty.TabIndex = 7;
            this.txtQty.Text = "0";
            // 
            // scOuter
            // 
            this.scOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOuter.Location = new System.Drawing.Point(0, 0);
            this.scOuter.Margin = new System.Windows.Forms.Padding(4);
            this.scOuter.Name = "scOuter";
            this.scOuter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scOuter.Panel1
            // 
            this.scOuter.Panel1.Controls.Add(this.splitContainer1);
            // 
            // scOuter.Panel2
            // 
            this.scOuter.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scOuter.Panel2.Controls.Add(this.btnExit);
            this.scOuter.Size = new System.Drawing.Size(1292, 678);
            this.scOuter.SplitterDistance = 600;
            this.scOuter.SplitterWidth = 5;
            this.scOuter.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1121, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 678);
            this.Controls.Add(this.scOuter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "T-Shirt Inventory Tracker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scOuter.Panel1.ResumeLayout(false);
            this.scOuter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOuter)).EndInit();
            this.scOuter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbShirts;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblShirtsTitle;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblShirtId;
        private System.Windows.Forms.TextBox txtShirtId;
        private System.Windows.Forms.SplitContainer scOuter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbtnSearchByDescription;
        private System.Windows.Forms.RadioButton rbtnSearchByID;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}

