namespace PuntodeVenta.Producto
{
    partial class ConsultaProductos
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
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.combProductos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(12, 99);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(53, 13);
            this.lbl_Producto.TabIndex = 0;
            this.lbl_Producto.Text = "Producto:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(12, 164);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Descripción:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(12, 262);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(52, 13);
            this.lbl_Cantidad.TabIndex = 2;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(12, 341);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_Precio.TabIndex = 3;
            this.lbl_Precio.Text = "Precio:";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(316, 330);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(316, 385);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(72, 91);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_producto.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(85, 156);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 7;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(71, 254);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 8;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(59, 333);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 9;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(189, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // combProductos
            // 
            this.combProductos.FormattingEnabled = true;
            this.combProductos.Location = new System.Drawing.Point(270, 12);
            this.combProductos.Name = "combProductos";
            this.combProductos.Size = new System.Drawing.Size(121, 21);
            this.combProductos.TabIndex = 11;
            // 
            // ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 420);
            this.Controls.Add(this.combProductos);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Producto);
            this.Name = "ConsultaProductos";
            this.Text = "Consulta Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox combProductos;
    }
}