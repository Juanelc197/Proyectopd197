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
            this.SuspendLayout();
            // 
            // btn_altaproducto
            // 
            this.btn_altaproducto.Location = new System.Drawing.Point(50, 122);
            this.btn_altaproducto.Name = "btn_altaproducto";
            this.btn_altaproducto.Size = new System.Drawing.Size(113, 23);
            this.btn_altaproducto.TabIndex = 0;
            this.btn_altaproducto.Text = "Nuevo Producto";
            this.btn_altaproducto.UseVisualStyleBackColor = true;
            // 
            // btn_consultaproducto
            // 
            this.btn_consultaproducto.Location = new System.Drawing.Point(346, 122);
            this.btn_consultaproducto.Name = "btn_consultaproducto";
            this.btn_consultaproducto.Size = new System.Drawing.Size(75, 23);
            this.btn_consultaproducto.TabIndex = 1;
            this.btn_consultaproducto.Text = "Consulta";
            this.btn_consultaproducto.UseVisualStyleBackColor = true;
            // 
            // Menu_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 278);
            this.Controls.Add(this.btn_consultaproducto);
            this.Controls.Add(this.btn_altaproducto);
            this.Name = "Menu_Producto";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_altaproducto;
        private System.Windows.Forms.Button btn_consultaproducto;
    }
}