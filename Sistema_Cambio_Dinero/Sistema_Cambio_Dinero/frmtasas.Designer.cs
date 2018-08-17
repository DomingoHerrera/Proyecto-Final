namespace Sistema_Cambio_Dinero
{
    partial class frmtasas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtasas));
            this.label1 = new System.Windows.Forms.Label();
            this.lbldolar = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncambiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbotras = new System.Windows.Forms.RadioButton();
            this.rbeuro = new System.Windows.Forms.RadioButton();
            this.rbdolar = new System.Windows.Forms.RadioButton();
            this.txtventao = new System.Windows.Forms.TextBox();
            this.txtcomprao = new System.Windows.Forms.TextBox();
            this.txtventae = new System.Windows.Forms.TextBox();
            this.txtcomprae = new System.Windows.Forms.TextBox();
            this.txtventad = new System.Windows.Forms.TextBox();
            this.txtcomprad = new System.Windows.Forms.TextBox();
            this.cbotras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACION DE TASAS";
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Location = new System.Drawing.Point(119, 146);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(65, 24);
            this.lbldolar.TabIndex = 1;
            this.lbldolar.Text = "Dólar";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.Location = new System.Drawing.Point(135, 208);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(54, 24);
            this.lbleuro.TabIndex = 2;
            this.lbleuro.Text = "Euro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btncambiar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtventao);
            this.groupBox1.Controls.Add(this.txtcomprao);
            this.groupBox1.Controls.Add(this.txtventae);
            this.groupBox1.Controls.Add(this.txtcomprae);
            this.groupBox1.Controls.Add(this.txtventad);
            this.groupBox1.Controls.Add(this.txtcomprad);
            this.groupBox1.Controls.Add(this.cbotras);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbldolar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbleuro);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 388);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Tasas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Maroon;
            this.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(628, 161);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(198, 63);
            this.btnnuevo.TabIndex = 17;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Maroon;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(628, 319);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(198, 63);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncambiar
            // 
            this.btncambiar.BackColor = System.Drawing.Color.Maroon;
            this.btncambiar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btncambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncambiar.Image = ((System.Drawing.Image)(resources.GetObject("btncambiar.Image")));
            this.btncambiar.Location = new System.Drawing.Point(628, 240);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(198, 63);
            this.btncambiar.TabIndex = 15;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncambiar.UseVisualStyleBackColor = false;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Maroon;
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(628, 82);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(198, 63);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.rbotras);
            this.panel1.Controls.Add(this.rbeuro);
            this.panel1.Controls.Add(this.rbdolar);
            this.panel1.Location = new System.Drawing.Point(25, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 44);
            this.panel1.TabIndex = 13;
            // 
            // rbotras
            // 
            this.rbotras.AutoSize = true;
            this.rbotras.Location = new System.Drawing.Point(616, 8);
            this.rbotras.Name = "rbotras";
            this.rbotras.Size = new System.Drawing.Size(185, 28);
            this.rbotras.TabIndex = 2;
            this.rbotras.TabStop = true;
            this.rbotras.Text = "Otras monedas";
            this.rbotras.UseVisualStyleBackColor = true;
            this.rbotras.CheckedChanged += new System.EventHandler(this.rbotras_CheckedChanged);
            // 
            // rbeuro
            // 
            this.rbeuro.AutoSize = true;
            this.rbeuro.Location = new System.Drawing.Point(343, 8);
            this.rbeuro.Name = "rbeuro";
            this.rbeuro.Size = new System.Drawing.Size(72, 28);
            this.rbeuro.TabIndex = 1;
            this.rbeuro.TabStop = true;
            this.rbeuro.Text = "Euro";
            this.rbeuro.UseVisualStyleBackColor = true;
            this.rbeuro.CheckedChanged += new System.EventHandler(this.rbeuro_CheckedChanged);
            // 
            // rbdolar
            // 
            this.rbdolar.AutoSize = true;
            this.rbdolar.Location = new System.Drawing.Point(17, 8);
            this.rbdolar.Name = "rbdolar";
            this.rbdolar.Size = new System.Drawing.Size(83, 28);
            this.rbdolar.TabIndex = 0;
            this.rbdolar.TabStop = true;
            this.rbdolar.Text = "Dolar";
            this.rbdolar.UseVisualStyleBackColor = true;
            this.rbdolar.CheckedChanged += new System.EventHandler(this.rbdolar_CheckedChanged);
            // 
            // txtventao
            // 
            this.txtventao.Enabled = false;
            this.txtventao.Location = new System.Drawing.Point(423, 270);
            this.txtventao.Name = "txtventao";
            this.txtventao.Size = new System.Drawing.Size(177, 33);
            this.txtventao.TabIndex = 12;
            // 
            // txtcomprao
            // 
            this.txtcomprao.Enabled = false;
            this.txtcomprao.Location = new System.Drawing.Point(216, 270);
            this.txtcomprao.Name = "txtcomprao";
            this.txtcomprao.Size = new System.Drawing.Size(177, 33);
            this.txtcomprao.TabIndex = 11;
            // 
            // txtventae
            // 
            this.txtventae.Enabled = false;
            this.txtventae.Location = new System.Drawing.Point(423, 208);
            this.txtventae.Name = "txtventae";
            this.txtventae.Size = new System.Drawing.Size(177, 33);
            this.txtventae.TabIndex = 10;
            // 
            // txtcomprae
            // 
            this.txtcomprae.Enabled = false;
            this.txtcomprae.Location = new System.Drawing.Point(216, 208);
            this.txtcomprae.Name = "txtcomprae";
            this.txtcomprae.Size = new System.Drawing.Size(177, 33);
            this.txtcomprae.TabIndex = 9;
            // 
            // txtventad
            // 
            this.txtventad.Enabled = false;
            this.txtventad.Location = new System.Drawing.Point(423, 143);
            this.txtventad.Name = "txtventad";
            this.txtventad.Size = new System.Drawing.Size(177, 33);
            this.txtventad.TabIndex = 8;
            // 
            // txtcomprad
            // 
            this.txtcomprad.Enabled = false;
            this.txtcomprad.Location = new System.Drawing.Point(216, 143);
            this.txtcomprad.Name = "txtcomprad";
            this.txtcomprad.Size = new System.Drawing.Size(177, 33);
            this.txtcomprad.TabIndex = 7;
            // 
            // cbotras
            // 
            this.cbotras.Enabled = false;
            this.cbotras.FormattingEnabled = true;
            this.cbotras.Location = new System.Drawing.Point(10, 271);
            this.cbotras.Name = "cbotras";
            this.cbotras.Size = new System.Drawing.Size(179, 32);
            this.cbotras.TabIndex = 6;
            this.cbotras.Text = "Yen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(618, 451);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(76, 24);
            this.lblusuario.TabIndex = 8;
            this.lblusuario.Text = "♠♠♠♠♠♠";
            // 
            // frmtasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(866, 484);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmtasas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtasas";
            this.Load += new System.EventHandler(this.frmtasas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.Label lbleuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtventao;
        private System.Windows.Forms.TextBox txtcomprao;
        private System.Windows.Forms.TextBox txtventae;
        private System.Windows.Forms.TextBox txtcomprae;
        private System.Windows.Forms.TextBox txtventad;
        private System.Windows.Forms.TextBox txtcomprad;
        private System.Windows.Forms.ComboBox cbotras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbotras;
        private System.Windows.Forms.RadioButton rbeuro;
        private System.Windows.Forms.RadioButton rbdolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
    }
}