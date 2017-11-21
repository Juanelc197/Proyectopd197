namespace PuntodeVenta.Producto
{
    partial class Menu_Producto
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
            this.btn_altaproducto = new System.Windows.Forms.Button();
            this.btn_consultaproducto = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.lbl_Consultar = new System.Windows.Forms.Label();
            this.lbl_agregar = new System.Windows.Forms.Label();
            this.panelcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_altaproducto
            // 
            this.btn_altaproducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_altaproducto.BackgroundImage = global::PuntodeVenta.Properties.Resources.nuevo_producto;
            this.btn_altaproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_altaproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_altaproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_altaproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altaproducto.Location = new System.Drawing.Point(54, 141);
            this.btn_altaproducto.Name = "btn_altaproducto";
            this.btn_altaproducto.Size = new System.Drawing.Size(75, 63);
            this.btn_altaproducto.TabIndex = 0;
            this.btn_altaproducto.UseVisualStyleBackColor = false;
            this.btn_altaproducto.Click += new System.EventHandler(this.btn_altaproducto_Click);
            // 
            // btn_consultaproducto
            // 
            this.btn_consultaproducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultaproducto.BackgroundImage = global::PuntodeVenta.Properties.Resources.consulta;
            this.btn_consultaproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_consultaproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_consultaproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_consultaproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultaproducto.Location = new System.Drawing.Point(302, 141);
            this.btn_consultaproducto.Name = "btn_consultaproducto";
            this.btn_consultaproducto.Size = new System.Drawing.Size(75, 63);
            this.btn_consultaproducto.TabIndex = 1;
            this.btn_consultaproducto.UseVisualStyleBackColor = false;
            this.btn_consultaproducto.Click += new System.EventHandler(this.btn_consultaproducto_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BackgroundImage = global::PuntodeVenta.Properties.Resources.home;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(12, 12);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(31, 30);
            this.btn_inicio.TabIndex = 2;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panelcolor
            // 
            this.panelcolor.Controls.Add(this.lbl_Consultar);
            this.panelcolor.Controls.Add(this.lbl_agregar);
            this.panelcolor.Controls.Add(this.btn_inicio);
            this.panelcolor.Controls.Add(this.btn_consultaproducto);
            this.panelcolor.Controls.Add(this.btn_altaproducto);
            this.panelcolor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcolor.Location = new System.Drawing.Point(0, 0);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(427, 321);
            this.panelcolor.TabIndex = 3;
            // 
            // lbl_Consultar
            // 
            this.lbl_Consultar.AutoSize = true;
            this.lbl_Consultar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Consultar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consultar.ForeColor = System.Drawing.Color.White;
            this.lbl_Consultar.Location = new System.Drawing.Point(306, 125);
            this.lbl_Consultar.Name = "lbl_Consultar";
            this.lbl_Consultar.Size = new System.Drawing.Size(67, 13);
            this.lbl_Consultar.TabIndex = 5;
            this.lbl_Consultar.Text = "Consultar ";
            // 
            // lbl_agregar
            // 
            this.lbl_agregar.AutoSize = true;
            this.lbl_agregar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_agregar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agregar.ForeColor = System.Drawing.Color.White;
            this.lbl_agregar.Location = new System.Drawing.Point(65, 125);
            this.lbl_agregar.Name = "lbl_agregar";
            this.lbl_agregar.Size = new System.Drawing.Size(55, 13);
            this.lbl_agregar.TabIndex = 4;
            this.lbl_agregar.Text = "Agregar ";
            // 
            // Menu_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuntodeVenta.Properties.Resources.fondo4delsel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(427, 321);
            this.Controls.Add(this.panelcolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Producto_Load);
            this.panelcolor.ResumeLayout(false);
            this.panelcolor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_altaproducto;
        private System.Windows.Forms.Button btn_consultaproducto;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.Label lbl_agregar;
        private System.Windows.Forms.Label lbl_Consultar;
    }
}