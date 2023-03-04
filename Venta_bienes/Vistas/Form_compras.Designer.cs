namespace Venta_bienes.Vistas
{
    partial class Form_compras
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
            this.TABLA_BIENES = new System.Windows.Forms.DataGridView();
            this.BTN_COMPRAR = new System.Windows.Forms.Button();
            this.TXT_CEDULA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL_NOMBRE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TABLE_COMPRAS = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_VOLVER = new System.Windows.Forms.Button();
            this.LABEL_BIEN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_BIENES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_COMPRAS)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLA_BIENES
            // 
            this.TABLA_BIENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_BIENES.Location = new System.Drawing.Point(443, 65);
            this.TABLA_BIENES.MultiSelect = false;
            this.TABLA_BIENES.Name = "TABLA_BIENES";
            this.TABLA_BIENES.ReadOnly = true;
            this.TABLA_BIENES.RowHeadersWidth = 51;
            this.TABLA_BIENES.RowTemplate.Height = 24;
            this.TABLA_BIENES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLA_BIENES.Size = new System.Drawing.Size(691, 301);
            this.TABLA_BIENES.TabIndex = 1;
            this.TABLA_BIENES.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_BIENES_CellContentDoubleClick);
            // 
            // BTN_COMPRAR
            // 
            this.BTN_COMPRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COMPRAR.Location = new System.Drawing.Point(78, 219);
            this.BTN_COMPRAR.Name = "BTN_COMPRAR";
            this.BTN_COMPRAR.Size = new System.Drawing.Size(241, 94);
            this.BTN_COMPRAR.TabIndex = 2;
            this.BTN_COMPRAR.Text = "COMPRAR";
            this.BTN_COMPRAR.UseVisualStyleBackColor = true;
            this.BTN_COMPRAR.Click += new System.EventHandler(this.BTN_COMPRAR_Click);
            // 
            // TXT_CEDULA
            // 
            this.TXT_CEDULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CEDULA.Location = new System.Drawing.Point(132, 26);
            this.TXT_CEDULA.Multiline = true;
            this.TXT_CEDULA.Name = "TXT_CEDULA";
            this.TXT_CEDULA.Size = new System.Drawing.Size(254, 40);
            this.TXT_CEDULA.TabIndex = 3;
            this.TXT_CEDULA.TextChanged += new System.EventHandler(this.TXT_CEDULA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE";
            // 
            // LABEL_NOMBRE
            // 
            this.LABEL_NOMBRE.AutoSize = true;
            this.LABEL_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NOMBRE.Location = new System.Drawing.Point(127, 102);
            this.LABEL_NOMBRE.Name = "LABEL_NOMBRE";
            this.LABEL_NOMBRE.Size = new System.Drawing.Size(19, 25);
            this.LABEL_NOMBRE.TabIndex = 5;
            this.LABEL_NOMBRE.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "CEDULA";
            // 
            // TABLE_COMPRAS
            // 
            this.TABLE_COMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLE_COMPRAS.Location = new System.Drawing.Point(173, 413);
            this.TABLE_COMPRAS.MultiSelect = false;
            this.TABLE_COMPRAS.Name = "TABLE_COMPRAS";
            this.TABLE_COMPRAS.ReadOnly = true;
            this.TABLE_COMPRAS.RowHeadersWidth = 51;
            this.TABLE_COMPRAS.RowTemplate.Height = 24;
            this.TABLE_COMPRAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TABLE_COMPRAS.Size = new System.Drawing.Size(691, 265);
            this.TABLE_COMPRAS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "COMPRAS REALIZADAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "BIENES";
            // 
            // BTN_VOLVER
            // 
            this.BTN_VOLVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VOLVER.Location = new System.Drawing.Point(20, 654);
            this.BTN_VOLVER.Name = "BTN_VOLVER";
            this.BTN_VOLVER.Size = new System.Drawing.Size(95, 35);
            this.BTN_VOLVER.TabIndex = 10;
            this.BTN_VOLVER.Text = "VOLVER";
            this.BTN_VOLVER.UseVisualStyleBackColor = true;
            this.BTN_VOLVER.Click += new System.EventHandler(this.BTN_VOLVER_Click);
            // 
            // LABEL_BIEN
            // 
            this.LABEL_BIEN.AutoSize = true;
            this.LABEL_BIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_BIEN.Location = new System.Drawing.Point(127, 162);
            this.LABEL_BIEN.Name = "LABEL_BIEN";
            this.LABEL_BIEN.Size = new System.Drawing.Size(19, 25);
            this.LABEL_BIEN.TabIndex = 12;
            this.LABEL_BIEN.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "BIEN";
            // 
            // Form_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 701);
            this.Controls.Add(this.LABEL_BIEN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_VOLVER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TABLE_COMPRAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LABEL_NOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_CEDULA);
            this.Controls.Add(this.BTN_COMPRAR);
            this.Controls.Add(this.TABLA_BIENES);
            this.Name = "Form_compras";
            this.Text = "Form_compras";
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_BIENES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_COMPRAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA_BIENES;
        private System.Windows.Forms.Button BTN_COMPRAR;
        private System.Windows.Forms.TextBox TXT_CEDULA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABEL_NOMBRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TABLE_COMPRAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_VOLVER;
        private System.Windows.Forms.Label LABEL_BIEN;
        private System.Windows.Forms.Label label6;
    }
}