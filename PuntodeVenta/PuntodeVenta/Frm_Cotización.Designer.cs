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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label_vUnitario = new System.Windows.Forms.Label();
            this.txt_valorU = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.checkB_iva = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_folio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(198, 21);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(130, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cotización ";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(13, 70);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(12, 103);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(31, 13);
            this.lbl_rfc.TabIndex = 2;
            this.lbl_rfc.Text = "RFC:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(13, 140);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(399, 116);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(402, 149);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(50, 95);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(145, 20);
            this.txt_rfc.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(72, 132);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(123, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(444, 108);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(234, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(464, 142);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(260, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(13, 219);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(53, 13);
            this.lbl_producto.TabIndex = 11;
            this.lbl_producto.Text = "Producto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(73, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(290, 209);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(38, 20);
            this.txt_cantidad.TabIndex = 15;
            // 
            // label_vUnitario
            // 
            this.label_vUnitario.AutoSize = true;
            this.label_vUnitario.Location = new System.Drawing.Point(360, 216);
            this.label_vUnitario.Name = "label_vUnitario";
            this.label_vUnitario.Size = new System.Drawing.Size(71, 13);
            this.label_vUnitario.TabIndex = 16;
            this.label_vUnitario.Text = "Valor unitario:";
            // 
            // txt_valorU
            // 
            this.txt_valorU.Location = new System.Drawing.Point(438, 209);
            this.txt_valorU.Name = "txt_valorU";
            this.txt_valorU.Size = new System.Drawing.Size(100, 20);
            this.txt_valorU.TabIndex = 17;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(581, 206);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(399, 439);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(49, 13);
            this.lbl_subtotal.TabIndex = 20;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(455, 431);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 21;
            // 
            // checkB_iva
            // 
            this.checkB_iva.AutoSize = true;
            this.checkB_iva.Location = new System.Drawing.Point(475, 468);
            this.checkB_iva.Name = "checkB_iva";
            this.checkB_iva.Size = new System.Drawing.Size(64, 17);
            this.checkB_iva.TabIndex = 22;
            this.checkB_iva.Text = "Iva 16%";
            this.checkB_iva.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(475, 505);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(27, 13);
            this.lbl_total.TabIndex = 23;
            this.lbl_total.Text = "total";
            // 
            // lbl_folio
            // 
            this.lbl_folio.AutoSize = true;
            this.lbl_folio.Location = new System.Drawing.Point(401, 69);
            this.lbl_folio.Name = "lbl_folio";
            this.lbl_folio.Size = new System.Drawing.Size(42, 13);
            this.lbl_folio.TabIndex = 24;
            this.lbl_folio.Text = "Folio #:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // Frm_Cotización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_folio);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.checkB_iva);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_valorU);
            this.Controls.Add(this.label_vUnitario);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_rfc);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cotización";
            this.Text = "Frm_Cotización";
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
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label_vUnitario;
        private System.Windows.Forms.TextBox txt_valorU;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.CheckBox checkB_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_folio;
        private System.Windows.Forms.TextBox textBox1;
    }
}