namespace Pharmacy
{
    partial class UpdateWareHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUpdateInfor = new System.Windows.Forms.Label();
            this.dgvGoodsList = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUR_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFG_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXP_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.gbEMPInforMED = new System.Windows.Forms.GroupBox();
            this.txtSupID = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.line4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.line8 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEXP = new System.Windows.Forms.Label();
            this.lblMFG = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtEXP = new System.Windows.Forms.TextBox();
            this.txtMFG = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.lblMID = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
            this.panelFunction.SuspendLayout();
            this.gbEMPInforMED.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateInfor
            // 
            this.lblUpdateInfor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdateInfor.AutoSize = true;
            this.lblUpdateInfor.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblUpdateInfor.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblUpdateInfor.Location = new System.Drawing.Point(250, 43);
            this.lblUpdateInfor.Name = "lblUpdateInfor";
            this.lblUpdateInfor.Size = new System.Drawing.Size(334, 34);
            this.lblUpdateInfor.TabIndex = 8;
            this.lblUpdateInfor.Text = "Cập nhật thông tin kho";
            this.lblUpdateInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGoodsList
            // 
            this.dgvGoodsList.AllowUserToAddRows = false;
            this.dgvGoodsList.AllowUserToDeleteRows = false;
            this.dgvGoodsList.AllowUserToResizeColumns = false;
            this.dgvGoodsList.AllowUserToResizeRows = false;
            this.dgvGoodsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGoodsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGoodsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGoodsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvGoodsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoodsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoodsList.ColumnHeadersHeight = 54;
            this.dgvGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.SUP_ID,
            this.MED_ID,
            this.MED_NAME,
            this.P_QTY,
            this.P_UNIT,
            this.P_COST,
            this.PUR_DATE,
            this.MFG_DATE,
            this.EXP_DATE,
            this.P_STATUS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGoodsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoodsList.EnableHeadersVisualStyles = false;
            this.dgvGoodsList.Location = new System.Drawing.Point(12, 96);
            this.dgvGoodsList.Name = "dgvGoodsList";
            this.dgvGoodsList.ReadOnly = true;
            this.dgvGoodsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoodsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGoodsList.RowHeadersVisible = false;
            this.dgvGoodsList.RowHeadersWidth = 51;
            this.dgvGoodsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGoodsList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGoodsList.RowTemplate.DividerHeight = 1;
            this.dgvGoodsList.RowTemplate.Height = 30;
            this.dgvGoodsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsList.Size = new System.Drawing.Size(549, 653);
            this.dgvGoodsList.TabIndex = 9;
            this.dgvGoodsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsList_CellContentClick);
            // 
            // P_ID
            // 
            this.P_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Số lô";
            this.P_ID.MinimumWidth = 6;
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            this.P_ID.Width = 47;
            // 
            // SUP_ID
            // 
            this.SUP_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_ID.DataPropertyName = "SUP_ID";
            this.SUP_ID.HeaderText = "Nhà cung cấp";
            this.SUP_ID.MinimumWidth = 6;
            this.SUP_ID.Name = "SUP_ID";
            this.SUP_ID.ReadOnly = true;
            // 
            // MED_ID
            // 
            this.MED_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MED_ID.DataPropertyName = "MED_ID";
            this.MED_ID.HeaderText = "Mã thuốc";
            this.MED_ID.MinimumWidth = 6;
            this.MED_ID.Name = "MED_ID";
            this.MED_ID.ReadOnly = true;
            this.MED_ID.Width = 82;
            // 
            // MED_NAME
            // 
            this.MED_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_NAME.DataPropertyName = "MED_NAME";
            this.MED_NAME.HeaderText = "Tên thuốc";
            this.MED_NAME.MinimumWidth = 6;
            this.MED_NAME.Name = "MED_NAME";
            this.MED_NAME.ReadOnly = true;
            // 
            // P_QTY
            // 
            this.P_QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.P_QTY.DataPropertyName = "P_QTY";
            this.P_QTY.HeaderText = "Số lượng";
            this.P_QTY.MinimumWidth = 6;
            this.P_QTY.Name = "P_QTY";
            this.P_QTY.ReadOnly = true;
            this.P_QTY.Width = 80;
            // 
            // P_UNIT
            // 
            this.P_UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_UNIT.DataPropertyName = "P_UNIT";
            this.P_UNIT.HeaderText = "Đơn vị";
            this.P_UNIT.MinimumWidth = 6;
            this.P_UNIT.Name = "P_UNIT";
            this.P_UNIT.ReadOnly = true;
            this.P_UNIT.Width = 57;
            // 
            // P_COST
            // 
            this.P_COST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_COST.DataPropertyName = "P_COST";
            this.P_COST.HeaderText = "Thành tiền";
            this.P_COST.MinimumWidth = 6;
            this.P_COST.Name = "P_COST";
            this.P_COST.ReadOnly = true;
            this.P_COST.Width = 90;
            // 
            // PUR_DATE
            // 
            this.PUR_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PUR_DATE.DataPropertyName = "PUR_DATE";
            this.PUR_DATE.HeaderText = "Ngày đặt";
            this.PUR_DATE.MinimumWidth = 6;
            this.PUR_DATE.Name = "PUR_DATE";
            this.PUR_DATE.ReadOnly = true;
            // 
            // MFG_DATE
            // 
            this.MFG_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MFG_DATE.DataPropertyName = "MFG_DATE";
            this.MFG_DATE.HeaderText = "Ngày sản xuất";
            this.MFG_DATE.MinimumWidth = 6;
            this.MFG_DATE.Name = "MFG_DATE";
            this.MFG_DATE.ReadOnly = true;
            // 
            // EXP_DATE
            // 
            this.EXP_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EXP_DATE.DataPropertyName = "EXP_DATE";
            this.EXP_DATE.HeaderText = "Hạn sử dụng";
            this.EXP_DATE.MinimumWidth = 6;
            this.EXP_DATE.Name = "EXP_DATE";
            this.EXP_DATE.ReadOnly = true;
            // 
            // P_STATUS
            // 
            this.P_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_STATUS.DataPropertyName = "P_STATUS";
            this.P_STATUS.HeaderText = "Trạng thái";
            this.P_STATUS.MinimumWidth = 6;
            this.P_STATUS.Name = "P_STATUS";
            this.P_STATUS.ReadOnly = true;
            // 
            // panelFunction
            // 
            this.panelFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFunction.Controls.Add(this.btnClear);
            this.panelFunction.Controls.Add(this.btnExit);
            this.panelFunction.Controls.Add(this.btnSearch);
            this.panelFunction.Controls.Add(this.btnUpdate);
            this.panelFunction.Controls.Add(this.btnDel);
            this.panelFunction.Controls.Add(this.gbEMPInforMED);
            this.panelFunction.Location = new System.Drawing.Point(567, 96);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(267, 664);
            this.panelFunction.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(0, 506);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 559);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(267, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(134, 505);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 56);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 452);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 56);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDel.FlatAppearance.BorderSize = 2;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(134, 452);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(133, 56);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gbEMPInforMED
            // 
            this.gbEMPInforMED.Controls.Add(this.txtSupID);
            this.gbEMPInforMED.Controls.Add(this.txtStatus);
            this.gbEMPInforMED.Controls.Add(this.line4);
            this.gbEMPInforMED.Controls.Add(this.panel2);
            this.gbEMPInforMED.Controls.Add(this.panel1);
            this.gbEMPInforMED.Controls.Add(this.line3);
            this.gbEMPInforMED.Controls.Add(this.line2);
            this.gbEMPInforMED.Controls.Add(this.line8);
            this.gbEMPInforMED.Controls.Add(this.line1);
            this.gbEMPInforMED.Controls.Add(this.lblStatus);
            this.gbEMPInforMED.Controls.Add(this.lblEXP);
            this.gbEMPInforMED.Controls.Add(this.lblMFG);
            this.gbEMPInforMED.Controls.Add(this.lblQty);
            this.gbEMPInforMED.Controls.Add(this.txtEXP);
            this.gbEMPInforMED.Controls.Add(this.txtMFG);
            this.gbEMPInforMED.Controls.Add(this.txtQty);
            this.gbEMPInforMED.Controls.Add(this.txtMID);
            this.gbEMPInforMED.Controls.Add(this.lblMID);
            this.gbEMPInforMED.Controls.Add(this.lblSuppliers);
            this.gbEMPInforMED.Controls.Add(this.txtPID);
            this.gbEMPInforMED.Controls.Add(this.lblPID);
            this.gbEMPInforMED.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEMPInforMED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.gbEMPInforMED.Location = new System.Drawing.Point(2, 3);
            this.gbEMPInforMED.Name = "gbEMPInforMED";
            this.gbEMPInforMED.Size = new System.Drawing.Size(265, 377);
            this.gbEMPInforMED.TabIndex = 0;
            this.gbEMPInforMED.TabStop = false;
            this.gbEMPInforMED.Text = "Thông tin kho";
            // 
            // txtSupID
            // 
            this.txtSupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSupID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSupID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupID.ForeColor = System.Drawing.Color.Black;
            this.txtSupID.FormattingEnabled = true;
            this.txtSupID.Items.AddRange(new object[] {
            "XYZ123",
            "ABC136",
            "DPL145",
            "MA156",
            "MHP162"});
            this.txtSupID.Location = new System.Drawing.Point(70, 85);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(183, 27);
            this.txtSupID.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Chưa giao",
            "Đã giao"});
            this.txtStatus.Location = new System.Drawing.Point(123, 337);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(133, 27);
            this.txtStatus.TabIndex = 4;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line4.ForeColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(6, 366);
            this.line4.Margin = new System.Windows.Forms.Padding(4);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(250, 1);
            this.line4.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(6, 314);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 261);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 7;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line3.ForeColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(6, 209);
            this.line3.Margin = new System.Windows.Forms.Padding(4);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(250, 1);
            this.line3.TabIndex = 7;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line2.ForeColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(6, 160);
            this.line2.Margin = new System.Windows.Forms.Padding(4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(250, 1);
            this.line2.TabIndex = 7;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line8.ForeColor = System.Drawing.Color.White;
            this.line8.Location = new System.Drawing.Point(6, 114);
            this.line8.Margin = new System.Windows.Forms.Padding(4);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(250, 1);
            this.line8.TabIndex = 7;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line1.ForeColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(6, 65);
            this.line1.Margin = new System.Windows.Forms.Padding(4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(250, 1);
            this.line1.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 340);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXP.Location = new System.Drawing.Point(6, 290);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(57, 22);
            this.lblEXP.TabIndex = 0;
            this.lblEXP.Text = "HSD:";
            // 
            // lblMFG
            // 
            this.lblMFG.AutoSize = true;
            this.lblMFG.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMFG.Location = new System.Drawing.Point(6, 237);
            this.lblMFG.Name = "lblMFG";
            this.lblMFG.Size = new System.Drawing.Size(56, 22);
            this.lblMFG.TabIndex = 0;
            this.lblMFG.Text = "NSX:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 185);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(97, 22);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Số lượng";
            // 
            // txtEXP
            // 
            this.txtEXP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEXP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEXP.ForeColor = System.Drawing.Color.Black;
            this.txtEXP.Location = new System.Drawing.Point(69, 293);
            this.txtEXP.Name = "txtEXP";
            this.txtEXP.Size = new System.Drawing.Size(187, 19);
            this.txtEXP.TabIndex = 3;
            // 
            // txtMFG
            // 
            this.txtMFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMFG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMFG.ForeColor = System.Drawing.Color.Black;
            this.txtMFG.Location = new System.Drawing.Point(69, 240);
            this.txtMFG.Name = "txtMFG";
            this.txtMFG.Size = new System.Drawing.Size(187, 19);
            this.txtMFG.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(109, 188);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(147, 19);
            this.txtQty.TabIndex = 3;
            // 
            // txtMID
            // 
            this.txtMID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMID.ForeColor = System.Drawing.Color.Black;
            this.txtMID.Location = new System.Drawing.Point(115, 139);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(141, 19);
            this.txtMID.TabIndex = 2;
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMID.Location = new System.Drawing.Point(6, 136);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(103, 22);
            this.lblMID.TabIndex = 0;
            this.lblMID.Text = "Mã thuốc:";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(6, 89);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(58, 22);
            this.lblSuppliers.TabIndex = 0;
            this.lblSuppliers.Text = "NCC:";
            // 
            // txtPID
            // 
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.ForeColor = System.Drawing.Color.Black;
            this.txtPID.Location = new System.Drawing.Point(69, 44);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(184, 19);
            this.txtPID.TabIndex = 0;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(6, 41);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(57, 22);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "Số lô";
            // 
            // UpdateWareHouse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.dgvGoodsList);
            this.Controls.Add(this.lblUpdateInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateWareHouse";
            this.Text = "UpdateWareHouse";
            this.Load += new System.EventHandler(this.UpdateWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
            this.panelFunction.ResumeLayout(false);
            this.gbEMPInforMED.ResumeLayout(false);
            this.gbEMPInforMED.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUpdateInfor;
        private System.Windows.Forms.DataGridView dgvGoodsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUR_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFG_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXP_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_STATUS;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox gbEMPInforMED;
        private System.Windows.Forms.Panel line8;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.ComboBox txtSupID;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Panel line4;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Label lblMID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.Label lblMFG;
        private System.Windows.Forms.TextBox txtEXP;
        private System.Windows.Forms.TextBox txtMFG;
    }
}