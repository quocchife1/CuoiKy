namespace Pharmacy
{
    partial class SuppliersList
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
            this.lblSuppliersList = new System.Windows.Forms.Label();
            this.dgvSuppliersList = new System.Windows.Forms.DataGridView();
            this.SUP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_ADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuppliersList
            // 
            this.lblSuppliersList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSuppliersList.AutoSize = true;
            this.lblSuppliersList.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblSuppliersList.Location = new System.Drawing.Point(194, 43);
            this.lblSuppliersList.Name = "lblSuppliersList";
            this.lblSuppliersList.Size = new System.Drawing.Size(415, 34);
            this.lblSuppliersList.TabIndex = 5;
            this.lblSuppliersList.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // dgvSuppliersList
            // 
            this.dgvSuppliersList.AllowUserToAddRows = false;
            this.dgvSuppliersList.AllowUserToDeleteRows = false;
            this.dgvSuppliersList.AllowUserToResizeColumns = false;
            this.dgvSuppliersList.AllowUserToResizeRows = false;
            this.dgvSuppliersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliersList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSuppliersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSuppliersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliersList.ColumnHeadersHeight = 54;
            this.dgvSuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUP_ID,
            this.SUP_NAME,
            this.SUP_ADD,
            this.SUP_PHONE,
            this.SUP_MAIL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliersList.EnableHeadersVisualStyles = false;
            this.dgvSuppliersList.Location = new System.Drawing.Point(12, 96);
            this.dgvSuppliersList.Name = "dgvSuppliersList";
            this.dgvSuppliersList.ReadOnly = true;
            this.dgvSuppliersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliersList.RowHeadersVisible = false;
            this.dgvSuppliersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSuppliersList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSuppliersList.RowTemplate.DividerHeight = 1;
            this.dgvSuppliersList.RowTemplate.Height = 30;
            this.dgvSuppliersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliersList.Size = new System.Drawing.Size(710, 503);
            this.dgvSuppliersList.TabIndex = 4;
            // 
            // SUP_ID
            // 
            this.SUP_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_ID.DataPropertyName = "SUP_ID";
            this.SUP_ID.HeaderText = "ID";
            this.SUP_ID.Name = "SUP_ID";
            this.SUP_ID.ReadOnly = true;
            // 
            // SUP_NAME
            // 
            this.SUP_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_NAME.DataPropertyName = "SUP_NAME";
            this.SUP_NAME.HeaderText = "Tên đơn vị";
            this.SUP_NAME.Name = "SUP_NAME";
            this.SUP_NAME.ReadOnly = true;
            // 
            // SUP_ADD
            // 
            this.SUP_ADD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_ADD.DataPropertyName = "SUP_ADD";
            this.SUP_ADD.HeaderText = "Cung cấp";
            this.SUP_ADD.Name = "SUP_ADD";
            this.SUP_ADD.ReadOnly = true;
            // 
            // SUP_PHONE
            // 
            this.SUP_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_PHONE.DataPropertyName = "SUP_PHONE";
            this.SUP_PHONE.HeaderText = "SĐT";
            this.SUP_PHONE.Name = "SUP_PHONE";
            this.SUP_PHONE.ReadOnly = true;
            // 
            // SUP_MAIL
            // 
            this.SUP_MAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_MAIL.DataPropertyName = "SUP_MAIL";
            this.SUP_MAIL.HeaderText = "MAIL";
            this.SUP_MAIL.Name = "SUP_MAIL";
            this.SUP_MAIL.ReadOnly = true;
            // 
            // SuppliersList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.lblSuppliersList);
            this.Controls.Add(this.dgvSuppliersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuppliersList";
            this.Text = "SuppliersList";
            this.Load += new System.EventHandler(this.SuppliersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuppliersList;
        private System.Windows.Forms.DataGridView dgvSuppliersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_MAIL;
    }
}