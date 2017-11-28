namespace PuntodeVenta
{
    partial class DetalleV
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.monthAntes = new System.Windows.Forms.MonthCalendar();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dataMostrarDatos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_Despues = new System.Windows.Forms.Label();
            this.lbl_Antes = new System.Windows.Forms.Label();
            this.monthDespues = new System.Windows.Forms.MonthCalendar();
            this.lbl_FormadePago = new System.Windows.Forms.Label();
            this.comboFormaPago = new System.Windows.Forms.ComboBox();
            this.panelcolor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarDatos)).BeginInit();
            this.SuspendLayout();
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
            this.btn_regresar.TabIndex = 0;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // monthAntes
            // 
            this.monthAntes.Location = new System.Drawing.Point(18, 51);
            this.monthAntes.Name = "monthAntes";
            this.monthAntes.TabIndex = 1;
            this.monthAntes.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthAntes_DateChanged);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_titulo.Location = new System.Drawing.Point(321, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(154, 25);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Detalle Venta";
            // 
            // panelcolor
            // 
            this.panelcolor.Controls.Add(this.comboFormaPago);
            this.panelcolor.Controls.Add(this.lbl_FormadePago);
            this.panelcolor.Controls.Add(this.comboCliente);
            this.panelcolor.Controls.Add(this.lbl_nombre);
            this.panelcolor.Controls.Add(this.dataMostrarDatos);
            this.panelcolor.Controls.Add(this.btn_buscar);
            this.panelcolor.Controls.Add(this.lbl_Despues);
            this.panelcolor.Controls.Add(this.lbl_Antes);
            this.panelcolor.Controls.Add(this.monthDespues);
            this.panelcolor.Controls.Add(this.monthAntes);
            this.panelcolor.Controls.Add(this.lbl_titulo);
            this.panelcolor.Controls.Add(this.btn_regresar);
            this.panelcolor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcolor.Location = new System.Drawing.Point(0, 0);
            this.panelcolor.Name = "panelcolor";
            this.panelcolor.Size = new System.Drawing.Size(768, 468);
            this.panelcolor.TabIndex = 3;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(279, 91);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(147, 21);
            this.comboCliente.TabIndex = 9;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(278, 74);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 13);
            this.lbl_nombre.TabIndex = 8;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // dataMostrarDatos
            // 
            this.dataMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMostrarDatos.Location = new System.Drawing.Point(12, 277);
            this.dataMostrarDatos.Name = "dataMostrarDatos";
            this.dataMostrarDatos.Size = new System.Drawing.Size(744, 150);
            this.dataMostrarDatos.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(12, 433);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Ver";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_Despues
            // 
            this.lbl_Despues.AutoSize = true;
            this.lbl_Despues.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Despues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Despues.ForeColor = System.Drawing.Color.White;
            this.lbl_Despues.Location = new System.Drawing.Point(609, 249);
            this.lbl_Despues.Name = "lbl_Despues";
            this.lbl_Despues.Size = new System.Drawing.Size(68, 13);
            this.lbl_Despues.TabIndex = 5;
            this.lbl_Despues.Text = "Despues...";
            // 
            // lbl_Antes
            // 
            this.lbl_Antes.AutoSize = true;
            this.lbl_Antes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Antes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Antes.ForeColor = System.Drawing.Color.White;
            this.lbl_Antes.Location = new System.Drawing.Point(96, 249);
            this.lbl_Antes.Name = "lbl_Antes";
            this.lbl_Antes.Size = new System.Drawing.Size(51, 13);
            this.lbl_Antes.TabIndex = 4;
            this.lbl_Antes.Text = "Antes...";
            // 
            // monthDespues
            // 
            this.monthDespues.Location = new System.Drawing.Point(502, 51);
            this.monthDespues.Name = "monthDespues";
            this.monthDespues.TabIndex = 3;
            // 
            // lbl_FormadePago
            // 
            this.lbl_FormadePago.AutoSize = true;
            this.lbl_FormadePago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FormadePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormadePago.ForeColor = System.Drawing.Color.White;
            this.lbl_FormadePago.Location = new System.Drawing.Point(278, 149);
            this.lbl_FormadePago.Name = "lbl_FormadePago";
            this.lbl_FormadePago.Size = new System.Drawing.Size(96, 13);
            this.lbl_FormadePago.TabIndex = 10;
            this.lbl_FormadePago.Text = "Forma de Pago:";
            // 
            // comboFormaPago
            // 
            this.comboFormaPago.FormattingEnabled = true;
            this.comboFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Cheque"});
            this.comboFormaPago.Location = new System.Drawing.Point(281, 166);
            this.comboFormaPago.Name = "comboFormaPago";
            this.comboFormaPago.Size = new System.Drawing.Size(121, 21);
            this.comboFormaPago.TabIndex = 11;
            this.comboFormaPago.SelectedIndexChanged += new System.EventHandler(this.comboFormaPago_SelectedIndexChanged);
            // 
            // DetalleV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuntodeVenta.Properties.Resources.fondo4delsel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 468);
            this.Controls.Add(this.panelcolor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Venta";
            this.Load += new System.EventHandler(this.DetalleV_Load);
            this.panelcolor.ResumeLayout(false);
            this.panelcolor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.MonthCalendar monthAntes;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.MonthCalendar monthDespues;
        private System.Windows.Forms.Label lbl_Despues;
        private System.Windows.Forms.Label lbl_Antes;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dataMostrarDatos;
        private System.Windows.Forms.ComboBox comboFormaPago;
        private System.Windows.Forms.Label lbl_FormadePago;
    }
}