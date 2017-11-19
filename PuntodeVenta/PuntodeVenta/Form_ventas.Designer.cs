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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.lbl_presioU = new System.Windows.Forms.Label();
            this.txt_PU = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkB_efectivo = new System.Windows.Forms.CheckBox();
            this.checkB_cheque = new System.Windows.Forms.CheckBox();
            this.checkB_tarjeta = new System.Windows.Forms.CheckBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkB_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_canselar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(254, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(73, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Venta";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 98);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(12, 142);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(31, 13);
            this.lbl_rfc.TabIndex = 2;
            this.lbl_rfc.Text = "RFC:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 179);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(345, 98);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(345, 158);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(66, 91);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(49, 139);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(100, 20);
            this.txt_rfc.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(70, 172);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(390, 90);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(406, 151);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(15, 228);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(53, 13);
            this.lbl_producto.TabIndex = 11;
            this.lbl_producto.Text = "Producto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(229, 226);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(52, 13);
            this.lbl_cant.TabIndex = 13;
            this.lbl_cant.Text = "Cantidad:";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(288, 218);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(39, 20);
            this.txt_cant.TabIndex = 14;
            // 
            // lbl_presioU
            // 
            this.lbl_presioU.AutoSize = true;
            this.lbl_presioU.Location = new System.Drawing.Point(347, 226);
            this.lbl_presioU.Name = "lbl_presioU";
            this.lbl_presioU.Size = new System.Drawing.Size(79, 13);
            this.lbl_presioU.TabIndex = 15;
            this.lbl_presioU.Text = "Precio Unitario:";
            // 
            // txt_PU
            // 
            this.txt_PU.Location = new System.Drawing.Point(433, 218);
            this.txt_PU.Name = "txt_PU";
            this.txt_PU.Size = new System.Drawing.Size(33, 20);
            this.txt_PU.TabIndex = 16;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(498, 216);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // checkB_efectivo
            // 
            this.checkB_efectivo.AutoSize = true;
            this.checkB_efectivo.Location = new System.Drawing.Point(259, 468);
            this.checkB_efectivo.Name = "checkB_efectivo";
            this.checkB_efectivo.Size = new System.Drawing.Size(65, 17);
            this.checkB_efectivo.TabIndex = 19;
            this.checkB_efectivo.Text = "Efectivo";
            this.checkB_efectivo.UseVisualStyleBackColor = true;
            // 
            // checkB_cheque
            // 
            this.checkB_cheque.AutoSize = true;
            this.checkB_cheque.Location = new System.Drawing.Point(259, 508);
            this.checkB_cheque.Name = "checkB_cheque";
            this.checkB_cheque.Size = new System.Drawing.Size(63, 17);
            this.checkB_cheque.TabIndex = 20;
            this.checkB_cheque.Text = "Cheque";
            this.checkB_cheque.UseVisualStyleBackColor = true;
            // 
            // checkB_tarjeta
            // 
            this.checkB_tarjeta.AutoSize = true;
            this.checkB_tarjeta.Location = new System.Drawing.Point(259, 542);
            this.checkB_tarjeta.Name = "checkB_tarjeta";
            this.checkB_tarjeta.Size = new System.Drawing.Size(59, 17);
            this.checkB_tarjeta.TabIndex = 21;
            this.checkB_tarjeta.Text = "Tarjeta";
            this.checkB_tarjeta.UseVisualStyleBackColor = true;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(12, 468);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(53, 13);
            this.lbl_subtotal.TabIndex = 22;
            this.lbl_subtotal.Text = "SubTotal:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(72, 460);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 23;
            // 
            // checkB_iva
            // 
            this.checkB_iva.AutoSize = true;
            this.checkB_iva.Location = new System.Drawing.Point(16, 497);
            this.checkB_iva.Name = "checkB_iva";
            this.checkB_iva.Size = new System.Drawing.Size(49, 17);
            this.checkB_iva.TabIndex = 24;
            this.checkB_iva.Text = "I.V.A";
            this.checkB_iva.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(12, 531);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 25;
            this.lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(53, 523);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 26;
            // 
            // btn_venta
            // 
            this.btn_venta.Location = new System.Drawing.Point(390, 569);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(75, 23);
            this.btn_venta.TabIndex = 27;
            this.btn_venta.Text = "Venta";
            this.btn_venta.UseVisualStyleBackColor = true;
            // 
            // btn_canselar
            // 
            this.btn_canselar.Location = new System.Drawing.Point(489, 569);
            this.btn_canselar.Name = "btn_canselar";
            this.btn_canselar.Size = new System.Drawing.Size(75, 23);
            this.btn_canselar.TabIndex = 28;
            this.btn_canselar.Text = "Cancelar";
            this.btn_canselar.UseVisualStyleBackColor = true;
            // 
            // Form_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 604);
            this.Controls.Add(this.btn_canselar);
            this.Controls.Add(this.btn_venta);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.checkB_iva);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.checkB_tarjeta);
            this.Controls.Add(this.checkB_cheque);
            this.Controls.Add(this.checkB_efectivo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_PU);
            this.Controls.Add(this.lbl_presioU);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.lbl_cant);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_rfc);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ventas";
            this.Text = "Form_ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Label lbl_presioU;
        private System.Windows.Forms.TextBox txt_PU;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkB_efectivo;
        private System.Windows.Forms.CheckBox checkB_cheque;
        private System.Windows.Forms.CheckBox checkB_tarjeta;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkB_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_canselar;
    }
}