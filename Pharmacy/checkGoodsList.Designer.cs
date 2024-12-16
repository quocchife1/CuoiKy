namespace Pharmacy
{
    partial class checkGoodsList
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
            this.lblGoodsList = new System.Windows.Forms.Label();
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
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoodsList
            // 
            this.lblGoodsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGoodsList.AutoSize = true;
            this.lblGoodsList.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblGoodsList.Location = new System.Drawing.Point(313, 43);
            this.lblGoodsList.Name = "lblGoodsList";
            this.lblGoodsList.Size = new System.Drawing.Size(209, 34);
            this.lblGoodsList.TabIndex = 4;
            this.lblGoodsList.Text = "Thông tin kho";
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
            this.dgvGoodsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGoodsList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGoodsList.RowTemplate.DividerHeight = 1;
            this.dgvGoodsList.RowTemplate.Height = 30;
            this.dgvGoodsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsList.Size = new System.Drawing.Size(810, 599);
            this.dgvGoodsList.TabIndex = 3;
            // 
            // P_ID
            // 
            this.P_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Số lô";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            this.P_ID.Width = 47;
            // 
            // SUP_ID
            // 
            this.SUP_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_ID.DataPropertyName = "SUP_ID";
            this.SUP_ID.HeaderText = "Nhà cung cấp";
            this.SUP_ID.Name = "SUP_ID";
            this.SUP_ID.ReadOnly = true;
            // 
            // MED_ID
            // 
            this.MED_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // P_QTY
            // 
            this.P_QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.P_QTY.DataPropertyName = "P_QTY";
            this.P_QTY.HeaderText = "Số lượng";
            this.P_QTY.Name = "P_QTY";
            this.P_QTY.ReadOnly = true;
            this.P_QTY.Width = 80;
            // 
            // P_UNIT
            // 
            this.P_UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_UNIT.DataPropertyName = "P_UNIT";
            this.P_UNIT.HeaderText = "Đơn vị";
            this.P_UNIT.Name = "P_UNIT";
            this.P_UNIT.ReadOnly = true;
            this.P_UNIT.Width = 57;
            // 
            // P_COST
            // 
            this.P_COST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_COST.DataPropertyName = "P_COST";
            this.P_COST.HeaderText = "Thành tiền";
            this.P_COST.Name = "P_COST";
            this.P_COST.ReadOnly = true;
            this.P_COST.Width = 90;
            // 
            // PUR_DATE
            // 
            this.PUR_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PUR_DATE.DataPropertyName = "PUR_DATE";
            this.PUR_DATE.HeaderText = "Ngày đặt";
            this.PUR_DATE.Name = "PUR_DATE";
            this.PUR_DATE.ReadOnly = true;
            // 
            // MFG_DATE
            // 
            this.MFG_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MFG_DATE.DataPropertyName = "MFG_DATE";
            this.MFG_DATE.HeaderText = "Ngày sản xuất";
            this.MFG_DATE.Name = "MFG_DATE";
            this.MFG_DATE.ReadOnly = true;
            // 
            // EXP_DATE
            // 
            this.EXP_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EXP_DATE.DataPropertyName = "EXP_DATE";
            this.EXP_DATE.HeaderText = "Hạn sử dụng";
            this.EXP_DATE.Name = "EXP_DATE";
            this.EXP_DATE.ReadOnly = true;
            // 
            // P_STATUS
            // 
            this.P_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_STATUS.DataPropertyName = "P_STATUS";
            this.P_STATUS.HeaderText = "Trạng thái";
            this.P_STATUS.Name = "P_STATUS";
            this.P_STATUS.ReadOnly = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(735, 713);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(87, 36);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Kiểm kho";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // checkGoodsList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dgvGoodsList);
            this.Controls.Add(this.lblGoodsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkGoodsList";
            this.Text = "checkGoodsList";
            this.Load += new System.EventHandler(this.checkGoodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoodsList;
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
        private System.Windows.Forms.Button btnCheck;
    }
}