using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class TractorRinks
	{
		public TractorRinksCount Count { private set; get; }
		public Color PrimaryColor { private set; get; }
		public Color SecondaryColor { private set; get; }
		public float globalPosX;
		public float globalPosY;
		public TractorRinks(TractorRinksCount tractorrinksCount, Color primaryColor, Color secondaryColor,
			float posX, float posY)
		{
			PrimaryColor = primaryColor;
			SecondaryColor = secondaryColor;
			Count = tractorrinksCount;
			globalPosX = posX;
			globalPosY = posY + 7;
		}
		private int CountToInt(TractorRinksCount tractorrinksCount)
		{
			return (int)tractorrinksCount + 4;
		}
		public void DrawRinks(Graphics g)
		{
			int i = 0;
			Brush b = new SolidBrush(SecondaryColor);
			float shiftX = i * 8;
			float shiftY = i * 2;
			while (i < CountToInt(Count) / 2)
			{
				g.FillEllipse(b, globalPosX + shiftX, globalPosY - shiftY, 6, 6);
				g.FillEllipse(b, globalPosX + 43 - shiftX, globalPosY - shiftY, 6, 6);

				i++;
				shiftX = i * 8;
				shiftY = i * 2;
			}
			i++;
			shiftX = i * 8;
			if (CountToInt(Count) == 5)
			{
				g.FillEllipse(b, globalPosX + shiftX, globalPosY - shiftY, 6, 6);
			}
		}
	}
}
