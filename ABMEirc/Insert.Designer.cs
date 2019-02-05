namespace ABMEirc
{
	partial class Insert
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
            this.txtNombreIngresar = new System.Windows.Forms.TextBox();
            this.insertNombre = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.atrasInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreIngresar
            // 
            this.txtNombreIngresar.Location = new System.Drawing.Point(16, 29);
            this.txtNombreIngresar.Name = "txtNombreIngresar";
            this.txtNombreIngresar.Size = new System.Drawing.Size(134, 20);
            this.txtNombreIngresar.TabIndex = 0;
            // 
            // insertNombre
            // 
            this.insertNombre.AutoSize = true;
            this.insertNombre.Location = new System.Drawing.Point(13, 13);
            this.insertNombre.Name = "insertNombre";
            this.insertNombre.Size = new System.Drawing.Size(44, 13);
            this.insertNombre.TabIndex = 1;
            this.insertNombre.Text = "Nombre";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(156, 29);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 20);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // atrasInsert
            // 
            this.atrasInsert.Location = new System.Drawing.Point(16, 55);
            this.atrasInsert.Name = "atrasInsert";
            this.atrasInsert.Size = new System.Drawing.Size(240, 51);
            this.atrasInsert.TabIndex = 3;
            this.atrasInsert.Text = "Regresar al Menu";
            this.atrasInsert.UseVisualStyleBackColor = true;
            this.atrasInsert.Click += new System.EventHandler(this.atrasInsert_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 118);
            this.Controls.Add(this.atrasInsert);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.insertNombre);
            this.Controls.Add(this.txtNombreIngresar);
            this.Name = "Insert";
            this.Text = "Insert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Insert_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombreIngresar;
		private System.Windows.Forms.Label insertNombre;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button atrasInsert;
	}
}