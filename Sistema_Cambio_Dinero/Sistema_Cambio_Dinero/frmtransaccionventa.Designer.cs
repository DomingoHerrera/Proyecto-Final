namespace Sistema_Cambio_Dinero
{
    partial class frmtransaccionventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtransaccionventa));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnom = new System.Windows.Forms.Button();
            this.btneuro = new System.Windows.Forms.Button();
            this.btndolar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtccedula = new System.Windows.Forms.TextBox();
            this.txtcnombre = new System.Windows.Forms.TextBox();
            this.txtccodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.txtventa = new System.Windows.Forms.TextBox();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtttotal = new System.Windows.Forms.TextBox();
            this.txttdevuelto = new System.Windows.Forms.TextBox();
            this.txttpesos = new System.Windows.Forms.TextBox();
            this.txttrecibido = new System.Windows.Forms.TextBox();
            this.txttmonto = new System.Windows.Forms.TextBox();
            this.txttcodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACCION DE VENTA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnom);
            this.panel1.Controls.Add(this.btneuro);
            this.panel1.Controls.Add(this.btndolar);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 64);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(795, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ir a compras";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnom
            // 
            this.btnom.BackColor = System.Drawing.Color.Maroon;
            this.btnom.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnom.Image = ((System.Drawing.Image)(resources.GetObject("btnom.Image")));
            this.btnom.Location = new System.Drawing.Point(494, 9);
            this.btnom.Name = "btnom";
            this.btnom.Size = new System.Drawing.Size(257, 41);
            this.btnom.TabIndex = 2;
            this.btnom.Text = "Otras monedas";
            this.btnom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnom.UseVisualStyleBackColor = false;
            // 
            // btneuro
            // 
            this.btneuro.BackColor = System.Drawing.Color.Maroon;
            this.btneuro.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btneuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneuro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneuro.Image = ((System.Drawing.Image)(resources.GetObject("btneuro.Image")));
            this.btneuro.Location = new System.Drawing.Point(247, 9);
            this.btneuro.Name = "btneuro";
            this.btneuro.Size = new System.Drawing.Size(164, 41);
            this.btneuro.TabIndex = 1;
            this.btneuro.Text = "Euro";
            this.btneuro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneuro.UseVisualStyleBackColor = false;
            // 
            // btndolar
            // 
            this.btndolar.BackColor = System.Drawing.Color.Maroon;
            this.btndolar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btndolar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btndolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndolar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndolar.Image = ((System.Drawing.Image)(resources.GetObject("btndolar.Image")));
            this.btndolar.Location = new System.Drawing.Point(17, 9);
            this.btndolar.Name = "btndolar";
            this.btndolar.Size = new System.Drawing.Size(164, 41);
            this.btndolar.TabIndex = 0;
            this.btndolar.Text = "Dolar";
            this.btndolar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndolar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtccedula);
            this.groupBox1.Controls.Add(this.txtcnombre);
            this.groupBox1.Controls.Add(this.txtccodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel3.Location = new System.Drawing.Point(338, 131);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(75, 24);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Añadir";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(338, 82);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(81, 24);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Limpiar";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(338, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buscar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // txtccedula
            // 
            this.txtccedula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccedula.Location = new System.Drawing.Point(121, 128);
            this.txtccedula.Name = "txtccedula";
            this.txtccedula.Size = new System.Drawing.Size(188, 31);
            this.txtccedula.TabIndex = 5;
            // 
            // txtcnombre
            // 
            this.txtcnombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnombre.Location = new System.Drawing.Point(121, 81);
            this.txtcnombre.Name = "txtcnombre";
            this.txtcnombre.Size = new System.Drawing.Size(188, 31);
            this.txtcnombre.TabIndex = 4;
            // 
            // txtccodigo
            // 
            this.txtccodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtccodigo.Location = new System.Drawing.Point(121, 32);
            this.txtccodigo.Name = "txtccodigo";
            this.txtccodigo.Size = new System.Drawing.Size(188, 31);
            this.txtccodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel5);
            this.groupBox2.Controls.Add(this.txtventa);
            this.groupBox2.Controls.Add(this.txtcompra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(565, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 197);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tasa de cambio";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel5.Location = new System.Drawing.Point(375, 84);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(107, 24);
            this.linkLabel5.TabIndex = 8;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Consultar";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // txtventa
            // 
            this.txtventa.Enabled = false;
            this.txtventa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtventa.Location = new System.Drawing.Point(160, 120);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(188, 31);
            this.txtventa.TabIndex = 7;
            this.txtventa.Text = "49.50";
            // 
            // txtcompra
            // 
            this.txtcompra.Enabled = false;
            this.txtcompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompra.Location = new System.Drawing.Point(160, 76);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(188, 31);
            this.txtcompra.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "♠♠♠";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Moneda:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel4);
            this.groupBox3.Controls.Add(this.lblusuario);
            this.groupBox3.Controls.Add(this.txtttotal);
            this.groupBox3.Controls.Add(this.txttdevuelto);
            this.groupBox3.Controls.Add(this.txttpesos);
            this.groupBox3.Controls.Add(this.txttrecibido);
            this.groupBox3.Controls.Add(this.txttmonto);
            this.groupBox3.Controls.Add(this.txttcodigo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 233);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaccion";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel4.Location = new System.Drawing.Point(338, 43);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(77, 24);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Buscar";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(928, 29);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 24);
            this.lblusuario.TabIndex = 18;
            this.lblusuario.Text = "♠♠♠";
            // 
            // txtttotal
            // 
            this.txtttotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttotal.Location = new System.Drawing.Point(752, 121);
            this.txtttotal.Name = "txtttotal";
            this.txtttotal.Size = new System.Drawing.Size(268, 41);
            this.txtttotal.TabIndex = 17;
            this.txtttotal.TextChanged += new System.EventHandler(this.txtttotal_TextChanged);
            // 
            // txttdevuelto
            // 
            this.txttdevuelto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttdevuelto.Location = new System.Drawing.Point(517, 149);
            this.txttdevuelto.Name = "txttdevuelto";
            this.txttdevuelto.Size = new System.Drawing.Size(188, 31);
            this.txttdevuelto.TabIndex = 16;
            // 
            // txttpesos
            // 
            this.txttpesos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttpesos.Location = new System.Drawing.Point(517, 95);
            this.txttpesos.MaxLength = 7;
            this.txttpesos.Name = "txttpesos";
            this.txttpesos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txttpesos.Size = new System.Drawing.Size(188, 31);
            this.txttpesos.TabIndex = 15;
            // 
            // txttrecibido
            // 
            this.txttrecibido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrecibido.Location = new System.Drawing.Point(144, 95);
            this.txttrecibido.Name = "txttrecibido";
            this.txttrecibido.Size = new System.Drawing.Size(188, 31);
            this.txttrecibido.TabIndex = 14;
            this.txttrecibido.TextChanged += new System.EventHandler(this.txttrecibido_TextChanged);
            // 
            // txttmonto
            // 
            this.txttmonto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttmonto.Location = new System.Drawing.Point(144, 156);
            this.txttmonto.Name = "txttmonto";
            this.txttmonto.Size = new System.Drawing.Size(188, 31);
            this.txttmonto.TabIndex = 13;
            this.txttmonto.TextChanged += new System.EventHandler(this.txttmonto_TextChanged);
            // 
            // txttcodigo
            // 
            this.txttcodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttcodigo.Location = new System.Drawing.Point(144, 42);
            this.txttcodigo.Name = "txttcodigo";
            this.txttcodigo.Size = new System.Drawing.Size(188, 31);
            this.txttcodigo.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(792, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Usuario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Monto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "RD-recibido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Internacional:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "$ devuelto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(792, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total entregado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 6;
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
            this.btnfacturar.Location = new System.Drawing.Point(12, 589);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(234, 60);
            this.btnfacturar.TabIndex = 4;
            this.btnfacturar.Text = "Facturar";
            this.btnfacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfacturar.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Maroon;
            this.btnmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(287, 589);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(227, 60);
            this.btnmodificar.TabIndex = 5;
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
            this.btnlimpiar.Location = new System.Drawing.Point(582, 589);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(223, 60);
            this.btnlimpiar.TabIndex = 6;
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
            this.btncancelar.Location = new System.Drawing.Point(861, 589);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(206, 60);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmtransaccionventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1079, 662);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnfacturar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmtransaccionventa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtransaccionventa";
            this.Load += new System.EventHandler(this.frmtransaccionventa_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnom;
        private System.Windows.Forms.Button btneuro;
        private System.Windows.Forms.Button btndolar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtccedula;
        private System.Windows.Forms.TextBox txtcnombre;
        private System.Windows.Forms.TextBox txtccodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtventa;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttpesos;
        private System.Windows.Forms.TextBox txttrecibido;
        private System.Windows.Forms.TextBox txttmonto;
        private System.Windows.Forms.TextBox txttcodigo;
        private System.Windows.Forms.TextBox txttdevuelto;
        private System.Windows.Forms.TextBox txtttotal;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}