namespace PuntodeVenta
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Producto = new System.Windows.Forms.Button();
            this.btn_Cotizacion = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_ConsultaVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Producto
            // 
            this.btn_Producto.Location = new System.Drawing.Point(65, 108);
            this.btn_Producto.Name = "btn_Producto";
            this.btn_Producto.Size = new System.Drawing.Size(75, 23);
            this.btn_Producto.TabIndex = 0;
            this.btn_Producto.Text = "Producto";
            this.btn_Producto.UseVisualStyleBackColor = true;
            // 
            // btn_Cotizacion
            // 
            this.btn_Cotizacion.Location = new System.Drawing.Point(552, 107);
            this.btn_Cotizacion.Name = "btn_Cotizacion";
            this.btn_Cotizacion.Size = new System.Drawing.Size(75, 23);
            this.btn_Cotizacion.TabIndex = 1;
            this.btn_Cotizacion.Text = "Cotizacion";
            this.btn_Cotizacion.UseVisualStyleBackColor = true;
            // 
            // btn_Venta
            // 
            this.btn_Venta.Location = new System.Drawing.Point(56, 304);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(75, 23);
            this.btn_Venta.TabIndex = 2;
            this.btn_Venta.Text = "Venta";
            this.btn_Venta.UseVisualStyleBackColor = true;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Location = new System.Drawing.Point(611, 317);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_Cliente.TabIndex = 3;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultaVentas
            // 
            this.btn_ConsultaVentas.Location = new System.Drawing.Point(487, 491);
            this.btn_ConsultaVentas.Name = "btn_ConsultaVentas";
            this.btn_ConsultaVentas.Size = new System.Drawing.Size(140, 23);
            this.btn_ConsultaVentas.TabIndex = 4;
            this.btn_ConsultaVentas.Text = "Consulta Ventas";
            this.btn_ConsultaVentas.UseVisualStyleBackColor = true;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 546);
            this.Controls.Add(this.btn_ConsultaVentas);
            this.Controls.Add(this.btn_Cliente);
            this.Controls.Add(this.btn_Venta);
            this.Controls.Add(this.btn_Cotizacion);
            this.Controls.Add(this.btn_Producto);
            this.Name = "Frm_Menu";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Producto;
        private System.Windows.Forms.Button btn_Cotizacion;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_ConsultaVentas;
    }
}

