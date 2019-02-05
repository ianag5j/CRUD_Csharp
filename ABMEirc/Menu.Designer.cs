namespace ABMEirc
{
	partial class Menu
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.insert = new System.Windows.Forms.Button();
			this.select = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(0, 1);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(175, 75);
			this.insert.TabIndex = 0;
			this.insert.Text = "Agregar";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// select
			// 
			this.select.Location = new System.Drawing.Point(181, 1);
			this.select.Name = "select";
			this.select.Size = new System.Drawing.Size(175, 75);
			this.select.TabIndex = 1;
			this.select.Text = "Buscar";
			this.select.UseVisualStyleBackColor = true;
			this.select.Click += new System.EventHandler(this.select_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 79);
			this.Controls.Add(this.select);
			this.Controls.Add(this.insert);
			this.Name = "Menu";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Button select;
	}
}

