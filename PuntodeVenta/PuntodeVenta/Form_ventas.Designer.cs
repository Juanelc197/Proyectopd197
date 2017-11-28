namespace PuntodeVenta
{
    partial class Form_ventas
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.comboproducto = new System.Windows.Forms.ComboBox();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_presioU = new System.Windows.Forms.Label();
            this.txt_PU = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataMostrarInfo = new System.Windows.Forms.DataGridView();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkB_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_canselar = new System.Windows.Forms.Button();
            this.combocliente = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_con = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.lbl_letra = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_conCant = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.datefechaventa = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.comboFormadePago = new System.Windows.Forms.ComboBox();
            this.lbl_FormadePago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarInfo)).BeginInit();
            this.panelcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_titulo.Location = new System.Drawing.Point(289, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(73, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Venta";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 66);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfc.ForeColor = System.Drawing.Color.White;
            this.lbl_rfc.Location = new System.Drawing.Point(13, 117);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(35, 13);
            this.lbl_rfc.TabIndex = 2;
            this.lbl_rfc.Text = "RFC:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_telefono.Location = new System.Drawing.Point(13, 166);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(61, 13);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(334, 66);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.White;
            this.lbl_direccion.Location = new System.Drawing.Point(334, 117);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(65, 13);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 83);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(12, 133);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(144, 20);
            this.txt_rfc.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(12, 182);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(144, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(337, 83);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(234, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(337, 133);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(280, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.White;
            this.lbl_producto.Location = new System.Drawing.Point(12, 260);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(62, 13);
            this.lbl_producto.TabIndex = 11;
            this.lbl_producto.Text = "Producto:";
            // 
            // comboproducto
            // 
            this.comboproducto.FormattingEnabled = true;
            this.comboproducto.Location = new System.Drawing.Point(12, 276);
            this.comboproducto.Name = "comboproducto";
            this.comboproducto.Size = new System.Drawing.Size(121, 21);
            this.comboproducto.TabIndex = 12;
            this.comboproducto.SelectedIndexChanged += new System.EventHandler(this.comboproducto_SelectedIndexChanged);
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.ForeColor = System.Drawing.Color.White;
            this.lbl_cant.Location = new System.Drawing.Point(179, 260);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(61, 13);
            this.lbl_cant.TabIndex = 13;
            this.lbl_cant.Text = "Cantidad:";
            // 
            // lbl_presioU
            // 
            this.lbl_presioU.AutoSize = true;
            this.lbl_presioU.BackColor = System.Drawing.Color.Transparent;
            this.lbl_presioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presioU.ForeColor = System.Drawing.Color.White;
            this.lbl_presioU.Location = new System.Drawing.Point(291, 260);
            this.lbl_presioU.Name = "lbl_presioU";
            this.lbl_presioU.Size = new System.Drawing.Size(95, 13);
            this.lbl_presioU.TabIndex = 15;
            this.lbl_presioU.Text = "Precio Unitario:";
            // 
            // txt_PU
            // 
            this.txt_PU.Location = new System.Drawing.Point(294, 276);
            this.txt_PU.Name = "txt_PU";
            this.txt_PU.Size = new System.Drawing.Size(95, 20);
            this.txt_PU.TabIndex = 16;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BackgroundImage = global::PuntodeVenta.Properties.Resources.hecho;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(520, 268);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(48, 34);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dataMostrarInfo
            // 
            this.dataMostrarInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMostrarInfo.Location = new System.Drawing.Point(56, 354);
            this.dataMostrarInfo.Name = "dataMostrarInfo";
            this.dataMostrarInfo.Size = new System.Drawing.Size(561, 150);
            this.dataMostrarInfo.TabIndex = 18;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.White;
            this.lbl_subtotal.Location = new System.Drawing.Point(13, 522);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(62, 13);
            this.lbl_subtotal.TabIndex = 22;
            this.lbl_subtotal.Text = "SubTotal:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(15, 538);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 23;
            // 
            // checkB_iva
            // 
            this.checkB_iva.AutoSize = true;
            this.checkB_iva.BackColor = System.Drawing.Color.Transparent;
            this.checkB_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkB_iva.ForeColor = System.Drawing.Color.White;
            this.checkB_iva.Location = new System.Drawing.Point(16, 564);
            this.checkB_iva.Name = "checkB_iva";
            this.checkB_iva.Size = new System.Drawing.Size(54, 17);
            this.checkB_iva.TabIndex = 24;
            this.checkB_iva.Text = "I.V.A";
            this.checkB_iva.UseVisualStyleBackColor = false;
            this.checkB_iva.CheckedChanged += new System.EventHandler(this.checkB_iva_CheckedChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_total.Location = new System.Drawing.Point(13, 591);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 13);
            this.lbl_total.TabIndex = 25;
            this.lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(12, 607);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 26;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // btn_venta
            // 
            this.btn_venta.BackColor = System.Drawing.Color.Transparent;
            this.btn_venta.BackgroundImage = global::PuntodeVenta.Properties.Resources.venta;
            this.btn_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_venta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venta.Location = new System.Drawing.Point(540, 624);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(48, 34);
            this.btn_venta.TabIndex = 27;
            this.btn_venta.UseVisualStyleBackColor = false;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // btn_canselar
            // 
            this.btn_canselar.BackColor = System.Drawing.Color.Transparent;
            this.btn_canselar.BackgroundImage = global::PuntodeVenta.Properties.Resources.boton_cancelar;
            this.btn_canselar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_canselar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_canselar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_canselar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canselar.Location = new System.Drawing.Point(614, 624);
            this.btn_canselar.Name = "btn_canselar";
            this.btn_canselar.Size = new System.Drawing.Size(48, 34);
            this.btn_canselar.TabIndex = 28;
            this.btn_canselar.UseVisualStyleBackColor = false;
            // 
            // combocliente
            // 
            this.combocliente.FormattingEnabled = true;
            this.combocliente.Location = new System.Drawing.Point(504, 34);
            this.combocliente.Name = "combocliente";
            this.combocliente.Size = new System.Drawing.Size(121, 21);
            this.combocliente.TabIndex = 31;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = global::PuntodeVenta.Properties.Resources.lupa_de_busqueda;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(475, 32);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(23, 21);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_con
            // 
            this.lbl_con.AutoSize = true;
            this.lbl_con.BackColor = System.Drawing.Color.Transparent;
            this.lbl_con.Location = new System.Drawing.Point(650, 34);
            this.lbl_con.Name = "lbl_con";
            this.lbl_con.Size = new System.Drawing.Size(14, 13);
            this.lbl_con.TabIndex = 33;
            this.lbl_con.Text = "#";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImage = global::PuntodeVenta.Properties.Resources.flechatras;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(12, 13);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(47, 30);
            this.btn_regresar.TabIndex = 39;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panelcolor
            // 
            this.panelcolor.Controls.Add(this.lbl_FormadePago);
            this.panelcolor.Controls.Add(this.comboFormadePago);
            this.panelcolor.Controls.Add(this.lbl_letra);
            this.panelcolor.Controls.Add(this.txt_Precio);
            this.panelcolor.Controls.Add(this.txt_conCant);
            this.panelcolor.Controls.Add(this.txt_iva);
            this.panelcolor.Controls.Add(this.datefechaventa);
            this.panelcolor.Controls.Add(this.lbl_fecha);
            this.panelcolor.Controls.Add(this.btn_regresar);
            this.panelcolor.Controls.Add(this.btn_venta);
            this.panelcolor.Controls.Add(this.btn_canselar);
            this.panelcolor.Controls.Add(this.btn_agregar);
            this.panelcolor.Controls.Add(this.lbl_con);
            this.panelcolor.Controls.Add(this.lbl_presioU);
            this.panelcolor.Controls.Add(this.combocliente);
            this.panelcolor.Controls.Add(this.btn_buscar);
            this.panelcolor.Controls.Add(this.lbl_cant);
            this.panelcolor.Controls.Add(this.txt_direccion);
            this.panelcolor.Controls.Add(this.lbl_producto);
            this.panelcolor.Controls.Add(this.txt_email);
            this.panelcolor.Controls.Add(this.lbl_direccion);
            this.panelcolor.Controls.Add(this.lbl_email);
            this.panelcolor.Controls.Add(this.lbl_telefono);
            this.panelcolor.Controls.Add(this.lbl_total);
            this.panelcolor.Controls.Add(this.lbl_rfc);
            this.panelcolor.Controls.Add(this.checkB_iva);
            this.panelcolor.Controls.Add(this.lbl_nombre);
            this.panelcolor.Controls.Add(this.lbl_titulo);
            this.panelcolor.Controls.Add(this.lbl_subtotal);
            this.panelcolor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcolor.Location = new System.Drawing.Point(0, 0);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(674, 670);
            this.panelcolor.TabIndex = 40;
            // 
            // lbl_letra
            // 
            this.lbl_letra.AutoSize = true;
            this.lbl_letra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_letra.ForeColor = System.Drawing.Color.White;
            this.lbl_letra.Location = new System.Drawing.Point(12, 645);
            this.lbl_letra.Name = "lbl_letra";
            this.lbl_letra.Size = new System.Drawing.Size(95, 13);
            this.lbl_letra.TabIndex = 45;
            this.lbl_letra.Text = "Total en letra...";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(327, 302);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(35, 20);
            this.txt_Precio.TabIndex = 44;
            this.txt_Precio.Visible = false;
            // 
            // txt_conCant
            // 
            this.txt_conCant.Location = new System.Drawing.Point(182, 277);
            this.txt_conCant.Name = "txt_conCant";
            this.txt_conCant.Size = new System.Drawing.Size(58, 20);
            this.txt_conCant.TabIndex = 43;
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(77, 564);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(22, 20);
            this.txt_iva.TabIndex = 42;
            this.txt_iva.Visible = false;
            // 
            // datefechaventa
            // 
            this.datefechaventa.Location = new System.Drawing.Point(337, 181);
            this.datefechaventa.Name = "datefechaventa";
            this.datefechaventa.Size = new System.Drawing.Size(200, 20);
            this.datefechaventa.TabIndex = 41;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(334, 166);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(46, 13);
            this.lbl_fecha.TabIndex = 40;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // comboFormadePago
            // 
            this.comboFormadePago.FormattingEnabled = true;
            this.comboFormadePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheque"});
            this.comboFormadePago.Location = new System.Drawing.Point(244, 538);
            this.comboFormadePago.Name = "comboFormadePago";
            this.comboFormadePago.Size = new System.Drawing.Size(121, 21);
            this.comboFormadePago.TabIndex = 46;
            // 
            // lbl_FormadePago
            // 
            this.lbl_FormadePago.AutoSize = true;
            this.lbl_FormadePago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FormadePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormadePago.ForeColor = System.Drawing.Color.White;
            this.lbl_FormadePago.Location = new System.Drawing.Point(241, 522);
            this.lbl_FormadePago.Name = "lbl_FormadePago";
            this.lbl_FormadePago.Size = new System.Drawing.Size(96, 13);
            this.lbl_FormadePago.TabIndex = 47;
            this.lbl_FormadePago.Text = "Forma de Pago:";
            // 
            // Form_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuntodeVenta.Properties.Resources.fondo1delsel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 670);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.dataMostrarInfo);
            this.Controls.Add(this.txt_PU);
            this.Controls.Add(this.comboproducto);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.panelcolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ventas";
            this.Load += new System.EventHandler(this.Form_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarInfo)).EndInit();
            this.panelcolor.ResumeLayout(false);
            this.panelcolor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.ComboBox comboproducto;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_presioU;
        private System.Windows.Forms.TextBox txt_PU;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataMostrarInfo;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkB_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_canselar;
        private System.Windows.Forms.ComboBox combocliente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_con;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.DateTimePicker datefechaventa;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_conCant;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_letra;
        private System.Windows.Forms.Label lbl_FormadePago;
        private System.Windows.Forms.ComboBox comboFormadePago;
    }
}