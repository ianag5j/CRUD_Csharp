namespace ABMEirc
{
	partial class Buscar
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
            this.DGBuscar = new System.Windows.Forms.DataGridView();
            this.txtBuscadorNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.txtBuscardorId = new System.Windows.Forms.TextBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnBorrarSeleccionado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // DGBuscar
            // 
            this.DGBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBuscar.Location = new System.Drawing.Point(167, 12);
            this.DGBuscar.Name = "DGBuscar";
            this.DGBuscar.Size = new System.Drawing.Size(330, 425);
            this.DGBuscar.TabIndex = 0;
            this.DGBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBuscar_CellClick);
            this.DGBuscar.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.DGBuscar_CellContentClick);
            // 
            // txtBuscadorNombre
            // 
            this.txtBuscadorNombre.Location = new System.Drawing.Point(12, 28);
            this.txtBuscadorNombre.Name = "txtBuscadorNombre";
            this.txtBuscadorNombre.Size = new System.Drawing.Size(149, 20);
            this.txtBuscadorNombre.TabIndex = 1;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(12, 54);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(149, 23);
            this.btnBuscarNombre.TabIndex = 2;
            this.btnBuscarNombre.Text = "Buscar por Nombre";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 414);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(149, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(12, 122);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(149, 23);
            this.btnBuscarId.TabIndex = 6;
            this.btnBuscarId.Text = "Buscar por Id";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // txtBuscardorId
            // 
            this.txtBuscardorId.Location = new System.Drawing.Point(12, 96);
            this.txtBuscardorId.Name = "txtBuscardorId";
            this.txtBuscardorId.Size = new System.Drawing.Size(149, 20);
            this.txtBuscardorId.TabIndex = 5;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(12, 151);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(149, 23);
            this.btnVerTodos.TabIndex = 7;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnBorrarSeleccionado
            // 
            this.btnBorrarSeleccionado.Location = new System.Drawing.Point(12, 180);
            this.btnBorrarSeleccionado.Name = "btnBorrarSeleccionado";
            this.btnBorrarSeleccionado.Size = new System.Drawing.Size(149, 23);
            this.btnBorrarSeleccionado.TabIndex = 8;
            this.btnBorrarSeleccionado.Text = "Borrar Seleccionados";
            this.btnBorrarSeleccionado.UseVisualStyleBackColor = true;
            this.btnBorrarSeleccionado.Click += new System.EventHandler(this.btnBorrarSeleccionado_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-8, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "______________________________________________________________";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(41, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Actualizar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre";
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(12, 240);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(149, 20);
            this.txtActualizar.TabIndex = 16;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 266);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(149, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBorrarSeleccionado);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.txtBuscardorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txtBuscadorNombre);
            this.Controls.Add(this.DGBuscar);
            this.Controls.Add(this.label3);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buscar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Buscar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DGBuscar;
		private System.Windows.Forms.TextBox txtBuscadorNombre;
		private System.Windows.Forms.Button btnBuscarNombre;
		private System.Windows.Forms.Button btnAtras;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBuscarId;
		private System.Windows.Forms.TextBox txtBuscardorId;
		private System.Windows.Forms.Button btnVerTodos;
		private System.Windows.Forms.Button btnBorrarSeleccionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.Button btnActualizar;
    }
}