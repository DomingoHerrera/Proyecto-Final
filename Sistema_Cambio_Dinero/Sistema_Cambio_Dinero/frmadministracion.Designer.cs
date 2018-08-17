namespace Sistema_Cambio_Dinero
{
    partial class frmadministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadministracion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btntasas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btntasas);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnusuarios);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(721, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de administracion";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(404, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "Control de cajas";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btntasas
            // 
            this.btntasas.BackColor = System.Drawing.Color.Maroon;
            this.btntasas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btntasas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btntasas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntasas.Image = ((System.Drawing.Image)(resources.GetObject("btntasas.Image")));
            this.btntasas.Location = new System.Drawing.Point(38, 161);
            this.btntasas.Name = "btntasas";
            this.btntasas.Size = new System.Drawing.Size(259, 65);
            this.btntasas.TabIndex = 2;
            this.btntasas.Text = "Control de tasas";
            this.btntasas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntasas.UseVisualStyleBackColor = false;
            this.btntasas.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(404, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Privilegios";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.Color.Maroon;
            this.btnusuarios.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnusuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnusuarios.Image")));
            this.btnusuarios.Location = new System.Drawing.Point(38, 62);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(259, 65);
            this.btnusuarios.TabIndex = 0;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(383, 322);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmadministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(846, 381);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmadministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmadministracion";
            this.Load += new System.EventHandler(this.frmadministracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btntasas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}