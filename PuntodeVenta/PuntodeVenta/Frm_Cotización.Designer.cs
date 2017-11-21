namespace PuntodeVenta
{
    partial class Frm_Cotización
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
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.comboNombreCli = new System.Windows.Forms.ComboBox();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label_vUnitario = new System.Windows.Forms.Label();
            this.txt_valorU = new System.Windows.Forms.TextBox();
            this.dataMostrarInfo = new System.Windows.Forms.DataGridView();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkB_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_canselar = new System.Windows.Forms.Button();
            this.numericCont = new System.Windows.Forms.NumericUpDown();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_idP = new System.Windows.Forms.TextBox();
            this.txt_conCant = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panelcolor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCont)).BeginInit();
            this.panelcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_titulo.Location = new System.Drawing.Point(314, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(130, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cotización ";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 69);
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
            this.lbl_rfc.Location = new System.Drawing.Point(12, 116);
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
            this.lbl_telefono.Location = new System.Drawing.Point(12, 158);
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
            this.lbl_email.Location = new System.Drawing.Point(379, 69);
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
            this.lbl_direccion.Location = new System.Drawing.Point(379, 116);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(65, 13);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(12, 129);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(145, 20);
            this.txt_rfc.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(12, 174);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(145, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(382, 85);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(234, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(382, 132);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(260, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.White;
            this.lbl_producto.Location = new System.Drawing.Point(12, 303);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(62, 13);
            this.lbl_producto.TabIndex = 11;
            this.lbl_producto.Text = "Producto:";
            // 
            // comboNombreCli
            // 
            this.comboNombreCli.FormattingEnabled = true;
            this.comboNombreCli.Location = new System.Drawing.Point(12, 85);
            this.comboNombreCli.Name = "comboNombreCli";
            this.comboNombreCli.Size = new System.Drawing.Size(171, 21);
            this.comboNombreCli.TabIndex = 12;
            this.comboNombreCli.SelectedIndexChanged += new System.EventHandler(this.comboNombreCli_SelectedIndexChanged);
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(12, 320);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(121, 21);
            this.comboProducto.TabIndex = 13;
            this.comboProducto.SelectedIndexChanged += new System.EventHandler(this.comboProducto_SelectedIndexChanged);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.White;
            this.lbl_cantidad.Location = new System.Drawing.Point(163, 303);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(61, 13);
            this.lbl_cantidad.TabIndex = 14;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // label_vUnitario
            // 
            this.label_vUnitario.AutoSize = true;
            this.label_vUnitario.BackColor = System.Drawing.Color.Transparent;
            this.label_vUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vUnitario.ForeColor = System.Drawing.Color.White;
            this.label_vUnitario.Location = new System.Drawing.Point(274, 303);
            this.label_vUnitario.Name = "label_vUnitario";
            this.label_vUnitario.Size = new System.Drawing.Size(86, 13);
            this.label_vUnitario.TabIndex = 16;
            this.label_vUnitario.Text = "Valor unitario:";
            // 
            // txt_valorU
            // 
            this.txt_valorU.Location = new System.Drawing.Point(277, 319);
            this.txt_valorU.Name = "txt_valorU";
            this.txt_valorU.Size = new System.Drawing.Size(100, 20);
            this.txt_valorU.TabIndex = 17;
            // 
            // dataMostrarInfo
            // 
            this.dataMostrarInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMostrarInfo.Location = new System.Drawing.Point(12, 365);
            this.dataMostrarInfo.Name = "dataMostrarInfo";
            this.dataMostrarInfo.Size = new System.Drawing.Size(706, 150);
            this.dataMostrarInfo.TabIndex = 19;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.White;
            this.lbl_subtotal.Location = new System.Drawing.Point(12, 528);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(58, 13);
            this.lbl_subtotal.TabIndex = 20;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(15, 544);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 21;
            // 
            // checkB_iva
            // 
            this.checkB_iva.AutoSize = true;
            this.checkB_iva.BackColor = System.Drawing.Color.Transparent;
            this.checkB_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkB_iva.ForeColor = System.Drawing.Color.White;
            this.checkB_iva.Location = new System.Drawing.Point(151, 528);
            this.checkB_iva.Name = "checkB_iva";
            this.checkB_iva.Size = new System.Drawing.Size(54, 17);
            this.checkB_iva.TabIndex = 22;
            this.checkB_iva.Text = "I.V.A";
            this.checkB_iva.UseVisualStyleBackColor = false;
            this.checkB_iva.CheckedChanged += new System.EventHandler(this.checkB_iva_CheckedChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(283, 528);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 13);
            this.lbl_total.TabIndex = 23;
            this.lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(286, 544);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 26;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::PuntodeVenta.Properties.Resources.guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(594, 563);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(48, 34);
            this.btn_guardar.TabIndex = 27;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_canselar
            // 
            this.btn_canselar.BackColor = System.Drawing.Color.Transparent;
            this.btn_canselar.BackgroundImage = global::PuntodeVenta.Properties.Resources.boton_cancelar;
            this.btn_canselar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_canselar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_canselar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_canselar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canselar.Location = new System.Drawing.Point(670, 563);
            this.btn_canselar.Name = "btn_canselar";
            this.btn_canselar.Size = new System.Drawing.Size(48, 34);
            this.btn_canselar.TabIndex = 28;
            this.btn_canselar.UseVisualStyleBackColor = false;
            // 
            // numericCont
            // 
            this.numericCont.Location = new System.Drawing.Point(166, 321);
            this.numericCont.Name = "numericCont";
            this.numericCont.Size = new System.Drawing.Size(39, 20);
            this.numericCont.TabIndex = 38;
            this.numericCont.ValueChanged += new System.EventHandler(this.numericCont_ValueChanged);
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(12, 218);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(200, 20);
            this.dateFecha.TabIndex = 42;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(9, 202);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(46, 13);
            this.lbl_fecha.TabIndex = 43;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_idP
            // 
            this.txt_idP.Location = new System.Drawing.Point(406, 185);
            this.txt_idP.Name = "txt_idP";
            this.txt_idP.Size = new System.Drawing.Size(28, 20);
            this.txt_idP.TabIndex = 44;
            this.txt_idP.Visible = false;
            // 
            // txt_conCant
            // 
            this.txt_conCant.Location = new System.Drawing.Point(457, 185);
            this.txt_conCant.Name = "txt_conCant";
            this.txt_conCant.Size = new System.Drawing.Size(26, 20);
            this.txt_conCant.TabIndex = 45;
            this.txt_conCant.Visible = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(516, 185);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 46;
            this.txt_Precio.Visible = false;
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(151, 544);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(100, 20);
            this.txt_iva.TabIndex = 47;
            this.txt_iva.Visible = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BackgroundImage = global::PuntodeVenta.Properties.Resources.hecho;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(406, 312);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(48, 34);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImage = global::PuntodeVenta.Properties.Resources.flechatras;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(47, 30);
            this.btn_regresar.TabIndex = 48;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panelcolor
            // 
            this.panelcolor.Controls.Add(this.txt_iva);
            this.panelcolor.Controls.Add(this.btn_regresar);
            this.panelcolor.Controls.Add(this.lbl_titulo);
            this.panelcolor.Controls.Add(this.lbl_email);
            this.panelcolor.Controls.Add(this.txt_subtotal);
            this.panelcolor.Controls.Add(this.checkB_iva);
            this.panelcolor.Controls.Add(this.lbl_subtotal);
            this.panelcolor.Controls.Add(this.lbl_direccion);
            this.panelcolor.Controls.Add(this.lbl_nombre);
            this.panelcolor.Controls.Add(this.lbl_total);
            this.panelcolor.Controls.Add(this.txt_total);
            this.panelcolor.Controls.Add(this.numericCont);
            this.panelcolor.Controls.Add(this.lbl_rfc);
            this.panelcolor.Controls.Add(this.btn_guardar);
            this.panelcolor.Controls.Add(this.btn_canselar);
            this.panelcolor.Controls.Add(this.lbl_fecha);
            this.panelcolor.Controls.Add(this.lbl_telefono);
            this.panelcolor.Controls.Add(this.label_vUnitario);
            this.panelcolor.Controls.Add(this.btn_agregar);
            this.panelcolor.Controls.Add(this.lbl_cantidad);
            this.panelcolor.Controls.Add(this.txt_valorU);
            this.panelcolor.Controls.Add(this.comboProducto);
            this.panelcolor.Controls.Add(this.lbl_producto);
            this.panelcolor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcolor.Location = new System.Drawing.Point(0, 0);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(730, 609);
            this.panelcolor.TabIndex = 49;
            this.panelcolor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcolor_Paint);
            // 
            // Frm_Cotización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuntodeVenta.Properties.Resources.fondo3delsel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 609);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_conCant);
            this.Controls.Add(this.txt_idP);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.dataMostrarInfo);
            this.Controls.Add(this.comboNombreCli);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.panelcolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cotización";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cotización";
            this.Load += new System.EventHandler(this.Frm_Cotización_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCont)).EndInit();
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
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.ComboBox comboNombreCli;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label_vUnitario;
        private System.Windows.Forms.TextBox txt_valorU;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataMostrarInfo;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkB_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_canselar;
        private System.Windows.Forms.NumericUpDown numericCont;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_idP;
        private System.Windows.Forms.TextBox txt_conCant;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Panel panelcolor;
    }
}