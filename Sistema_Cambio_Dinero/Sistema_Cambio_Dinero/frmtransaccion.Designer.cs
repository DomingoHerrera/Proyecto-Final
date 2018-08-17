namespace Sistema_Cambio_Dinero
{
    partial class frmtransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtransaccion));
            this.btncompra = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncompra
            // 
            this.btncompra.BackColor = System.Drawing.Color.Maroon;
            this.btncompra.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btncompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompra.Image = ((System.Drawing.Image)(resources.GetObject("btncompra.Image")));
            this.btncompra.Location = new System.Drawing.Point(100, 48);
            this.btncompra.Name = "btncompra";
            this.btncompra.Size = new System.Drawing.Size(189, 89);
            this.btncompra.TabIndex = 0;
            this.btncompra.Text = "Compra";
            this.btncompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncompra.UseVisualStyleBackColor = false;
            this.btncompra.Click += new System.EventHandler(this.btncompra_Click);
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.Color.Maroon;
            this.btnventa.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.Image = ((System.Drawing.Image)(resources.GetObject("btnventa.Image")));
            this.btnventa.Location = new System.Drawing.Point(418, 48);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(186, 89);
            this.btnventa.TabIndex = 1;
            this.btnventa.Text = "Venta";
            this.btnventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(369, 211);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 30);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncompra);
            this.groupBox1.Controls.Add(this.btnventa);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(46, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transacciones";
            // 
            // frmtransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(827, 273);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmtransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtransaccion";
            this.Load += new System.EventHandler(this.frmtransaccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncompra;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}