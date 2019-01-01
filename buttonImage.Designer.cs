namespace imageButton
{
	partial class buttonImage
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

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// buttonImage
			// 
			this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.MouseLeave += new System.EventHandler(this.buttonImage_MouseLeave);
			this.MouseHover += new System.EventHandler(this.buttonImage_MouseHover);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
