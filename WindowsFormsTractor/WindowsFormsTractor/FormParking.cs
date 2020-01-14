using NLog;
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
		FormTractorConfig form;
		MultiLevelParking parking;
		private const int countLevel = 5;
		private Logger logger;
		private Logger exception;
		public FormParking()
		{
			InitializeComponent();
			logger = LogManager.GetCurrentClassLogger();
			exception = LogManager.GetCurrentClassLogger();
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
		private void buttonTakeTractor_Click(object sender, EventArgs e)
		{
			if (listBoxLevel.SelectedIndex > -1)
			{
				if (maskedTextBox.Text != "")
				{
					try
					{
						var tractor = parking[listBoxLevel.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
						Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
						Graphics gr = Graphics.FromImage(bmp);
						tractor.SetPosition(10, 25, pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
						tractor.DrawTractor(gr);
						pictureBoxTakeTractor.Image = bmp;
						logger.Info("Изъят трактор " + tractor.ToString() + " с места " + maskedTextBox.Text);
						Draw();
					}
					catch (ParkingNotFoundException ex)
					{
						exception.Debug(ex.Message);
						MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width, pictureBoxTakeTractor.Height);
						pictureBoxTakeTractor.Image = bmp;
					}
					catch (Exception ex)
					{
						exception.Debug(ex.Message);
						MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}	
				}
			}
		}
		private void listBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
		private void buttonSetTractor_Click(object sender, EventArgs e)
		{
			form = new FormTractorConfig();
			form.AddEvent(AddTractor);
			form.Show();
		}
		private void AddTractor(ITransport tractor)
		{
			if (tractor != null && listBoxLevel.SelectedIndex > -1)
			{
				try
				{
					int place = parking[listBoxLevel.SelectedIndex] + tractor;
					logger.Info("Добавлен трактор " + tractor.ToString() + " на место " + place);
					Draw();
				}
				catch (ParkingOverflowException ex)
				{
					exception.Debug(ex.Message);
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (ParkingAlreadyHaveException ex)
				{
					MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					exception.Debug(ex.Message);
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					parking.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					exception.Debug(ex.Message);
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					parking.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
				}
				catch (ParkingOccupiedPlaceException ex)
				{
					exception.Debug(ex.Message);
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					exception.Debug(ex.Message);
					MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Draw();
			}
		}
		private void buttonSort_Click(object sender, EventArgs e)
		{
			parking.Sort();
			Draw();
			logger.Info("Сортировка уровней");
		}
	}
}
