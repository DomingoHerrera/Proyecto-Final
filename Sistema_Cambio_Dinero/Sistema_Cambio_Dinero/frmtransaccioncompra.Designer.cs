namespace Sistema_Cambio_Dinero
{
    partial class frmtransaccioncompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtransaccioncompra));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limpiar1 = new System.Windows.Forms.LinkLabel();
            this.lblañadir = new System.Windows.Forms.LinkLabel();
            this.lblbuscar = new System.Windows.Forms.LinkLabel();
            this.txtccedula = new System.Windows.Forms.TextBox();
            this.txtcnombre = new System.Windows.Forms.TextBox();
            this.txtccodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnom = new System.Windows.Forms.Button();
            this.btneuro = new System.Windows.Forms.Button();
            this.btndolar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblconsultartasas = new System.Windows.Forms.LinkLabel();
            this.txttv = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblbuscart = new System.Windows.Forms.LinkLabel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtttotal = new System.Windows.Forms.TextBox();
            this.txttdevuelto = new System.Windows.Forms.TextBox();
            this.txttpesos = new System.Windows.Forms.TextBox();
            this.txttrecibido = new System.Windows.Forms.TextBox();
            this.txttmonto = new System.Windows.Forms.TextBox();
            this.txttcodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnfacturar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACCION DE COMPRA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiar1);
            this.groupBox1.Controls.Add(this.lblañadir);
            this.groupBox1.Controls.Add(this.lblbuscar);
            this.groupBox1.Controls.Add(this.txtccedula);
            this.groupBox1.Controls.Add(this.txtcnombre);
            this.groupBox1.Controls.Add(this.txtccodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // limpiar1
            // 
            this.limpiar1.AutoSize = true;
            this.limpiar1.LinkColor = System.Drawing.Color.Yellow;
            this.limpiar1.Location = new System.Drawing.Point(311, 84);
            this.limpiar1.Name = "limpiar1";
            this.limpiar1.Size = new System.Drawing.Size(81, 24);
            this.limpiar1.TabIndex = 9;
            this.limpiar1.TabStop = true;
            this.limpiar1.Text = "Limpiar";
            this.limpiar1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.limpiar1_LinkClicked);
            // 
            // lblañadir
            // 
            this.lblañadir.AutoSize = true;
            this.lblañadir.LinkColor = System.Drawing.Color.Yellow;
            this.lblañadir.Location = new System.Drawing.Point(317, 133);
            this.lblañadir.Name = "lblañadir";
            this.lblañadir.Size = new System.Drawing.Size(75, 24);
            this.lblañadir.TabIndex = 8;
            this.lblañadir.TabStop = true;
            this.lblañadir.Text = "Añadir";
            this.lblañadir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblañadir_LinkClicked);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.LinkColor = System.Drawing.Color.Yellow;
            this.lblbuscar.Location = new System.Drawing.Point(311, 33);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(77, 24);
            this.lblbuscar.TabIndex = 7;
            this.lblbuscar.TabStop = true;
            this.lblbuscar.Text = "Buscar";
            this.lblbuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblbuscar_LinkClicked);
            // 
            // txtccedula
            // 
            this.txtccedula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccedula.Location = new System.Drawing.Point(112, 142);
            this.txtccedula.Name = "txtccedula";
            this.txtccedula.Size = new System.Drawing.Size(193, 31);
            this.txtccedula.TabIndex = 6;
            // 
            // txtcnombre
            // 
            this.txtcnombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnombre.Location = new System.Drawing.Point(112, 84);
            this.txtcnombre.Name = "txtcnombre";
            this.txtcnombre.Size = new System.Drawing.Size(193, 31);
            this.txtcnombre.TabIndex = 5;
            // 
            // txtccodigo
            // 
            this.txtccodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccodigo.Location = new System.Drawing.Point(112, 32);
            this.txtccodigo.Name = "txtccodigo";
            this.txtccodigo.Size = new System.Drawing.Size(193, 31);
            this.txtccodigo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btnom);
            this.panel1.Controls.Add(this.btneuro);
            this.panel1.Controls.Add(this.btndolar);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 57);
            this.panel1.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Maroon;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(914, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 43);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ir a venta";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnom
            // 
            this.btnom.BackColor = System.Drawing.Color.Maroon;
            this.btnom.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnom.Image = ((System.Drawing.Image)(resources.GetObject("btnom.Image")));
            this.btnom.Location = new System.Drawing.Point(558, 9);
            this.btnom.Name = "btnom";
            this.btnom.Size = new System.Drawing.Size(264, 34);
            this.btnom.TabIndex = 2;
            this.btnom.Text = "Otras monedas";
            this.btnom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnom.UseVisualStyleBackColor = false;
            this.btnom.Click += new System.EventHandler(this.btnom_Click);
            // 
            // btneuro
            // 
            this.btneuro.BackColor = System.Drawing.Color.Maroon;
            this.btneuro.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btneuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneuro.Image = ((System.Drawing.Image)(resources.GetObject("btneuro.Image")));
            this.btneuro.Location = new System.Drawing.Point(314, 9);
            this.btneuro.Name = "btneuro";
            this.btneuro.Size = new System.Drawing.Size(183, 34);
            this.btneuro.TabIndex = 1;
            this.btneuro.Text = "Euro";
            this.btneuro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneuro.UseVisualStyleBackColor = false;
            this.btneuro.Click += new System.EventHandler(this.btneuro_Click);
            // 
            // btndolar
            // 
            this.btndolar.BackColor = System.Drawing.Color.Maroon;
            this.btndolar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btndolar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btndolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndolar.Image = ((System.Drawing.Image)(resources.GetObject("btndolar.Image")));
            this.btndolar.Location = new System.Drawing.Point(17, 9);
            this.btndolar.Name = "btndolar";
            this.btndolar.Size = new System.Drawing.Size(176, 34);
            this.btndolar.TabIndex = 0;
            this.btndolar.Text = "Dolar";
            this.btndolar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndolar.UseVisualStyleBackColor = false;
            this.btndolar.Click += new System.EventHandler(this.btndolar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblconsultartasas);
            this.groupBox2.Controls.Add(this.txttv);
            this.groupBox2.Controls.Add(this.txttc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(588, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 212);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasa de cambio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "♠♠♠♠";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblconsultartasas
            // 
            this.lblconsultartasas.AutoSize = true;
            this.lblconsultartasas.LinkColor = System.Drawing.Color.Yellow;
            this.lblconsultartasas.Location = new System.Drawing.Point(368, 103);
            this.lblconsultartasas.Name = "lblconsultartasas";
            this.lblconsultartasas.Size = new System.Drawing.Size(107, 24);
            this.lblconsultartasas.TabIndex = 5;
            this.lblconsultartasas.TabStop = true;
            this.lblconsultartasas.Text = "Consultar";
            this.lblconsultartasas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblconsultartasas_LinkClicked);
            // 
            // txttv
            // 
            this.txttv.Enabled = false;
            this.txttv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttv.Location = new System.Drawing.Point(158, 132);
            this.txttv.Name = "txttv";
            this.txttv.Size = new System.Drawing.Size(141, 31);
            this.txttv.TabIndex = 4;
            // 
            // txttc
            // 
            this.txttc.Enabled = false;
            this.txttc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttc.Location = new System.Drawing.Point(158, 77);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(141, 31);
            this.txttc.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Moneda:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblbuscart);
            this.groupBox3.Controls.Add(this.lblusuario);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtttotal);
            this.groupBox3.Controls.Add(this.txttdevuelto);
            this.groupBox3.Controls.Add(this.txttpesos);
            this.groupBox3.Controls.Add(this.txttrecibido);
            this.groupBox3.Controls.Add(this.txttmonto);
            this.groupBox3.Controls.Add(this.txttcodigo);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1114, 245);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaccion";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblbuscart
            // 
            this.lblbuscart.AutoSize = true;
            this.lblbuscart.LinkColor = System.Drawing.Color.Yellow;
            this.lblbuscart.Location = new System.Drawing.Point(325, 42);
            this.lblbuscart.Name = "lblbuscart";
            this.lblbuscart.Size = new System.Drawing.Size(77, 24);
            this.lblbuscart.TabIndex = 10;
            this.lblbuscart.TabStop = true;
            this.lblbuscart.Text = "Buscar";
            this.lblbuscart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblbuscart_LinkClicked);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(911, 47);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(54, 24);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "♠♠♠♠";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(796, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 24);
            this.label15.TabIndex = 18;
            this.label15.Text = "Usuario:";
            // 
            // txtttotal
            // 
            this.txtttotal.Enabled = false;
            this.txtttotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttotal.Location = new System.Drawing.Point(785, 132);
            this.txtttotal.Name = "txtttotal";
            this.txtttotal.Size = new System.Drawing.Size(308, 41);
            this.txtttotal.TabIndex = 17;
            this.txtttotal.TextChanged += new System.EventHandler(this.txtttotal_TextChanged);
            // 
            // txttdevuelto
            // 
            this.txttdevuelto.Enabled = false;
            this.txttdevuelto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttdevuelto.Location = new System.Drawing.Point(559, 156);
            this.txttdevuelto.Name = "txttdevuelto";
            this.txttdevuelto.Size = new System.Drawing.Size(193, 31);
            this.txttdevuelto.TabIndex = 16;
            // 
            // txttpesos
            // 
            this.txttpesos.Enabled = false;
            this.txttpesos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttpesos.Location = new System.Drawing.Point(559, 98);
            this.txttpesos.Name = "txttpesos";
            this.txttpesos.Size = new System.Drawing.Size(193, 31);
            this.txttpesos.TabIndex = 15;
            // 
            // txttrecibido
            // 
            this.txttrecibido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrecibido.Location = new System.Drawing.Point(209, 99);
            this.txttrecibido.Name = "txttrecibido";
            this.txttrecibido.Size = new System.Drawing.Size(193, 31);
            this.txttrecibido.TabIndex = 14;
            this.txttrecibido.TextChanged += new System.EventHandler(this.txttrecibido_TextChanged);
            // 
            // txttmonto
            // 
            this.txttmonto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttmonto.Location = new System.Drawing.Point(209, 158);
            this.txttmonto.Name = "txttmonto";
            this.txttmonto.Size = new System.Drawing.Size(193, 31);
            this.txttmonto.TabIndex = 13;
            this.txttmonto.TextChanged += new System.EventHandler(this.txttmonto_TextChanged);
            // 
            // txttcodigo
            // 
            this.txttcodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttcodigo.Location = new System.Drawing.Point(112, 41);
            this.txttcodigo.Name = "txttcodigo";
            this.txttcodigo.Size = new System.Drawing.Size(193, 31);
            this.txttcodigo.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(855, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total entregado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "$ devuelto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "$ recibido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "En pesos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Monto a cambiar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Codigo:";
            // 
            // btnfacturar
            // 
            this.btnfacturar.BackColor = System.Drawing.Color.Maroon;
            this.btnfacturar.Enabled = false;
            this.btnfacturar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnfacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnfacturar.Image")));
            this.btnfacturar.Location = new System.Drawing.Point(12, 620);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(203, 70);
            this.btnfacturar.TabIndex = 5;
            this.btnfacturar.Text = "Facturar";
            this.btnfacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfacturar.UseVisualStyleBackColor = false;
            this.btnfacturar.Click += new System.EventHandler(this.btnfacturar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Maroon;
            this.btnmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(273, 620);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(203, 70);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(571, 620);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(203, 70);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Maroon;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(871, 620);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(203, 70);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmtransaccioncompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1155, 711);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnfacturar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmtransaccioncompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtransaccioncompra";
            this.Load += new System.EventHandler(this.frmtransaccioncompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnom;
        private System.Windows.Forms.Button btneuro;
        private System.Windows.Forms.Button btndolar;
        private System.Windows.Forms.LinkLabel lblbuscar;
        private System.Windows.Forms.TextBox txtccedula;
        private System.Windows.Forms.TextBox txtcnombre;
        private System.Windows.Forms.TextBox txtccodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lblconsultartasas;
        private System.Windows.Forms.TextBox txttv;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtttotal;
        private System.Windows.Forms.TextBox txttdevuelto;
        private System.Windows.Forms.TextBox txttpesos;
        private System.Windows.Forms.TextBox txttrecibido;
        private System.Windows.Forms.TextBox txttmonto;
        private System.Windows.Forms.TextBox txttcodigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.LinkLabel limpiar1;
        private System.Windows.Forms.LinkLabel lblañadir;
        private System.Windows.Forms.LinkLabel lblbuscart;
        private System.Windows.Forms.Button button8;
    }
}