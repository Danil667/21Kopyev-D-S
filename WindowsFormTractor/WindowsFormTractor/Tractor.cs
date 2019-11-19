using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormTractor
{
	public class Tractor : Vehicle
	{
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected const int carWidth = 80;
		/// <summary>
		/// Ширина отрисовки автомобиля
		/// </summary>
		protected const int carHeight = 60;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес автомобиля</param>
		/// <param name="mainColor">Основной цвет кузова</param>
		public Tractor(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 20)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 25)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - carHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTractor(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush brBlack = new SolidBrush(Color.Black);
			Brush brWhite = new SolidBrush(Color.White);
			Brush brYell = new SolidBrush(Color.Yellow);
			g.FillEllipse(brBlack, _startPosX, _startPosY, 50, 20);
			g.FillEllipse(brWhite, _startPosX + 1, _startPosY + 1, 48, 18);
			g.DrawRectangle(pen, _startPosX + 20, _startPosY - 14, 18, 14);
			g.DrawEllipse(pen, _startPosX + 1, _startPosY + 9, 5, 5);
			g.DrawEllipse(pen, _startPosX + 43, _startPosY + 9, 5, 5);
			g.DrawEllipse(pen, _startPosX + 15, _startPosY + 13, 5, 5);
			g.DrawEllipse(pen, _startPosX + 31, _startPosY + 13, 5, 5);
			g.FillRectangle(brYell, _startPosX + 2, _startPosY - 4, 46, 16);

			g.FillRectangle(brYell, _startPosX - 2, _startPosY + 2, 4, 10);
			g.FillRectangle(brYell, _startPosX + 48, _startPosY + 2, 4, 10);
		}
	}
}
