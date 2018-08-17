namespace Sistema_Cambio_Dinero
{
    partial class frmconsulta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnventas = new System.Windows.Forms.Button();
            this.btncuadre = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.btntasas = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnventas);
            this.groupBox1.Controls.Add(this.btncuadre);
            this.groupBox1.Controls.Add(this.btnusuario);
            this.groupBox1.Controls.Add(this.btncompras);
            this.groupBox1.Controls.Add(this.btntasas);
            this.groupBox1.Controls.Add(this.btnclientes);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de consultas";
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.Maroon;
            this.btnventas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Location = new System.Drawing.Point(51, 145);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(248, 63);
            this.btnventas.TabIndex = 7;
            this.btnventas.Text = "Ventas";
            this.btnventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btncuadre
            // 
            this.btncuadre.BackColor = System.Drawing.Color.Maroon;
            this.btncuadre.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btncuadre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncuadre.Location = new System.Drawing.Point(729, 145);
            this.btncuadre.Name = "btncuadre";
            this.btncuadre.Size = new System.Drawing.Size(248, 63);
            this.btncuadre.TabIndex = 6;
            this.btncuadre.Text = "Cuadre";
            this.btncuadre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncuadre.UseVisualStyleBackColor = false;
            this.btncuadre.Click += new System.EventHandler(this.btncuadre_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.Maroon;
            this.btnusuario.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuario.Location = new System.Drawing.Point(51, 53);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(248, 63);
            this.btnusuario.TabIndex = 4;
            this.btnusuario.Text = "Usuario";
            this.btnusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.Color.Maroon;
            this.btncompras.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Location = new System.Drawing.Point(384, 145);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(248, 63);
            this.btncompras.TabIndex = 3;
            this.btncompras.Text = "Compra";
            this.btncompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncompras.UseVisualStyleBackColor = false;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // btntasas
            // 
            this.btntasas.BackColor = System.Drawing.Color.Maroon;
            this.btntasas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btntasas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btntasas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntasas.Location = new System.Drawing.Point(729, 53);
            this.btntasas.Name = "btntasas";
            this.btntasas.Size = new System.Drawing.Size(248, 63);
            this.btntasas.TabIndex = 1;
            this.btntasas.Text = "Tasas";
            this.btntasas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntasas.UseVisualStyleBackColor = false;
            this.btntasas.Click += new System.EventHandler(this.btntasas_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.Maroon;
            this.btnclientes.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Location = new System.Drawing.Point(384, 53);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(248, 63);
            this.btnclientes.TabIndex = 0;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(458, 348);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1036, 410);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmconsulta";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btncuadre;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btntasas;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}