using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class Tractor : Vehicle
	{
		protected const int carWidth = 80;
		protected const int carHeight = 60;
		public Tractor(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		public Tractor(string info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
					{
						_startPosX += step;
					}
					break;
				case Direction.Left:
					if (_startPosX - step > 20)
					{
						_startPosX -= step;
					}
					break;
				case Direction.Up:
					if (_startPosY - step > 25)
					{
						_startPosY -= step;
					}
					break;
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
			Brush brYell = new SolidBrush(MainColor);
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
		public override string ToString()
		{
			return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
		}
	}
}
