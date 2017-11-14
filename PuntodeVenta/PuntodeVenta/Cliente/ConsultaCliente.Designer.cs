namespace PuntodeVenta.Cliente
{
    partial class ConsultaCliente
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
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 70);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Location = new System.Drawing.Point(12, 125);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(31, 13);
            this.lbl_RFC.TabIndex = 1;
            this.lbl_RFC.Text = "RFC:";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(12, 177);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_Direccion.TabIndex = 2;
            this.lbl_Direccion.Text = "Direccion:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(12, 242);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_Telefono.TabIndex = 3;
            this.lbl_Telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 302);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(65, 63);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(50, 117);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(100, 20);
            this.txt_rfc.TabIndex = 6;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(74, 169);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 7;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(71, 234);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(57, 294);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 9;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(255, 282);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 10;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(255, 327);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(115, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(209, 12);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(121, 21);
            this.comboClient.TabIndex = 13;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 362);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_RFC);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "ConsultaCliente";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox comboClient;
    }
}