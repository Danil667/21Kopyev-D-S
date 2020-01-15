using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTractor
{
	public partial class FormParking : Form
	{
		Parking<ITransport, ITractor> parking;
		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<ITransport, ITractor>(20, 6, pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}
		private void buttonSetTractor_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var tractor = new Tractor(100, 1000, dialog.Color);
				int place = parking + tractor;
				Draw();
			}
		}
		private void buttonSetDop_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var tractor = new TractorLoader(100, 1000, dialog.Color, dialogDop.Color, true, true, true, TractorRinksCount.FOUR );
					int place = parking + tractor;
					Draw();
				}
			}
		}
		private void buttonTakeTractor_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var tractor = parking - Convert.ToInt32(maskedTextBox.Text);
				if (tractor != null)
				{
					Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
					Graphics gr = Graphics.FromImage(bmp);
					tractor.SetPosition(21, 25, pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
					tractor.DrawTractor(gr);
					pictureBoxTakeTractor.Image = bmp;
				}
				else
				{
					Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
					pictureBoxTakeTractor.Image = bmp;
				}
				Draw();
			}
		}
		private void buttonComparePlace_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				if (parking < Convert.ToInt32(maskedTextBox.Text))
				{
					labelCompareText.Text = "Свободных мест меньше " + maskedTextBox.Text;
				}
				else if (parking > Convert.ToInt32(maskedTextBox.Text))
				{
					labelCompareText.Text = "Свободных мест больше " + maskedTextBox.Text;
				}
				else
				{
					labelCompareText.Text = "Свободных мест " + maskedTextBox.Text;
				}
			}
		}
	}
}
