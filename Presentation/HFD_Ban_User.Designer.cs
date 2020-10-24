namespace Presentation
{
    partial class HFD_Ban_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFD_Ban_User));
            this.btnArrowBack = new System.Windows.Forms.PictureBox();
            this.pctArrowBack = new System.Windows.Forms.PictureBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnBanUser = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnArrowBack.TabIndex = 14;
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
            this.pctArrowBack.TabIndex = 15;
            this.pctArrowBack.TabStop = false;
            this.pctArrowBack.Visible = false;
            // 
            // txtResponse
            // 
            this.txtResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResponse.Enabled = false;
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(79, 269);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(329, 69);
            this.txtResponse.TabIndex = 18;
            // 
            // btnBanUser
            // 
            this.btnBanUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBanUser.FlatAppearance.BorderSize = 0;
            this.btnBanUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBanUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnBanUser.Location = new System.Drawing.Point(79, 188);
            this.btnBanUser.Name = "btnBanUser";
            this.btnBanUser.Size = new System.Drawing.Size(329, 40);
            this.btnBanUser.TabIndex = 16;
            this.btnBanUser.Text = "BANEAR";
            this.btnBanUser.UseVisualStyleBackColor = false;
            this.btnBanUser.Click += new System.EventHandler(this.btnBanUser_ClickAsync);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserId.Location = new System.Drawing.Point(125, 139);
            this.txtUserId.MaxLength = 24;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(241, 22);
            this.txtUserId.TabIndex = 17;
            this.txtUserId.Text = "USER ID";
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserId.Enter += new System.EventHandler(this.txtUserId_Enter);
            this.txtUserId.Leave += new System.EventHandler(this.txtUserId_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 75;
            this.lineShape1.X2 = 407;
            this.lineShape1.Y1 = 162;
            this.lineShape1.Y2 = 162;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(478, 392);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(178, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "BAN USER";
            // 
            // HFD_Ban_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnBanUser);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnArrowBack);
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.pctArrowBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HFD_Ban_User";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HFD_Ban_User";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HFD_Ban_User_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnArrowBack;
        private System.Windows.Forms.PictureBox pctArrowBack;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnBanUser;
        private System.Windows.Forms.TextBox txtUserId;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
    }
}