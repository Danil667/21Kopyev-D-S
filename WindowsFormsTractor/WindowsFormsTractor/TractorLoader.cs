using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class TractorLoader
	{
		private float _startPosX;
		private float _startPosY;
		private int _pictureWidth;
		private int _pictureHeight;
		private const int tractorWidth = 90;
		private const int tractorHeight = 60;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public Color DopColor { private set; get; }
		public bool RearBucket { private set; get; }
		public bool FrontBucket { private set; get; }
		public bool Lantern { private set; get; }
		public TractorRinksCount Count { protected set; get; }
		public TractorLoader(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rearbucket, bool lantern, bool frontbucket, TractorRinksCount tractorrinks)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			RearBucket = rearbucket;
			Lantern = lantern;
			FrontBucket = frontbucket;
			Count = tractorrinks;
		}
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - tractorWidth)
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
					if (_startPosY + step < _pictureHeight - tractorHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public void DrawTractor(Graphics g)
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
			if (FrontBucket)
			{
				Pen pens = new Pen(MainColor);
				g.DrawLine(pen, _startPosX - 2, _startPosY + 2, _startPosX - 10, _startPosY + 15);
				g.DrawLine(pen, _startPosX - 2, _startPosY + 7, _startPosX - 10, _startPosY + 15);
				g.DrawLine(pen, _startPosX - 10, _startPosY + 15, _startPosX - 20, _startPosY + 17);
				g.DrawLine(pen, _startPosX - 10, _startPosY + 15, _startPosX - 18, _startPosY + 11);
				g.DrawLine(pen, _startPosX - 18, _startPosY + 11, _startPosX - 20, _startPosY + 17);
			}
			if (RearBucket)
			{
				Pen pens = new Pen(MainColor);
				g.DrawLine(pens, _startPosX + 48, _startPosY + 2, _startPosX + 65, _startPosY - 20);
				g.DrawLine(pens, _startPosX + 48, _startPosY + 6, _startPosX + 65, _startPosY - 18);
				g.FillEllipse(brBlack, _startPosX + 65, _startPosY - 25, 12, 10);
				g.FillRectangle(brBlack, _startPosX + 65, _startPosY - 20, 12, 5);
			}
			if (Lantern)
			{
				g.DrawLine(pen, _startPosX + 20, _startPosY - 14, _startPosX + 20, _startPosY - 20);
				g.FillEllipse(brBlack, _startPosX + 16, _startPosY - 25, 5, 5);
			}
			TractorRinks tractorrinks = new TractorRinks(Count, MainColor, DopColor, _startPosX, _startPosY);
			tractorrinks.DrawRinks(g);
		}
	}
}
