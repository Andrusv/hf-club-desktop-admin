namespace Presentation
{
    partial class HFD_Aproved_Withdrawals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFD_Aproved_Withdrawals));
            this.btnArrowBack = new System.Windows.Forms.PictureBox();
            this.pctArrowBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArrowBack
            // 
            this.btnArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("btnArrowBack.Image")));
            this.btnArrowBack.Location = new System.Drawing.Point(12, 12);
            this.btnArrowBack.Name = "btnArrowBack";
            this.btnArrowBack.Size = new System.Drawing.Size(32, 32);
            this.btnArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnArrowBack.TabIndex = 33;
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
            this.pctArrowBack.TabIndex = 34;
            this.pctArrowBack.TabStop = false;
            this.pctArrowBack.Visible = false;
            // 
            // HFD_Aproved_Withdrawals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.btnArrowBack);
            this.Controls.Add(this.pctArrowBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HFD_Aproved_Withdrawals";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HFD_Aproved_Withdrawals";
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnArrowBack;
        private System.Windows.Forms.PictureBox pctArrowBack;
    }
}