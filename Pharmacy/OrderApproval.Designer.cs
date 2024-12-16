namespace Pharmacy
{
    partial class OrderApproval
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblOrderApproval = new System.Windows.Forms.Label();
            this.dgvUpdateReqInfor = new System.Windows.Forms.DataGridView();
            this.MED_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_REQ_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_REQ_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_REQ_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.gbOdAInfor = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.ComboBox();
            this.txtSupID = new System.Windows.Forms.ComboBox();
            this.line7 = new System.Windows.Forms.Panel();
            this.line6 = new System.Windows.Forms.Panel();
            this.line5 = new System.Windows.Forms.Panel();
            this.line4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSupID = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateReqInfor)).BeginInit();
            this.panelFunction.SuspendLayout();
            this.gbOdAInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderApproval
            // 
            this.lblOrderApproval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOrderApproval.AutoSize = true;
            this.lblOrderApproval.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderApproval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblOrderApproval.Location = new System.Drawing.Point(203, 43);
            this.lblOrderApproval.Name = "lblOrderApproval";
            this.lblOrderApproval.Size = new System.Drawing.Size(429, 34);
            this.lblOrderApproval.TabIndex = 4;
            this.lblOrderApproval.Text = "DUYỆT YÊU CẦU NHẬP HÀNG";
            this.lblOrderApproval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUpdateReqInfor
            // 
            this.dgvUpdateReqInfor.AllowUserToAddRows = false;
            this.dgvUpdateReqInfor.AllowUserToDeleteRows = false;
            this.dgvUpdateReqInfor.AllowUserToResizeColumns = false;
            this.dgvUpdateReqInfor.AllowUserToResizeRows = false;
            this.dgvUpdateReqInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpdateReqInfor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUpdateReqInfor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpdateReqInfor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvUpdateReqInfor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpdateReqInfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUpdateReqInfor.ColumnHeadersHeight = 54;
            this.dgvUpdateReqInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUpdateReqInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MED_ID,
            this.MED_NAME,
            this.MED_UNIT,
            this.MED_QTY,
            this.MED_REQ_P,
            this.SUP_ID,
            this.MED_REQ_D,
            this.MED_REQ_STATUS});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpdateReqInfor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUpdateReqInfor.EnableHeadersVisualStyles = false;
            this.dgvUpdateReqInfor.Location = new System.Drawing.Point(12, 96);
            this.dgvUpdateReqInfor.Name = "dgvUpdateReqInfor";
            this.dgvUpdateReqInfor.ReadOnly = true;
            this.dgvUpdateReqInfor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpdateReqInfor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUpdateReqInfor.RowHeadersVisible = false;
            this.dgvUpdateReqInfor.RowHeadersWidth = 51;
            this.dgvUpdateReqInfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUpdateReqInfor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvUpdateReqInfor.RowTemplate.DividerHeight = 1;
            this.dgvUpdateReqInfor.RowTemplate.Height = 30;
            this.dgvUpdateReqInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdateReqInfor.Size = new System.Drawing.Size(549, 653);
            this.dgvUpdateReqInfor.TabIndex = 7;
            this.dgvUpdateReqInfor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateReqInfor_CellContentClick);
            // 
            // MED_ID
            // 
            this.MED_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MED_ID.DataPropertyName = "MED_ID";
            this.MED_ID.HeaderText = "Mã thuốc";
            this.MED_ID.Name = "MED_ID";
            this.MED_ID.ReadOnly = true;
            this.MED_ID.Width = 82;
            // 
            // MED_NAME
            // 
            this.MED_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_NAME.DataPropertyName = "MED_NAME";
            this.MED_NAME.HeaderText = "Tên thuốc";
            this.MED_NAME.Name = "MED_NAME";
            this.MED_NAME.ReadOnly = true;
            // 
            // MED_UNIT
            // 
            this.MED_UNIT.DataPropertyName = "MED_UNIT";
            this.MED_UNIT.HeaderText = "Đơn vị";
            this.MED_UNIT.Name = "MED_UNIT";
            this.MED_UNIT.ReadOnly = true;
            // 
            // MED_QTY
            // 
            this.MED_QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MED_QTY.DataPropertyName = "MED_QTY";
            this.MED_QTY.HeaderText = "Số lượng";
            this.MED_QTY.Name = "MED_QTY";
            this.MED_QTY.ReadOnly = true;
            this.MED_QTY.Width = 80;
            // 
            // MED_REQ_P
            // 
            this.MED_REQ_P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_REQ_P.DataPropertyName = "MED_REQ_P";
            this.MED_REQ_P.HeaderText = "Giá nhập (dự kiến)";
            this.MED_REQ_P.Name = "MED_REQ_P";
            this.MED_REQ_P.ReadOnly = true;
            // 
            // SUP_ID
            // 
            this.SUP_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SUP_ID.DataPropertyName = "SUP_ID";
            this.SUP_ID.HeaderText = "Mã NCC";
            this.SUP_ID.Name = "SUP_ID";
            this.SUP_ID.ReadOnly = true;
            this.SUP_ID.Width = 74;
            // 
            // MED_REQ_D
            // 
            this.MED_REQ_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_REQ_D.DataPropertyName = "MED_REQ_D";
            this.MED_REQ_D.HeaderText = "Ngày đặt";
            this.MED_REQ_D.Name = "MED_REQ_D";
            this.MED_REQ_D.ReadOnly = true;
            // 
            // MED_REQ_STATUS
            // 
            this.MED_REQ_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_REQ_STATUS.DataPropertyName = "MED_REQ_STATUS";
            this.MED_REQ_STATUS.HeaderText = "Trạng thái";
            this.MED_REQ_STATUS.Name = "MED_REQ_STATUS";
            this.MED_REQ_STATUS.ReadOnly = true;
            // 
            // panelFunction
            // 
            this.panelFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFunction.Controls.Add(this.btnClear);
            this.panelFunction.Controls.Add(this.btnExit);
            this.panelFunction.Controls.Add(this.btnDel);
            this.panelFunction.Controls.Add(this.btnUpdate);
            this.panelFunction.Controls.Add(this.btnReject);
            this.panelFunction.Controls.Add(this.btnApprove);
            this.panelFunction.Controls.Add(this.gbOdAInfor);
            this.panelFunction.Location = new System.Drawing.Point(567, 96);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(267, 664);
            this.panelFunction.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(0, 550);
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
            this.btnExit.Location = new System.Drawing.Point(134, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDel.FlatAppearance.BorderSize = 2;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(134, 496);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(133, 56);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 56);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnReject.FlatAppearance.BorderSize = 2;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(134, 443);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(133, 56);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Từ chối";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnApprove.FlatAppearance.BorderSize = 2;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(0, 443);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(134, 56);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Duyệt";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // gbOdAInfor
            // 
            this.gbOdAInfor.Controls.Add(this.txtStatus);
            this.gbOdAInfor.Controls.Add(this.txtUnit);
            this.gbOdAInfor.Controls.Add(this.txtSupID);
            this.gbOdAInfor.Controls.Add(this.line7);
            this.gbOdAInfor.Controls.Add(this.line6);
            this.gbOdAInfor.Controls.Add(this.line5);
            this.gbOdAInfor.Controls.Add(this.line4);
            this.gbOdAInfor.Controls.Add(this.panel1);
            this.gbOdAInfor.Controls.Add(this.line3);
            this.gbOdAInfor.Controls.Add(this.line2);
            this.gbOdAInfor.Controls.Add(this.line1);
            this.gbOdAInfor.Controls.Add(this.lblStatus);
            this.gbOdAInfor.Controls.Add(this.txtDate);
            this.gbOdAInfor.Controls.Add(this.lblDate);
            this.gbOdAInfor.Controls.Add(this.lblSupID);
            this.gbOdAInfor.Controls.Add(this.txtCost);
            this.gbOdAInfor.Controls.Add(this.lblCost);
            this.gbOdAInfor.Controls.Add(this.lblUnit);
            this.gbOdAInfor.Controls.Add(this.lblQty);
            this.gbOdAInfor.Controls.Add(this.txtQty);
            this.gbOdAInfor.Controls.Add(this.txtName);
            this.gbOdAInfor.Controls.Add(this.lblName);
            this.gbOdAInfor.Controls.Add(this.txtID);
            this.gbOdAInfor.Controls.Add(this.lblID);
            this.gbOdAInfor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOdAInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.gbOdAInfor.Location = new System.Drawing.Point(2, 3);
            this.gbOdAInfor.Name = "gbOdAInfor";
            this.gbOdAInfor.Size = new System.Drawing.Size(265, 434);
            this.gbOdAInfor.TabIndex = 0;
            this.gbOdAInfor.TabStop = false;
            this.gbOdAInfor.Text = "Yêu Cầu";
            // 
            // txtStatus
            // 
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Đã duyệt",
            "Chưa duyệt",
            "Từ chối"});
            this.txtStatus.Location = new System.Drawing.Point(125, 381);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(128, 27);
            this.txtStatus.TabIndex = 6;
            // 
            // txtUnit
            // 
            this.txtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.ForeColor = System.Drawing.Color.Black;
            this.txtUnit.FormattingEnabled = true;
            this.txtUnit.Items.AddRange(new object[] {
            "Vỉ ",
            "Hộp ",
            "Lọ"});
            this.txtUnit.Location = new System.Drawing.Point(90, 134);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(166, 27);
            this.txtUnit.TabIndex = 4;
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
            this.txtSupID.Location = new System.Drawing.Point(105, 285);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(148, 27);
            this.txtSupID.TabIndex = 4;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line7.ForeColor = System.Drawing.Color.White;
            this.line7.Location = new System.Drawing.Point(6, 411);
            this.line7.Margin = new System.Windows.Forms.Padding(4);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(250, 1);
            this.line7.TabIndex = 7;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line6.ForeColor = System.Drawing.Color.White;
            this.line6.Location = new System.Drawing.Point(6, 362);
            this.line6.Margin = new System.Windows.Forms.Padding(4);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(250, 1);
            this.line6.TabIndex = 7;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line5.ForeColor = System.Drawing.Color.White;
            this.line5.Location = new System.Drawing.Point(6, 314);
            this.line5.Margin = new System.Windows.Forms.Padding(4);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(250, 1);
            this.line5.TabIndex = 7;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line4.ForeColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(6, 266);
            this.line4.Margin = new System.Windows.Forms.Padding(4);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(250, 1);
            this.line4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 7;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line3.ForeColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(6, 215);
            this.line3.Margin = new System.Windows.Forms.Padding(4);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(250, 1);
            this.line3.TabIndex = 7;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line2.ForeColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(6, 114);
            this.line2.Margin = new System.Windows.Forms.Padding(4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(250, 1);
            this.line2.TabIndex = 7;
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
            this.lblStatus.Location = new System.Drawing.Point(8, 386);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Location = new System.Drawing.Point(110, 336);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(146, 19);
            this.txtDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 331);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 22);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày đặt:";
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupID.Location = new System.Drawing.Point(6, 288);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(91, 22);
            this.lblSupID.TabIndex = 0;
            this.lblSupID.Text = "Mã NCC:";
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.Location = new System.Drawing.Point(114, 245);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(142, 19);
            this.txtCost.TabIndex = 3;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(6, 240);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(93, 22);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Giá nhập";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(6, 139);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 22);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "Đơn vị:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 191);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(104, 22);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Số lượng:";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(116, 194);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(140, 19);
            this.txtQty.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(123, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 19);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên thuốc:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(110, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 19);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã thuốc:";
            // 
            // OrderApproval
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.dgvUpdateReqInfor);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.lblOrderApproval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderApproval";
            this.Text = "OrderApproval";
            this.Load += new System.EventHandler(this.OrderApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateReqInfor)).EndInit();
            this.panelFunction.ResumeLayout(false);
            this.gbOdAInfor.ResumeLayout(false);
            this.gbOdAInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderApproval;
        private System.Windows.Forms.DataGridView dgvUpdateReqInfor;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.GroupBox gbOdAInfor;
        private System.Windows.Forms.ComboBox txtSupID;
        private System.Windows.Forms.Panel line7;
        private System.Windows.Forms.Panel line6;
        private System.Windows.Forms.Panel line5;
        private System.Windows.Forms.Panel line4;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSupID;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_REQ_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_REQ_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_REQ_STATUS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox txtUnit;
    }
}