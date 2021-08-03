namespace CapaPresentacion
{
    partial class FrmVentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTotal_Pagar = new System.Windows.Forms.Label();
            this.lblIDVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataDetalle = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalle)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(183)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 116);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Ventas.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 476);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblHora);
            this.tabPage1.Controls.Add(this.lblTotal_Pagar);
            this.tabPage1.Controls.Add(this.lblIDVenta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtIdVenta);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.dataDetalle);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(319, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 21);
            this.lblHora.TabIndex = 5;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal_Pagar
            // 
            this.lblTotal_Pagar.AutoSize = true;
            this.lblTotal_Pagar.Location = new System.Drawing.Point(133, 399);
            this.lblTotal_Pagar.Name = "lblTotal_Pagar";
            this.lblTotal_Pagar.Size = new System.Drawing.Size(0, 16);
            this.lblTotal_Pagar.TabIndex = 11;
            // 
            // lblIDVenta
            // 
            this.lblIDVenta.AutoSize = true;
            this.lblIDVenta.Location = new System.Drawing.Point(22, 13);
            this.lblIDVenta.Name = "lblIDVenta";
            this.lblIDVenta.Size = new System.Drawing.Size(58, 16);
            this.lblIDVenta.TabIndex = 3;
            this.lblIDVenta.Text = "ID Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total a Pagar:  Q";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(91, 10);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(100, 21);
            this.txtIdVenta.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(396, 392);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtIdProducto);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.txtNIT);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnBuscarProductos);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(19, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 21);
            this.txtCodigo.TabIndex = 106;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(32, 86);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(36, 21);
            this.txtIdProducto.TabIndex = 105;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(32, 64);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(36, 21);
            this.txtIdCliente.TabIndex = 104;
            // 
            // txtNIT
            // 
            this.txtNIT.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(385, 35);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(88, 23);
            this.txtNIT.TabIndex = 103;
            this.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(105, 64);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(319, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "NIT:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(105, 35);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(244, 23);
            this.txtNombres.TabIndex = 101;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente:";
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Location = new System.Drawing.Point(358, 112);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(115, 23);
            this.btnBuscarProductos.TabIndex = 2;
            this.btnBuscarProductos.Text = " Buscar Productos";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(496, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 138);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(141, 72);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(70, 21);
            this.txtDescuento.TabIndex = 5;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Q";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio unitario:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(119, 43);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(92, 21);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(20, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(141, 14);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(70, 21);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Location = new System.Drawing.Point(119, 99);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(85, 28);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Q";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(105, 112);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(244, 23);
            this.txtProducto.TabIndex = 100;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Producto:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(515, 392);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataDetalle
            // 
            this.dataDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalle.Location = new System.Drawing.Point(25, 194);
            this.dataDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataDetalle.Name = "dataDetalle";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDetalle.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDetalle.Size = new System.Drawing.Size(742, 180);
            this.dataDetalle.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(634, 392);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtListado);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro de ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Location = new System.Drawing.Point(41, 99);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtListado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtListado.Size = new System.Drawing.Size(694, 342);
            this.dtListado.TabIndex = 0;
            this.dtListado.DoubleClick += new System.EventHandler(this.dtListado_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnImprimir);
            this.groupBox4.Controls.Add(this.btnRestablecer);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.cmbOpciones);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.dtpFecha1);
            this.groupBox4.Controls.Add(this.dtpFecha2);
            this.groupBox4.Location = new System.Drawing.Point(41, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(694, 87);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ventas";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(543, 27);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 23);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(394, 27);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(143, 23);
            this.btnRestablecer.TabIndex = 9;
            this.btnRestablecer.Text = "Restablecer Busqueda";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(108, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 8;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(111, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 21);
            this.txtBuscar.TabIndex = 7;
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "Fecha:",
            "Cliente:"});
            this.cmbOpciones.Location = new System.Drawing.Point(8, 27);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(100, 24);
            this.cmbOpciones.TabIndex = 6;
            this.cmbOpciones.Text = "Fecha:";
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(313, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(111, 29);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(95, 21);
            this.dtpFecha1.TabIndex = 1;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(212, 29);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(95, 21);
            this.dtpFecha2.TabIndex = 2;
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(830, 650);
            this.MinimumSize = new System.Drawing.Size(830, 650);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Registro de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVentas_FormClosing);
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTotal_Pagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataDetalle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblIDVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnImprimir;
    }
}