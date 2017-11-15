namespace PuntodeVenta.Cliente
{
    partial class AgregarCliente
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 143);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(12, 221);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(31, 13);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "RFC:";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(11, 294);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_Direccion.TabIndex = 2;
            this.lbl_Direccion.Text = "Direccion:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(12, 363);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(12, 432);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(66, 135);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(50, 213);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(100, 20);
            this.txt_rfc.TabIndex = 6;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(73, 286);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(71, 355);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(57, 424);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 9;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(343, 406);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BackgroundImage = global::PuntodeVenta.Properties.Resources.home;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(12, 12);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(31, 30);
            this.btn_inicio.TabIndex = 11;
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImage = global::PuntodeVenta.Properties.Resources.flechatras;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(427, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(47, 30);
            this.btn_regresar.TabIndex = 12;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 521);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCliente";
            this.Text = "Agregar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_regresar;
    }
}