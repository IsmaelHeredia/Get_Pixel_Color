namespace GetPixelColor
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tmGetPixel = new System.Windows.Forms.Timer(this.components);
            this.pbFuture = new System.Windows.Forms.PictureBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.lblHTML = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtRGB = new System.Windows.Forms.TextBox();
            this.gbSintax = new System.Windows.Forms.GroupBox();
            this.cmbSintax = new System.Windows.Forms.ComboBox();
            this.gbManual = new System.Windows.Forms.GroupBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuture)).BeginInit();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.gbColors.SuspendLayout();
            this.gbSintax.SuspendLayout();
            this.gbManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmGetPixel
            // 
            this.tmGetPixel.Enabled = true;
            this.tmGetPixel.Tick += new System.EventHandler(this.tmGetPixel_Tick);
            // 
            // pbFuture
            // 
            this.pbFuture.BackColor = System.Drawing.Color.Transparent;
            this.pbFuture.Image = ((System.Drawing.Image)(resources.GetObject("pbFuture.Image")));
            this.pbFuture.Location = new System.Drawing.Point(360, 12);
            this.pbFuture.Name = "pbFuture";
            this.pbFuture.Size = new System.Drawing.Size(100, 286);
            this.pbFuture.TabIndex = 2;
            this.pbFuture.TabStop = false;
            // 
            // gbPreview
            // 
            this.gbPreview.BackColor = System.Drawing.Color.Transparent;
            this.gbPreview.Controls.Add(this.pbPreview);
            this.gbPreview.ForeColor = System.Drawing.Color.Lime;
            this.gbPreview.Location = new System.Drawing.Point(12, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(152, 100);
            this.gbPreview.TabIndex = 3;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Preview";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(22, 19);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(115, 65);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // gbColors
            // 
            this.gbColors.BackColor = System.Drawing.Color.Transparent;
            this.gbColors.Controls.Add(this.lblHTML);
            this.gbColors.Controls.Add(this.lblHex);
            this.gbColors.Controls.Add(this.lblRGB);
            this.gbColors.Controls.Add(this.txtHTML);
            this.gbColors.Controls.Add(this.txtHex);
            this.gbColors.Controls.Add(this.txtRGB);
            this.gbColors.ForeColor = System.Drawing.Color.Lime;
            this.gbColors.Location = new System.Drawing.Point(170, 12);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(184, 100);
            this.gbColors.TabIndex = 4;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Colors";
            // 
            // lblHTML
            // 
            this.lblHTML.AutoSize = true;
            this.lblHTML.Location = new System.Drawing.Point(16, 77);
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Size = new System.Drawing.Size(46, 13);
            this.lblHTML.TabIndex = 8;
            this.lblHTML.Text = "HTML : ";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(27, 49);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(35, 13);
            this.lblHex.TabIndex = 7;
            this.lblHex.Text = "Hex : ";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(23, 22);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(39, 13);
            this.lblRGB.TabIndex = 6;
            this.lblRGB.Text = "RGB : ";
            // 
            // txtHTML
            // 
            this.txtHTML.BackColor = System.Drawing.Color.Black;
            this.txtHTML.ForeColor = System.Drawing.Color.Red;
            this.txtHTML.Location = new System.Drawing.Point(62, 74);
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.ReadOnly = true;
            this.txtHTML.Size = new System.Drawing.Size(103, 20);
            this.txtHTML.TabIndex = 5;
            this.txtHTML.TabStop = false;
            // 
            // txtHex
            // 
            this.txtHex.BackColor = System.Drawing.Color.Black;
            this.txtHex.ForeColor = System.Drawing.Color.Red;
            this.txtHex.Location = new System.Drawing.Point(62, 46);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(103, 20);
            this.txtHex.TabIndex = 3;
            this.txtHex.TabStop = false;
            // 
            // txtRGB
            // 
            this.txtRGB.BackColor = System.Drawing.Color.Black;
            this.txtRGB.ForeColor = System.Drawing.Color.Red;
            this.txtRGB.Location = new System.Drawing.Point(62, 19);
            this.txtRGB.Name = "txtRGB";
            this.txtRGB.ReadOnly = true;
            this.txtRGB.Size = new System.Drawing.Size(103, 20);
            this.txtRGB.TabIndex = 1;
            this.txtRGB.TabStop = false;
            // 
            // gbSintax
            // 
            this.gbSintax.BackColor = System.Drawing.Color.Transparent;
            this.gbSintax.Controls.Add(this.cmbSintax);
            this.gbSintax.ForeColor = System.Drawing.Color.Lime;
            this.gbSintax.Location = new System.Drawing.Point(12, 129);
            this.gbSintax.Name = "gbSintax";
            this.gbSintax.Size = new System.Drawing.Size(127, 100);
            this.gbSintax.TabIndex = 5;
            this.gbSintax.TabStop = false;
            this.gbSintax.Text = "Sintax";
            // 
            // cmbSintax
            // 
            this.cmbSintax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSintax.FormattingEnabled = true;
            this.cmbSintax.Items.AddRange(new object[] {
            "None",
            "HTML",
            "CSS",
            "C#",
            "VB.NET",
            "Perl",
            "Python"});
            this.cmbSintax.Location = new System.Drawing.Point(17, 37);
            this.cmbSintax.Name = "cmbSintax";
            this.cmbSintax.Size = new System.Drawing.Size(90, 21);
            this.cmbSintax.TabIndex = 0;
            // 
            // gbManual
            // 
            this.gbManual.BackColor = System.Drawing.Color.Transparent;
            this.gbManual.Controls.Add(this.lblManual);
            this.gbManual.ForeColor = System.Drawing.Color.Lime;
            this.gbManual.Location = new System.Drawing.Point(145, 129);
            this.gbManual.Name = "gbManual";
            this.gbManual.Size = new System.Drawing.Size(209, 100);
            this.gbManual.TabIndex = 6;
            this.gbManual.TabStop = false;
            this.gbManual.Text = "Manual";
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.Color.Cyan;
            this.lblManual.Location = new System.Drawing.Point(6, 16);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(196, 52);
            this.lblManual.TabIndex = 0;
            this.lblManual.Text = "\r\nSelect Sintax and use Control+X \r\nto copy color to clipboard and a  \r\nsound wil" +
    "l warn you that copy";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.Yellow;
            this.lblCopyRight.Location = new System.Drawing.Point(30, 258);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(295, 20);
            this.lblCopyRight.TabIndex = 9;
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2017";
            this.lblCopyRight.Click += new System.EventHandler(this.lblCopyRight_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(472, 306);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.gbManual);
            this.Controls.Add(this.gbSintax);
            this.Controls.Add(this.gbColors);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.pbFuture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormHome";
            this.Text = " - GetPixelColor 0.4 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHome_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFuture)).EndInit();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.gbSintax.ResumeLayout(false);
            this.gbManual.ResumeLayout(false);
            this.gbManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmGetPixel;
        private System.Windows.Forms.PictureBox pbFuture;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.GroupBox gbSintax;
        private System.Windows.Forms.GroupBox gbManual;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.TextBox txtRGB;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.ComboBox cmbSintax;
        private System.Windows.Forms.Label lblHTML;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblRGB;
    }
}

