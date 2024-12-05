﻿namespace Pharmacy
{
    partial class ManagerList
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
            this.lblPharmacistList = new System.Windows.Forms.Label();
            this.dgvManagerList = new System.Windows.Forms.DataGridView();
            this.EMP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_DATE_OF_BIRTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_JOB_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUP_ADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPharmacistList
            // 
            this.lblPharmacistList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPharmacistList.AutoSize = true;
            this.lblPharmacistList.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblPharmacistList.Location = new System.Drawing.Point(186, 43);
            this.lblPharmacistList.Name = "lblPharmacistList";
            this.lblPharmacistList.Size = new System.Drawing.Size(322, 34);
            this.lblPharmacistList.TabIndex = 3;
            this.lblPharmacistList.Text = "DANH SÁCH QUẢN LÝ";
            // 
            // dgvManagerList
            // 
            this.dgvManagerList.AllowUserToAddRows = false;
            this.dgvManagerList.AllowUserToDeleteRows = false;
            this.dgvManagerList.AllowUserToResizeColumns = false;
            this.dgvManagerList.AllowUserToResizeRows = false;
            this.dgvManagerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManagerList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvManagerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvManagerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvManagerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagerList.ColumnHeadersHeight = 54;
            this.dgvManagerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManagerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMP_ID,
            this.EMP_NAME,
            this.EMP_SEX,
            this.EMP_DATE_OF_BIRTH,
            this.EMP_TYPE,
            this.EMP_JOB_DATE,
            this.EMP_PHONE,
            this.EMP_MAIL,
            this.SUP_ADD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManagerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagerList.EnableHeadersVisualStyles = false;
            this.dgvManagerList.Location = new System.Drawing.Point(12, 96);
            this.dgvManagerList.Name = "dgvManagerList";
            this.dgvManagerList.ReadOnly = true;
            this.dgvManagerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManagerList.RowHeadersVisible = false;
            this.dgvManagerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvManagerList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvManagerList.RowTemplate.DividerHeight = 1;
            this.dgvManagerList.RowTemplate.Height = 30;
            this.dgvManagerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagerList.Size = new System.Drawing.Size(710, 503);
            this.dgvManagerList.TabIndex = 2;
            // 
            // EMP_ID
            // 
            this.EMP_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_ID.DataPropertyName = "EMP_ID";
            this.EMP_ID.HeaderText = "ID";
            this.EMP_ID.Name = "EMP_ID";
            this.EMP_ID.ReadOnly = true;
            // 
            // EMP_NAME
            // 
            this.EMP_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_NAME.DataPropertyName = "EMP_NAME";
            this.EMP_NAME.HeaderText = "Họ tên";
            this.EMP_NAME.Name = "EMP_NAME";
            this.EMP_NAME.ReadOnly = true;
            // 
            // EMP_SEX
            // 
            this.EMP_SEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_SEX.DataPropertyName = "EMP_SEX";
            this.EMP_SEX.HeaderText = "Giới tính";
            this.EMP_SEX.Name = "EMP_SEX";
            this.EMP_SEX.ReadOnly = true;
            // 
            // EMP_DATE_OF_BIRTH
            // 
            this.EMP_DATE_OF_BIRTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_DATE_OF_BIRTH.DataPropertyName = "EMP_DATE_OF_BIRTH";
            this.EMP_DATE_OF_BIRTH.HeaderText = "Ngày sinh";
            this.EMP_DATE_OF_BIRTH.Name = "EMP_DATE_OF_BIRTH";
            this.EMP_DATE_OF_BIRTH.ReadOnly = true;
            // 
            // EMP_TYPE
            // 
            this.EMP_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_TYPE.DataPropertyName = "EMP_TYPE";
            this.EMP_TYPE.HeaderText = "Chức vụ";
            this.EMP_TYPE.Name = "EMP_TYPE";
            this.EMP_TYPE.ReadOnly = true;
            // 
            // EMP_JOB_DATE
            // 
            this.EMP_JOB_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_JOB_DATE.DataPropertyName = "EMP_JOB_DATE";
            this.EMP_JOB_DATE.HeaderText = "Ngày nhận việc";
            this.EMP_JOB_DATE.Name = "EMP_JOB_DATE";
            this.EMP_JOB_DATE.ReadOnly = true;
            // 
            // EMP_PHONE
            // 
            this.EMP_PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_PHONE.DataPropertyName = "EMP_PHONE";
            this.EMP_PHONE.HeaderText = "SĐT";
            this.EMP_PHONE.Name = "EMP_PHONE";
            this.EMP_PHONE.ReadOnly = true;
            // 
            // EMP_MAIL
            // 
            this.EMP_MAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMP_MAIL.DataPropertyName = "EMP_MAIL";
            this.EMP_MAIL.HeaderText = "MAIL";
            this.EMP_MAIL.Name = "EMP_MAIL";
            this.EMP_MAIL.ReadOnly = true;
            // 
            // SUP_ADD
            // 
            this.SUP_ADD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUP_ADD.DataPropertyName = "SUP_ADD";
            this.SUP_ADD.HeaderText = "Cửa hàng";
            this.SUP_ADD.Name = "SUP_ADD";
            this.SUP_ADD.ReadOnly = true;
            // 
            // ManagerList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.lblPharmacistList);
            this.Controls.Add(this.dgvManagerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerList";
            this.Text = "ManagerList";
            this.Load += new System.EventHandler(this.ManagerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPharmacistList;
        private System.Windows.Forms.DataGridView dgvManagerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_DATE_OF_BIRTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_JOB_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_MAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUP_ADD;
    }
}