namespace Pharmacy
{
    partial class Sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSale = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgvMED = new System.Windows.Forms.DataGridView();
            this.MED_BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MED_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.B_MED_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_MED_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_MED_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_MED_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMEid = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lblMEDID = new System.Windows.Forms.Label();
            this.lblQTY = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSale
            // 
            this.lblSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblSale.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblSale.Location = new System.Drawing.Point(344, 43);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(147, 34);
            this.lblSale.TabIndex = 9;
            this.lblSale.Text = "Bán hàng";
            this.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.Controls.Add(this.dgvMED);
            this.panelData.Location = new System.Drawing.Point(1, 96);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(504, 661);
            this.panelData.TabIndex = 11;
            // 
            // dgvMED
            // 
            this.dgvMED.AllowUserToAddRows = false;
            this.dgvMED.AllowUserToDeleteRows = false;
            this.dgvMED.AllowUserToResizeColumns = false;
            this.dgvMED.AllowUserToResizeRows = false;
            this.dgvMED.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMED.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMED.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvMED.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMED.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMED.ColumnHeadersHeight = 54;
            this.dgvMED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMED.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MED_BARCODE,
            this.MED_ID,
            this.MED_NAME,
            this.MED_QTY,
            this.MED_UNIT,
            this.MED_CATEGORY,
            this.MED_PRICE,
            this.MED_STATUS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMED.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMED.EnableHeadersVisualStyles = false;
            this.dgvMED.Location = new System.Drawing.Point(0, 0);
            this.dgvMED.Name = "dgvMED";
            this.dgvMED.ReadOnly = true;
            this.dgvMED.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMED.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMED.RowHeadersVisible = false;
            this.dgvMED.RowHeadersWidth = 51;
            this.dgvMED.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMED.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMED.RowTemplate.DividerHeight = 1;
            this.dgvMED.RowTemplate.Height = 30;
            this.dgvMED.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMED.Size = new System.Drawing.Size(504, 661);
            this.dgvMED.TabIndex = 10;
            this.dgvMED.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMED_CellContentClick);
            // 
            // MED_BARCODE
            // 
            this.MED_BARCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_BARCODE.DataPropertyName = "MED_BARCODE";
            this.MED_BARCODE.HeaderText = "BARCODE";
            this.MED_BARCODE.Name = "MED_BARCODE";
            this.MED_BARCODE.ReadOnly = true;
            // 
            // MED_ID
            // 
            this.MED_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_ID.DataPropertyName = "MED_ID";
            this.MED_ID.HeaderText = "Mã thuốc";
            this.MED_ID.Name = "MED_ID";
            this.MED_ID.ReadOnly = true;
            // 
            // MED_NAME
            // 
            this.MED_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_NAME.DataPropertyName = "MED_NAME";
            this.MED_NAME.HeaderText = "Tên thuốc";
            this.MED_NAME.Name = "MED_NAME";
            this.MED_NAME.ReadOnly = true;
            // 
            // MED_QTY
            // 
            this.MED_QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_QTY.DataPropertyName = "MED_QTY";
            this.MED_QTY.HeaderText = "Số lượng";
            this.MED_QTY.Name = "MED_QTY";
            this.MED_QTY.ReadOnly = true;
            // 
            // MED_UNIT
            // 
            this.MED_UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MED_UNIT.DataPropertyName = "MED_UNIT";
            this.MED_UNIT.HeaderText = "Đơn vị";
            this.MED_UNIT.Name = "MED_UNIT";
            this.MED_UNIT.ReadOnly = true;
            this.MED_UNIT.Width = 57;
            // 
            // MED_CATEGORY
            // 
            this.MED_CATEGORY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_CATEGORY.DataPropertyName = "MED_CATEGORY";
            this.MED_CATEGORY.HeaderText = "Thể loại";
            this.MED_CATEGORY.Name = "MED_CATEGORY";
            this.MED_CATEGORY.ReadOnly = true;
            // 
            // MED_PRICE
            // 
            this.MED_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_PRICE.DataPropertyName = "MED_PRICE";
            this.MED_PRICE.HeaderText = "Đơn giá";
            this.MED_PRICE.Name = "MED_PRICE";
            this.MED_PRICE.ReadOnly = true;
            // 
            // MED_STATUS
            // 
            this.MED_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MED_STATUS.DataPropertyName = "MED_STATUS";
            this.MED_STATUS.HeaderText = "Trạng thái";
            this.MED_STATUS.Name = "MED_STATUS";
            this.MED_STATUS.ReadOnly = true;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.ColumnHeadersHeight = 54;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.B_MED_NAME,
            this.B_MED_QTY,
            this.B_MED_PRICE,
            this.B_MED_TOTAL});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.Location = new System.Drawing.Point(511, 96);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBill.RowTemplate.DividerHeight = 1;
            this.dgvBill.RowTemplate.Height = 30;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(322, 313);
            this.dgvBill.TabIndex = 11;
            // 
            // B_MED_NAME
            // 
            this.B_MED_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B_MED_NAME.DataPropertyName = "B_MED_NAME";
            this.B_MED_NAME.HeaderText = "Tên thuốc";
            this.B_MED_NAME.Name = "B_MED_NAME";
            this.B_MED_NAME.ReadOnly = true;
            // 
            // B_MED_QTY
            // 
            this.B_MED_QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.B_MED_QTY.DataPropertyName = "B_MED_QTY";
            this.B_MED_QTY.HeaderText = "Số lượng";
            this.B_MED_QTY.Name = "B_MED_QTY";
            this.B_MED_QTY.ReadOnly = true;
            this.B_MED_QTY.Width = 80;
            // 
            // B_MED_PRICE
            // 
            this.B_MED_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B_MED_PRICE.DataPropertyName = "B_MED_PRICE";
            this.B_MED_PRICE.HeaderText = "Đơn giá";
            this.B_MED_PRICE.Name = "B_MED_PRICE";
            this.B_MED_PRICE.ReadOnly = true;
            // 
            // B_MED_TOTAL
            // 
            this.B_MED_TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B_MED_TOTAL.DataPropertyName = "B_MED_TOTAL";
            this.B_MED_TOTAL.HeaderText = "Thành tiền";
            this.B_MED_TOTAL.Name = "B_MED_TOTAL";
            this.B_MED_TOTAL.ReadOnly = true;
            // 
            // panelChucNang
            // 
            this.panelChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChucNang.BackColor = System.Drawing.Color.White;
            this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChucNang.Controls.Add(this.btnAdd);
            this.panelChucNang.Controls.Add(this.line1);
            this.panelChucNang.Controls.Add(this.btnDel);
            this.panelChucNang.Controls.Add(this.btnPay);
            this.panelChucNang.Controls.Add(this.lblTotal);
            this.panelChucNang.Controls.Add(this.txtTotal);
            this.panelChucNang.Controls.Add(this.txtMEid);
            this.panelChucNang.Controls.Add(this.txtQty);
            this.panelChucNang.Controls.Add(this.txtCusID);
            this.panelChucNang.Controls.Add(this.lblMEDID);
            this.panelChucNang.Controls.Add(this.lblQTY);
            this.panelChucNang.Controls.Add(this.lblCusName);
            this.panelChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panelChucNang.Location = new System.Drawing.Point(511, 415);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(322, 342);
            this.panelChucNang.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.line1.ForeColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(4, 112);
            this.line1.Margin = new System.Windows.Forms.Padding(4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(315, 1);
            this.line1.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(0, 250);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(320, 45);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPay
            // 
            this.btnPay.AllowDrop = true;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(0, 295);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(320, 45);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblTotal.Location = new System.Drawing.Point(5, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Tổng cộng:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(137, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 39);
            this.txtTotal.TabIndex = 1;
            // 
            // txtMEid
            // 
            this.txtMEid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEid.ForeColor = System.Drawing.Color.Black;
            this.txtMEid.Location = new System.Drawing.Point(98, 20);
            this.txtMEid.Name = "txtMEid";
            this.txtMEid.Size = new System.Drawing.Size(221, 22);
            this.txtMEid.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(99, 52);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(220, 22);
            this.txtQty.TabIndex = 1;
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.ForeColor = System.Drawing.Color.Black;
            this.txtCusID.Location = new System.Drawing.Point(137, 83);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(182, 22);
            this.txtCusID.TabIndex = 1;
            // 
            // lblMEDID
            // 
            this.lblMEDID.AutoSize = true;
            this.lblMEDID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMEDID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblMEDID.Location = new System.Drawing.Point(23, 20);
            this.lblMEDID.Name = "lblMEDID";
            this.lblMEDID.Size = new System.Drawing.Size(69, 16);
            this.lblMEDID.TabIndex = 0;
            this.lblMEDID.Text = "Mã thuốc:";
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblQTY.Location = new System.Drawing.Point(23, 52);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(70, 16);
            this.lblQTY.TabIndex = 0;
            this.lblQTY.Text = "Số lượng:";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblCusName.Location = new System.Drawing.Point(23, 83);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(108, 16);
            this.lblCusName.TabIndex = 0;
            this.lblCusName.Text = "Mã khách hàng:";
            // 
            // Sale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.lblSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridView dgvMED;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_MED_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_MED_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_MED_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_MED_TOTAL;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtMEid;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblMEDID;
        private System.Windows.Forms.Label lblQTY;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MED_STATUS;
    }
}