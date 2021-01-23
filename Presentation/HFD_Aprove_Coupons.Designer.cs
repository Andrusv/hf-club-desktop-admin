namespace Presentation
{
    partial class HFD_Aprove_Coupons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFD_Aprove_Coupons));
            this.btnArrowBack = new System.Windows.Forms.PictureBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txb_Response = new System.Windows.Forms.TextBox();
            this.txb_Link = new System.Windows.Forms.TextBox();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.txb_Acumulado = new System.Windows.Forms.TextBox();
            this.lbl_Acumulado = new System.Windows.Forms.Label();
            this.pctArrowBack = new System.Windows.Forms.PictureBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
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
            this.btnArrowBack.TabIndex = 22;
            this.btnArrowBack.TabStop = false;
            this.btnArrowBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnArrowBack_MouseDown);
            this.btnArrowBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArrowBack_MouseUp);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserId.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserId.Location = new System.Drawing.Point(74, 11);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(70, 37);
            this.lblUserId.TabIndex = 25;
            this.lblUserId.Text = "User";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(478, 392);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 35;
            this.lineShape1.X2 = 431;
            this.lineShape1.Y1 = 164;
            this.lineShape1.Y2 = 164;
            // 
            // txb_Response
            // 
            this.txb_Response.CausesValidation = false;
            this.txb_Response.Enabled = false;
            this.txb_Response.Location = new System.Drawing.Point(45, 183);
            this.txb_Response.Multiline = true;
            this.txb_Response.Name = "txb_Response";
            this.txb_Response.Size = new System.Drawing.Size(377, 132);
            this.txb_Response.TabIndex = 27;
            // 
            // txb_Link
            // 
            this.txb_Link.Enabled = false;
            this.txb_Link.Location = new System.Drawing.Point(237, 128);
            this.txb_Link.Name = "txb_Link";
            this.txb_Link.Size = new System.Drawing.Size(174, 20);
            this.txb_Link.TabIndex = 28;
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Link.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Link.Location = new System.Drawing.Point(55, 122);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(50, 25);
            this.lbl_Link.TabIndex = 29;
            this.lbl_Link.Text = "Link:";
            // 
            // txb_Acumulado
            // 
            this.txb_Acumulado.Enabled = false;
            this.txb_Acumulado.Location = new System.Drawing.Point(237, 82);
            this.txb_Acumulado.Name = "txb_Acumulado";
            this.txb_Acumulado.Size = new System.Drawing.Size(121, 20);
            this.txb_Acumulado.TabIndex = 30;
            // 
            // lbl_Acumulado
            // 
            this.lbl_Acumulado.AutoSize = true;
            this.lbl_Acumulado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Acumulado.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Acumulado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Acumulado.Location = new System.Drawing.Point(55, 77);
            this.lbl_Acumulado.Name = "lbl_Acumulado";
            this.lbl_Acumulado.Size = new System.Drawing.Size(112, 25);
            this.lbl_Acumulado.TabIndex = 31;
            this.lbl_Acumulado.Text = "Acumulado:";
            // 
            // pctArrowBack
            // 
            this.pctArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("pctArrowBack.Image")));
            this.pctArrowBack.Location = new System.Drawing.Point(13, 13);
            this.pctArrowBack.Name = "pctArrowBack";
            this.pctArrowBack.Size = new System.Drawing.Size(28, 31);
            this.pctArrowBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctArrowBack.TabIndex = 32;
            this.pctArrowBack.TabStop = false;
            this.pctArrowBack.Visible = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.LightGray;
            this.btnReject.Location = new System.Drawing.Point(45, 342);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(99, 23);
            this.btnReject.TabIndex = 35;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReject_MouseUp);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.LightGray;
            this.btnAccept.Location = new System.Drawing.Point(323, 342);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 23);
            this.btnAccept.TabIndex = 36;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAccept_MouseUpAsync);
            // 
            // HFD_Aprove_Coupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lbl_Acumulado);
            this.Controls.Add(this.txb_Acumulado);
            this.Controls.Add(this.lbl_Link);
            this.Controls.Add(this.txb_Link);
            this.Controls.Add(this.txb_Response);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnArrowBack);
            this.Controls.Add(this.pctArrowBack);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HFD_Aprove_Coupons";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HFD_Aprove_Coupons";
            this.Load += new System.EventHandler(this.HFD_Aprove_Coupons_LoadAsync);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HFD_Aprove_Coupons_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnArrowBack;
        private System.Windows.Forms.Label lblUserId;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txb_Response;
        private System.Windows.Forms.TextBox txb_Link;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.TextBox txb_Acumulado;
        private System.Windows.Forms.Label lbl_Acumulado;
        private System.Windows.Forms.PictureBox pctArrowBack;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
    }
}