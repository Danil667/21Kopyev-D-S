using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class RinksTriangle : ITractor
	{
		public float globalPosX;
		public float globalPosY;
		public RinksTriangle(float posX, float posY)
		{
			globalPosX = posX;
			globalPosY = posY + 7;
		}
		public void DrawRinks(TractorRinksCount Count, Graphics g, Color SecondaryColor)
		{
			int i = 0;
			Brush b = new SolidBrush(SecondaryColor);
			Brush r = new SolidBrush(Color.Red);
			float shiftX = i * 8;
			float shiftY = i * 2;
			List<Point> pointsRinks = new List<Point>(6);
			while (i < (int)Count / 2)
			{
				pointsRinks.Add(new Point((int)(globalPosX + 1 + shiftX), (int)(globalPosY + 5 - shiftY)));
				pointsRinks.Add(new Point((int)(globalPosX + 3 + shiftX), (int)(globalPosY +1 - shiftY)));
				pointsRinks.Add(new Point((int)(globalPosX + 5 + shiftX), (int)(globalPosY + 5 - shiftY)));
				pointsRinks.Add(new Point((int)(globalPosX + 43 - shiftX+1), (int)(globalPosY + 5 - shiftY)));
				pointsRinks.Add(new Point((int)(globalPosX + 43 - shiftX+3), (int)(globalPosY + 1 - shiftY)));
				pointsRinks.Add(new Point((int)(globalPosX + 43 - shiftX+5), (int)(globalPosY + 5 - shiftY)));
				g.FillEllipse(b, globalPosX + shiftX, globalPosY - shiftY, 6, 6);
				g.FillEllipse(b, globalPosX + 43 - shiftX, globalPosY - shiftY, 6, 6);
				i++;
				shiftX = i * 8;
				shiftY = i * 2;
			}
			g.FillPolygon(r, pointsRinks.ToArray<Point>());
			r.Dispose();
			i++;
			shiftX = i * 8;
			if ((int)Count == 5)
			{
				g.FillEllipse(b, globalPosX + shiftX, globalPosY - shiftY, 6, 6);
			}
		}
	}
}
