namespace Venta_bienes.Vistas
{
    partial class Form_Principal
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
            this.BTN_CLIENTES = new System.Windows.Forms.Button();
            this.BTN_BIENES = new System.Windows.Forms.Button();
            this.BTN_COMPRAR = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CLIENTES
            // 
            this.BTN_CLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLIENTES.Location = new System.Drawing.Point(52, 37);
            this.BTN_CLIENTES.Name = "BTN_CLIENTES";
            this.BTN_CLIENTES.Size = new System.Drawing.Size(227, 184);
            this.BTN_CLIENTES.TabIndex = 0;
            this.BTN_CLIENTES.Text = "CLIENTES";
            this.BTN_CLIENTES.UseVisualStyleBackColor = true;
            this.BTN_CLIENTES.Click += new System.EventHandler(this.BTN_CLIENTES_Click);
            // 
            // BTN_BIENES
            // 
            this.BTN_BIENES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BIENES.Location = new System.Drawing.Point(502, 37);
            this.BTN_BIENES.Name = "BTN_BIENES";
            this.BTN_BIENES.Size = new System.Drawing.Size(227, 184);
            this.BTN_BIENES.TabIndex = 1;
            this.BTN_BIENES.Text = "BIENES";
            this.BTN_BIENES.UseVisualStyleBackColor = true;
            this.BTN_BIENES.Click += new System.EventHandler(this.BTN_BIENES_Click);
            // 
            // BTN_COMPRAR
            // 
            this.BTN_COMPRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COMPRAR.Location = new System.Drawing.Point(280, 240);
            this.BTN_COMPRAR.Name = "BTN_COMPRAR";
            this.BTN_COMPRAR.Size = new System.Drawing.Size(227, 184);
            this.BTN_COMPRAR.TabIndex = 2;
            this.BTN_COMPRAR.Text = "COMPRAR";
            this.BTN_COMPRAR.UseVisualStyleBackColor = true;
            this.BTN_COMPRAR.Click += new System.EventHandler(this.BTN_COMPRAR_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(12, 388);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(95, 36);
            this.BTN_SALIR.TabIndex = 3;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_COMPRAR);
            this.Controls.Add(this.BTN_BIENES);
            this.Controls.Add(this.BTN_CLIENTES);
            this.Name = "Form_Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CLIENTES;
        private System.Windows.Forms.Button BTN_BIENES;
        private System.Windows.Forms.Button BTN_COMPRAR;
        private System.Windows.Forms.Button BTN_SALIR;
    }
}