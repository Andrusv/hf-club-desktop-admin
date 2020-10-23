namespace Presentation
{
    partial class HFD_Generate_Coupons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFD_Generate_Coupons));
            this.btnArrowBack = new System.Windows.Forms.PictureBox();
            this.pctArrowBack = new System.Windows.Forms.PictureBox();
            this.txtCoupons = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCreateCoupons = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
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
            this.btnArrowBack.TabIndex = 13;
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
            this.pctArrowBack.TabIndex = 14;
            this.pctArrowBack.TabStop = false;
            this.pctArrowBack.Visible = false;
            // 
            // txtCoupons
            // 
            this.txtCoupons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCoupons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoupons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoupons.ForeColor = System.Drawing.Color.DimGray;
            this.txtCoupons.Location = new System.Drawing.Point(125, 139);
            this.txtCoupons.MaxLength = 6;
            this.txtCoupons.Name = "txtCoupons";
            this.txtCoupons.Size = new System.Drawing.Size(241, 22);
            this.txtCoupons.TabIndex = 1;
            this.txtCoupons.Text = "NUMERO DE CUPONES A CREAR";
            this.txtCoupons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCoupons.Enter += new System.EventHandler(this.txtCoupons_Enter);
            this.txtCoupons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoupons_KeyPress);
            this.txtCoupons.Leave += new System.EventHandler(this.txtCoupons_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 79;
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
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // btnCreateCoupons
            // 
            this.btnCreateCoupons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCreateCoupons.FlatAppearance.BorderSize = 0;
            this.btnCreateCoupons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCreateCoupons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateCoupons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCoupons.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCoupons.ForeColor = System.Drawing.Color.LightGray;
            this.btnCreateCoupons.Location = new System.Drawing.Point(79, 188);
            this.btnCreateCoupons.Name = "btnCreateCoupons";
            this.btnCreateCoupons.Size = new System.Drawing.Size(329, 40);
            this.btnCreateCoupons.TabIndex = 0;
            this.btnCreateCoupons.Text = "CREAR";
            this.btnCreateCoupons.UseVisualStyleBackColor = false;
            this.btnCreateCoupons.Click += new System.EventHandler(this.btnCreateCoupons_ClickAsync);
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
            this.txtResponse.TabIndex = 2;
            // 
            // HFD_Generate_Coupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnCreateCoupons);
            this.Controls.Add(this.txtCoupons);
            this.Controls.Add(this.btnArrowBack);
            this.Controls.Add(this.pctArrowBack);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HFD_Generate_Coupons";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HFD_Generate_Coupons";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HFD_Generate_Coupons_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArrowBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnArrowBack;
        private System.Windows.Forms.PictureBox pctArrowBack;
        private System.Windows.Forms.TextBox txtCoupons;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnCreateCoupons;
        private System.Windows.Forms.TextBox txtResponse;
    }
}