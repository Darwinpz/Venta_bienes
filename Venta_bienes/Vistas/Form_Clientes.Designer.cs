namespace Venta_bienes.Vistas
{
    partial class Form_Clientes
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
            this.TABLA_CLIENTES = new System.Windows.Forms.DataGridView();
            this.TXT_CEDULA = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_EDAD = new System.Windows.Forms.TextBox();
            this.TXT_CLAVE = new System.Windows.Forms.TextBox();
            this.BTN_AGREGAR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            this.BTN_VOLVER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLA_CLIENTES
            // 
            this.TABLA_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_CLIENTES.Location = new System.Drawing.Point(411, 48);
            this.TABLA_CLIENTES.MultiSelect = false;
            this.TABLA_CLIENTES.Name = "TABLA_CLIENTES";
            this.TABLA_CLIENTES.ReadOnly = true;
            this.TABLA_CLIENTES.RowHeadersWidth = 51;
            this.TABLA_CLIENTES.RowTemplate.Height = 24;
            this.TABLA_CLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLA_CLIENTES.Size = new System.Drawing.Size(605, 348);
            this.TABLA_CLIENTES.TabIndex = 0;
            this.TABLA_CLIENTES.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_CLIENTES_CellContentDoubleClick);
            // 
            // TXT_CEDULA
            // 
            this.TXT_CEDULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CEDULA.Location = new System.Drawing.Point(133, 65);
            this.TXT_CEDULA.MaxLength = 10;
            this.TXT_CEDULA.Multiline = true;
            this.TXT_CEDULA.Name = "TXT_CEDULA";
            this.TXT_CEDULA.Size = new System.Drawing.Size(245, 51);
            this.TXT_CEDULA.TabIndex = 1;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOMBRE.Location = new System.Drawing.Point(133, 155);
            this.TXT_NOMBRE.MaxLength = 100;
            this.TXT_NOMBRE.Multiline = true;
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(245, 51);
            this.TXT_NOMBRE.TabIndex = 2;
            // 
            // TXT_EDAD
            // 
            this.TXT_EDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_EDAD.Location = new System.Drawing.Point(133, 246);
            this.TXT_EDAD.Multiline = true;
            this.TXT_EDAD.Name = "TXT_EDAD";
            this.TXT_EDAD.Size = new System.Drawing.Size(245, 51);
            this.TXT_EDAD.TabIndex = 3;
            // 
            // TXT_CLAVE
            // 
            this.TXT_CLAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CLAVE.Location = new System.Drawing.Point(133, 331);
            this.TXT_CLAVE.MaxLength = 15;
            this.TXT_CLAVE.Multiline = true;
            this.TXT_CLAVE.Name = "TXT_CLAVE";
            this.TXT_CLAVE.Size = new System.Drawing.Size(245, 51);
            this.TXT_CLAVE.TabIndex = 4;
            // 
            // BTN_AGREGAR
            // 
            this.BTN_AGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AGREGAR.Location = new System.Drawing.Point(317, 422);
            this.BTN_AGREGAR.Name = "BTN_AGREGAR";
            this.BTN_AGREGAR.Size = new System.Drawing.Size(132, 57);
            this.BTN_AGREGAR.TabIndex = 5;
            this.BTN_AGREGAR.Text = "AGREGAR";
            this.BTN_AGREGAR.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR.Click += new System.EventHandler(this.BTN_AGREGAR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDITAR.Location = new System.Drawing.Point(493, 422);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(149, 57);
            this.BTN_EDITAR.TabIndex = 6;
            this.BTN_EDITAR.Text = "EDITAR";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(674, 422);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(149, 57);
            this.BTN_ELIMINAR.TabIndex = 7;
            this.BTN_ELIMINAR.Text = "ELIMINAR";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // BTN_VOLVER
            // 
            this.BTN_VOLVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VOLVER.Location = new System.Drawing.Point(12, 12);
            this.BTN_VOLVER.Name = "BTN_VOLVER";
            this.BTN_VOLVER.Size = new System.Drawing.Size(108, 37);
            this.BTN_VOLVER.TabIndex = 8;
            this.BTN_VOLVER.Text = "VOLVER";
            this.BTN_VOLVER.UseVisualStyleBackColor = true;
            this.BTN_VOLVER.Click += new System.EventHandler(this.BTN_VOLVER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "CEDULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "EDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "CLAVE";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_VOLVER);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_EDITAR);
            this.Controls.Add(this.BTN_AGREGAR);
            this.Controls.Add(this.TXT_CLAVE);
            this.Controls.Add(this.TXT_EDAD);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.TXT_CEDULA);
            this.Controls.Add(this.TABLA_CLIENTES);
            this.Name = "Clientes";
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_CLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA_CLIENTES;
        private System.Windows.Forms.TextBox TXT_CEDULA;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_EDAD;
        private System.Windows.Forms.TextBox TXT_CLAVE;
        private System.Windows.Forms.Button BTN_AGREGAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_VOLVER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}