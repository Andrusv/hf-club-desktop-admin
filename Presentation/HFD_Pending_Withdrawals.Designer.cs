namespace Presentation
{
    partial class HFD_Pending_Withdrawals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFD_Pending_Withdrawals));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArrowBack = new System.Windows.Forms.PictureBox();
            this.pctArrowBack = new System.Windows.Forms.PictureBox();
            this.dgvPendingWithdrawals = new Guna.UI.WinForms.GunaDataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingWithdrawals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "RETIROS POR APROBAR";
            // 
            // btnArrowBack
            // 
            this.btnArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("btnArrowBack.Image")));
            this.btnArrowBack.Location = new System.Drawing.Point(12, 12);
            this.btnArrowBack.Name = "btnArrowBack";
            this.btnArrowBack.Size = new System.Drawing.Size(32, 32);
            this.btnArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnArrowBack.TabIndex = 21;
            this.btnArrowBack.TabStop = false;
            this.btnArrowBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnArrowBack_MouseDown);
            this.btnArrowBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArrowBack_MouseUp);
            // 
            // pctArrowBack
            // 
            this.pctArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("pctArrowBack.Image")));
            this.pctArrowBack.Location = new System.Drawing.Point(13, 13);
            this.pctArrowBack.Name = "pctArrowBack";
            this.pctArrowBack.Size = new System.Drawing.Size(28, 31);
            this.pctArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctArrowBack.TabIndex = 22;
            this.pctArrowBack.TabStop = false;
            this.pctArrowBack.Visible = false;
            // 
            // dgvPendingWithdrawals
            // 
            this.dgvPendingWithdrawals.AllowUserToAddRows = false;
            this.dgvPendingWithdrawals.AllowUserToDeleteRows = false;
            this.dgvPendingWithdrawals.AllowUserToResizeColumns = false;
            this.dgvPendingWithdrawals.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvPendingWithdrawals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendingWithdrawals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingWithdrawals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendingWithdrawals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPendingWithdrawals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(169)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(169)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendingWithdrawals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPendingWithdrawals.ColumnHeadersHeight = 40;
            this.dgvPendingWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendingWithdrawals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.balance});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingWithdrawals.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPendingWithdrawals.EnableHeadersVisualStyles = false;
            this.dgvPendingWithdrawals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.Location = new System.Drawing.Point(33, 67);
            this.dgvPendingWithdrawals.Name = "dgvPendingWithdrawals";
            this.dgvPendingWithdrawals.ReadOnly = true;
            this.dgvPendingWithdrawals.RowHeadersVisible = false;
            this.dgvPendingWithdrawals.RowTemplate.Height = 40;
            this.dgvPendingWithdrawals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingWithdrawals.Size = new System.Drawing.Size(417, 293);
            this.dgvPendingWithdrawals.TabIndex = 26;
            this.dgvPendingWithdrawals.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvPendingWithdrawals.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPendingWithdrawals.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgvPendingWithdrawals.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvPendingWithdrawals.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(169)))), ((int)(((byte)(74)))));
            this.dgvPendingWithdrawals.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPendingWithdrawals.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPendingWithdrawals.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPendingWithdrawals.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPendingWithdrawals.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPendingWithdrawals.ThemeStyle.ReadOnly = true;
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.LightGray;
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPendingWithdrawals.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvPendingWithdrawals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingWithdrawals_CellContentClick);
            // 
            // user_id
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.user_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.user_id.HeaderText = "user_ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // balance
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.balance.DefaultCellStyle = dataGridViewCellStyle4;
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // HFD_Pending_Withdrawals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.dgvPendingWithdrawals);
            this.Controls.Add(this.btnArrowBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctArrowBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HFD_Pending_Withdrawals";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HFD_Pending_Withdrawals";
            this.Load += new System.EventHandler(this.HFD_Pending_Withdrawals_LoadAsync);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HFD_Pending_Withdrawals_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingWithdrawals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnArrowBack;
        private System.Windows.Forms.PictureBox pctArrowBack;
        private Guna.UI.WinForms.GunaDataGridView dgvPendingWithdrawals;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}