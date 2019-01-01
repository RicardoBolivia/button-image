using System.Drawing;
using System.Windows.Forms;

namespace imageButton
{
	public partial class buttonImage : Button
	{
		public buttonImage()
		{
			InitializeComponent();
		}
		private Image imageHover;

		private Image imageNormal;

		public Image NormalImage
		{
			get { return imageNormal; }
			set { imageNormal = value; }
		}
		
		public Image HoverImage
		{
			get { return imageHover; }
			set { imageHover = value; }
		}

		private void buttonImage_MouseHover(object sender, System.EventArgs e)
		{
			this.Image = imageHover;
		}

		private void buttonImage_MouseLeave(object sender, System.EventArgs e)
		{
			this.Image = imageNormal;
		}
	}
}
