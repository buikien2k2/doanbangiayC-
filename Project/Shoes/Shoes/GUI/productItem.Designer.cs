namespace Shoes.GUI
{
    partial class productItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productItem));
            this.lb_productName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_amount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lb_price = new Bunifu.UI.WinForms.BunifuLabel();
            this.imgBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lb_size = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // lb_productName
            // 
            this.lb_productName.AllowParentOverrides = false;
            this.lb_productName.AutoEllipsis = true;
            this.lb_productName.AutoSize = false;
            this.lb_productName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_productName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lb_productName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb_productName.Location = new System.Drawing.Point(14, 261);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_productName.Size = new System.Drawing.Size(230, 22);
            this.lb_productName.TabIndex = 1;
            this.lb_productName.Text = "Title:";
            this.lb_productName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_productName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_amount
            // 
            this.lb_amount.AllowParentOverrides = false;
            this.lb_amount.AutoEllipsis = false;
            this.lb_amount.CursorType = null;
            this.lb_amount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount.Location = new System.Drawing.Point(14, 289);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_amount.Size = new System.Drawing.Size(55, 17);
            this.lb_amount.TabIndex = 2;
            this.lb_amount.Text = "Số lượng: ";
            this.lb_amount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_amount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lb_price
            // 
            this.lb_price.AllowParentOverrides = false;
            this.lb_price.AutoEllipsis = true;
            this.lb_price.CursorType = null;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(14, 312);
            this.lb_price.Name = "lb_price";
            this.lb_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_price.Size = new System.Drawing.Size(23, 17);
            this.lb_price.TabIndex = 3;
            this.lb_price.Text = "Giá: ";
            this.lb_price.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_price.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // imgBtn
            // 
            this.imgBtn.ActiveImage = null;
            this.imgBtn.AllowAnimations = true;
            this.imgBtn.AllowBuffering = false;
            this.imgBtn.AllowToggling = false;
            this.imgBtn.AllowZooming = true;
            this.imgBtn.AllowZoomingOnFocus = false;
            this.imgBtn.BackColor = System.Drawing.Color.Transparent;
            this.imgBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgBtn.ErrorImage")));
            this.imgBtn.FadeWhenInactive = false;
            this.imgBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgBtn.Image = ((System.Drawing.Image)(resources.GetObject("imgBtn.Image")));
            this.imgBtn.ImageActive = null;
            this.imgBtn.ImageLocation = null;
            this.imgBtn.ImageMargin = 40;
            this.imgBtn.ImageSize = new System.Drawing.Size(220, 220);
            this.imgBtn.ImageZoomSize = new System.Drawing.Size(260, 260);
            this.imgBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBtn.InitialImage")));
            this.imgBtn.Location = new System.Drawing.Point(0, 0);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Rotation = 0;
            this.imgBtn.ShowActiveImage = true;
            this.imgBtn.ShowCursorChanges = true;
            this.imgBtn.ShowImageBorders = true;
            this.imgBtn.ShowSizeMarkers = false;
            this.imgBtn.Size = new System.Drawing.Size(260, 260);
            this.imgBtn.TabIndex = 0;
            this.imgBtn.ToolTipText = "";
            this.imgBtn.WaitOnLoad = false;
            this.imgBtn.Zoom = 40;
            this.imgBtn.ZoomSpeed = 10;
            this.imgBtn.Click += new System.EventHandler(this.imgBtn_Click);
            // 
            // lb_size
            // 
            this.lb_size.AllowParentOverrides = false;
            this.lb_size.AutoEllipsis = false;
            this.lb_size.CursorType = null;
            this.lb_size.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_size.Location = new System.Drawing.Point(143, 289);
            this.lb_size.Name = "lb_size";
            this.lb_size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_size.Size = new System.Drawing.Size(27, 17);
            this.lb_size.TabIndex = 4;
            this.lb_size.Text = "Size: ";
            this.lb_size.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_size.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // productItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.lb_productName);
            this.Controls.Add(this.imgBtn);
            this.Name = "productItem";
            this.Size = new System.Drawing.Size(260, 359);
            this.MouseEnter += new System.EventHandler(this.product_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.product_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton imgBtn;
        private Bunifu.UI.WinForms.BunifuLabel lb_productName;
        private Bunifu.UI.WinForms.BunifuLabel lb_amount;
        private Bunifu.UI.WinForms.BunifuLabel lb_price;
        private Bunifu.UI.WinForms.BunifuLabel lb_size;
    }
}
