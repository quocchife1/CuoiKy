namespace Pharmacy
{
    partial class CustomerInfor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomList = new System.Windows.Forms.Label();
            this.dgvCustomInfor = new System.Windows.Forms.DataGridView();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DATE_OF_BIRTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomList
            // 
            this.lblCustomList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomList.AutoSize = true;
            this.lblCustomList.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblCustomList.Location = new System.Drawing.Point(223, 43);
            this.lblCustomList.Name = "lblCustomList";
            this.lblCustomList.Size = new System.Drawing.Size(388, 34);
            this.lblCustomList.TabIndex = 5;
            this.lblCustomList.Text = "DANH SÁCH KHÁCH HÀNG";
            this.lblCustomList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCustomInfor
            // 
            this.dgvCustomInfor.AllowUserToAddRows = false;
            this.dgvCustomInfor.AllowUserToDeleteRows = false;
            this.dgvCustomInfor.AllowUserToResizeColumns = false;
            this.dgvCustomInfor.AllowUserToResizeRows = false;
            this.dgvCustomInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomInfor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCustomInfor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomInfor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvCustomInfor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomInfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomInfor.ColumnHeadersHeight = 54;
            this.dgvCustomInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_NAME,
            this.C_SEX,
            this.C_DATE_OF_BIRTH,
            this.C_PHONE,
            this.C_MAIL});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomInfor.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomInfor.EnableHeadersVisualStyles = false;
            this.dgvCustomInfor.Location = new System.Drawing.Point(12, 96);
            this.dgvCustomInfor.Name = "dgvCustomInfor";
            this.dgvCustomInfor.ReadOnly = true;
            this.dgvCustomInfor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomInfor.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomInfor.RowHeadersVisible = false;
            this.dgvCustomInfor.RowHeadersWidth = 51;
            this.dgvCustomInfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomInfor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCustomInfor.RowTemplate.DividerHeight = 1;
            this.dgvCustomInfor.RowTemplate.Height = 30;
            this.dgvCustomInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomInfor.Size = new System.Drawing.Size(810, 653);
            this.dgvCustomInfor.TabIndex = 4;
            // 
            // C_ID
            // 
            this.C_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_ID.DataPropertyName = "C_ID";
            this.C_ID.HeaderText = "Mã khách hàng";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            // 
            // C_NAME
            // 
            this.C_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_NAME.DataPropertyName = "C_NAME";
            this.C_NAME.HeaderText = "Họ và tên";
            this.C_NAME.Name = "C_NAME";
            this.C_NAME.ReadOnly = true;
            // 
            // C_SEX
            // 
            this.C_SEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.C_SEX.DataPropertyName = "C_SEX";
            this.C_SEX.HeaderText = "Giới tính";
            this.C_SEX.Name = "C_SEX";
            this.C_SEX.ReadOnly = true;
            this.C_SEX.Width = 56;
            // 
            // C_DATE_OF_BIRTH
            // 
            this.C_DATE_OF_BIRTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_DATE_OF_BIRTH.DataPropertyName = "C_DATE_OF_BIRTH";
            this.C_DATE_OF_BIRTH.HeaderText = "Ngày sinh";
            this.C_DATE_OF_BIRTH.Name = "C_DATE_OF_BIRTH";
            this.C_DATE_OF_BIRTH.ReadOnly = true;
            // 
            // C_PHONE
            // 
            this.C_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_PHONE.DataPropertyName = "C_PHONE";
            this.C_PHONE.HeaderText = "SĐT";
            this.C_PHONE.Name = "C_PHONE";
            this.C_PHONE.ReadOnly = true;
            // 
            // C_MAIL
            // 
            this.C_MAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_MAIL.DataPropertyName = "C_MAIL";
            this.C_MAIL.HeaderText = "MAIL";
            this.C_MAIL.Name = "C_MAIL";
            this.C_MAIL.ReadOnly = true;
            // 
            // CustomerInfor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.lblCustomList);
            this.Controls.Add(this.dgvCustomInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfor";
            this.Text = "CustomerInfor";
            this.Load += new System.EventHandler(this.CustomerInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomList;
        private System.Windows.Forms.DataGridView dgvCustomInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DATE_OF_BIRTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_MAIL;
    }
}