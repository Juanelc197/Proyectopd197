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
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.dataverproductos = new System.Windows.Forms.DataGridView();
            this.btn_verdatos = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panelcolor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataverproductos)).BeginInit();
            this.panelcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.ForeColor = System.Drawing.Color.White;
            this.lbl_Producto.Location = new System.Drawing.Point(12, 125);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(62, 13);
            this.lbl_Producto.TabIndex = 0;
            this.lbl_Producto.Text = "Producto:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(12, 174);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(78, 13);
            this.lbl_Descripcion.TabIndex = 1;
            this.lbl_Descripcion.Text = "Descripción:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.ForeColor = System.Drawing.Color.White;
            this.lbl_Cantidad.Location = new System.Drawing.Point(12, 223);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(61, 13);
            this.lbl_Cantidad.TabIndex = 2;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.Color.White;
            this.lbl_Precio.Location = new System.Drawing.Point(12, 272);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(47, 13);
            this.lbl_Precio.TabIndex = 3;
            this.lbl_Precio.Text = "Precio:";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = global::PuntodeVenta.Properties.Resources.actualizar_pagina_opcion;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(314, 315);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(31, 30);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BackgroundImage = global::PuntodeVenta.Properties.Resources.eliminar_foto;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(367, 315);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(31, 30);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(12, 141);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(284, 20);
            this.txt_producto.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(12, 190);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(369, 20);
            this.txt_descripcion.TabIndex = 7;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(12, 239);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(77, 20);
            this.txt_cantidad.TabIndex = 8;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(12, 288);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(66, 20);
            this.txt_precio.TabIndex = 9;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = global::PuntodeVenta.Properties.Resources.lupa_de_busqueda;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(146, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(23, 21);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // combProductos
            // 
            this.combProductos.FormattingEnabled = true;
            this.combProductos.Location = new System.Drawing.Point(175, 21);
            this.combProductos.Name = "combProductos";
            this.combProductos.Size = new System.Drawing.Size(170, 21);
            this.combProductos.TabIndex = 11;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BackgroundImage = global::PuntodeVenta.Properties.Resources.home;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(12, 12);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(31, 30);
            this.btn_inicio.TabIndex = 12;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImage = global::PuntodeVenta.Properties.Resources.flechatras;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(12, 507);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(47, 30);
            this.btn_regresar.TabIndex = 13;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_cont
            // 
            this.lbl_cont.AutoSize = true;
            this.lbl_cont.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cont.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.ForeColor = System.Drawing.Color.White;
            this.lbl_cont.Location = new System.Drawing.Point(376, 17);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(22, 24);
            this.lbl_cont.TabIndex = 14;
            this.lbl_cont.Text = "#";
            // 
            // dataverproductos
            // 
            this.dataverproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataverproductos.Location = new System.Drawing.Point(12, 351);
            this.dataverproductos.Name = "dataverproductos";
            this.dataverproductos.Size = new System.Drawing.Size(386, 150);
            this.dataverproductos.TabIndex = 15;
            // 
            // btn_verdatos
            // 
            this.btn_verdatos.BackColor = System.Drawing.Color.Transparent;
            this.btn_verdatos.BackgroundImage = global::PuntodeVenta.Properties.Resources.ojo_abierto;
            this.btn_verdatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_verdatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_verdatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_verdatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verdatos.Location = new System.Drawing.Point(367, 507);
            this.btn_verdatos.Name = "btn_verdatos";
            this.btn_verdatos.Size = new System.Drawing.Size(31, 30);
            this.btn_verdatos.TabIndex = 16;
            this.btn_verdatos.UseVisualStyleBackColor = false;
            this.btn_verdatos.Click += new System.EventHandler(this.btn_verdatos_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_titulo.Location = new System.Drawing.Point(157, 65);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(105, 25);
            this.lbl_titulo.TabIndex = 21;
            this.lbl_titulo.Text = "Consulta";
            // 
            // panelcolor
            // 
            this.panelcolor.Controls.Add(this.btn_verdatos);
            this.panelcolor.Controls.Add(this.lbl_titulo);
            this.panelcolor.Controls.Add(this.btn_buscar);
            this.panelcolor.Controls.Add(this.btn_regresar);
            this.panelcolor.Controls.Add(this.lbl_cont);
            this.panelcolor.Controls.Add(this.btn_inicio);
            this.panelcolor.Controls.Add(this.lbl_Producto);
            this.panelcolor.Controls.Add(this.lbl_Descripcion);
            this.panelcolor.Controls.Add(this.lbl_Cantidad);
            this.panelcolor.Controls.Add(this.lbl_Precio);
            this.panelcolor.Controls.Add(this.btn_Eliminar);
            this.panelcolor.Controls.Add(this.btn_editar);
            this.panelcolor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcolor.Location = new System.Drawing.Point(0, 0);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(410, 544);
            this.panelcolor.TabIndex = 22;
            // 
            // ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuntodeVenta.Properties.Resources.fondo1delsel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 544);
            this.Controls.Add(this.dataverproductos);
            this.Controls.Add(this.combProductos);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.panelcolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaProductos";
            this.Text = "Consulta Productos";
            this.Load += new System.EventHandler(this.ConsultaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataverproductos)).EndInit();
            this.panelcolor.ResumeLayout(false);
            this.panelcolor.PerformLayout();
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
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_cont;
        private System.Windows.Forms.DataGridView dataverproductos;
        private System.Windows.Forms.Button btn_verdatos;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panelcolor;
    }
}