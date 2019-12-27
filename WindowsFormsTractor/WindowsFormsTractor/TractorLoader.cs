using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class TractorLoader : Tractor
	{
		public Color DopColor { private set; get; }
		public bool RearBucket { private set; get; }
		public bool FrontBucket { private set; get; }
		public bool Lantern { private set; get; }
		public TractorRinksCount Count { protected set; get; }
		private int RinksType;
		public TractorLoader(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rearbucket, bool lantern, bool frontbucket, TractorRinksCount tractorrinks) :
			base(maxSpeed, weight, mainColor)
		{
			DopColor = dopColor;
			RearBucket = rearbucket;
			Lantern = lantern;
			FrontBucket = frontbucket;
			Count = tractorrinks;
			RinksType = new Random().Next(0, 3);
		}
		public override void DrawTractor(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush brBlack = new SolidBrush(DopColor);
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
			base.DrawTractor(g);
			ITractor tractorR;

			switch (RinksType)
			{
				case 0:
					tractorR = new TractorRinks(_startPosX, _startPosY);
					break;
				case 1:
					tractorR = new ImprovedRinks(_startPosX, _startPosY);
					break;
				default:
					tractorR = new RinksTriangle(_startPosX, _startPosY);
					break;
			}
			tractorR.DrawRinks(Count, g, DopColor);
		}
	}
}
