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
		MultiLevelParking parking;
		private const int countLevel = 5;
		public FormParking()
		{
			InitializeComponent();
			parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
			for (int i = 0; i < countLevel; i++)
			{
				listBoxLevel.Items.Add("Уровень " + (i + 1));
			}
			listBoxLevel.SelectedIndex = 0;
		}
		private void Draw()
		{
			if (listBoxLevel.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parking[listBoxLevel.SelectedIndex].Draw(gr);
				pictureBoxParking.Image = bmp;
			}
		}
		private void buttonSetTractor_Click(object sender, EventArgs e)
		{
			if (listBoxLevel.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var tractor = new Tractor(100, 1000, dialog.Color);
					int place = parking[listBoxLevel.SelectedIndex] + tractor;
					if (place == -1)
					{
						MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					Draw();
				}
			}
		}
		private void buttonSetDop_Click(object sender, EventArgs e)
		{
			if (listBoxLevel.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var tractor = new TractorLoader(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
						int place = parking[listBoxLevel.SelectedIndex] + tractor;
						if (place == -1)
						{
							MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						Draw();
					}
				}
			}
		}

		private void buttonTakeTractor_Click(object sender, EventArgs e)
		{
			if (listBoxLevel.SelectedIndex > -1)
			{
				if (maskedTextBox.Text != "")
				{
					var tractor = parking[listBoxLevel.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
					if (tractor != null)
					{
						Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
						Graphics gr = Graphics.FromImage(bmp);
						tractor.SetPosition(20, 25, pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
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
		}
		private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
	}
}
