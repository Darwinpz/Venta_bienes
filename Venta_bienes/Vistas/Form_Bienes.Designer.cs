namespace Venta_bienes.Vistas
{
    partial class Form_Bienes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_VOLVER = new System.Windows.Forms.Button();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.BTN_AGREGAR = new System.Windows.Forms.Button();
            this.TXT_DIRECCION = new System.Windows.Forms.TextBox();
            this.TXT_PRECIO = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TABLA_BIENES = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_BIENES)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "PRECIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "NOMBRE";
            // 
            // BTN_VOLVER
            // 
            this.BTN_VOLVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VOLVER.Location = new System.Drawing.Point(16, 28);
            this.BTN_VOLVER.Name = "BTN_VOLVER";
            this.BTN_VOLVER.Size = new System.Drawing.Size(108, 37);
            this.BTN_VOLVER.TabIndex = 21;
            this.BTN_VOLVER.Text = "VOLVER";
            this.BTN_VOLVER.UseVisualStyleBackColor = true;
            this.BTN_VOLVER.Click += new System.EventHandler(this.BTN_VOLVER_Click);
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(678, 438);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(149, 57);
            this.BTN_ELIMINAR.TabIndex = 20;
            this.BTN_ELIMINAR.Text = "ELIMINAR";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDITAR.Location = new System.Drawing.Point(497, 438);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(149, 57);
            this.BTN_EDITAR.TabIndex = 19;
            this.BTN_EDITAR.Text = "EDITAR";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // BTN_AGREGAR
            // 
            this.BTN_AGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AGREGAR.Location = new System.Drawing.Point(321, 438);
            this.BTN_AGREGAR.Name = "BTN_AGREGAR";
            this.BTN_AGREGAR.Size = new System.Drawing.Size(132, 57);
            this.BTN_AGREGAR.TabIndex = 18;
            this.BTN_AGREGAR.Text = "AGREGAR";
            this.BTN_AGREGAR.UseVisualStyleBackColor = true;
            this.BTN_AGREGAR.Click += new System.EventHandler(this.BTN_AGREGAR_Click);
            // 
            // TXT_DIRECCION
            // 
            this.TXT_DIRECCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DIRECCION.Location = new System.Drawing.Point(164, 295);
            this.TXT_DIRECCION.Multiline = true;
            this.TXT_DIRECCION.Name = "TXT_DIRECCION";
            this.TXT_DIRECCION.Size = new System.Drawing.Size(245, 51);
            this.TXT_DIRECCION.TabIndex = 16;
            // 
            // TXT_PRECIO
            // 
            this.TXT_PRECIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRECIO.Location = new System.Drawing.Point(164, 204);
            this.TXT_PRECIO.MaxLength = 100;
            this.TXT_PRECIO.Multiline = true;
            this.TXT_PRECIO.Name = "TXT_PRECIO";
            this.TXT_PRECIO.Size = new System.Drawing.Size(245, 51);
            this.TXT_PRECIO.TabIndex = 15;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOMBRE.Location = new System.Drawing.Point(164, 114);
            this.TXT_NOMBRE.MaxLength = 10;
            this.TXT_NOMBRE.Multiline = true;
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(245, 51);
            this.TXT_NOMBRE.TabIndex = 14;
            // 
            // TABLA_BIENES
            // 
            this.TABLA_BIENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_BIENES.Location = new System.Drawing.Point(437, 64);
            this.TABLA_BIENES.MultiSelect = false;
            this.TABLA_BIENES.Name = "TABLA_BIENES";
            this.TABLA_BIENES.ReadOnly = true;
            this.TABLA_BIENES.RowHeadersWidth = 51;
            this.TABLA_BIENES.RowTemplate.Height = 24;
            this.TABLA_BIENES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLA_BIENES.Size = new System.Drawing.Size(605, 348);
            this.TABLA_BIENES.TabIndex = 0;
            this.TABLA_BIENES.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_BIENES_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "DIRECCION";
            // 
            // Form_Bienes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_VOLVER);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.BTN_EDITAR);
            this.Controls.Add(this.BTN_AGREGAR);
            this.Controls.Add(this.TXT_DIRECCION);
            this.Controls.Add(this.TXT_PRECIO);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.TABLA_BIENES);
            this.Name = "Form_Bienes";
            this.Text = "Bienes";
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_BIENES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_VOLVER;
        private System.Windows.Forms.Button BTN_ELIMINAR;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.Button BTN_AGREGAR;
        private System.Windows.Forms.TextBox TXT_DIRECCION;
        private System.Windows.Forms.TextBox TXT_PRECIO;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.DataGridView TABLA_BIENES;
        private System.Windows.Forms.Label label3;
    }
}