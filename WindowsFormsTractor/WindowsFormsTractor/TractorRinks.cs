using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class TractorRinks : ITractor
	{
		public float globalPosX;
		public float globalPosY;
		public TractorRinks(float posX, float posY)
		{
			globalPosX = posX;
			globalPosY = posY + 7;
		}
		public void DrawRinks(TractorRinksCount Count, Graphics g, Color SecondaryColor)
		{
			int i = 0;
			Brush b = new SolidBrush(SecondaryColor);
			float shiftX = i * 8;
			float shiftY = i * 2;
			while (i < (int)Count / 2)
			{
				g.FillEllipse(b, globalPosX + shiftX, globalPosY - shiftY, 6, 6);
				g.FillEllipse(b, globalPosX + 43 - shiftX, globalPosY - shiftY, 6, 6);

				i++;
				shiftX = i * 8;
				shiftY = i * 2;
			}
			i++;
			shiftX = i * 8;
			if ((int)Count == 5)
			{
				g.FillEllipse(b, globalPosX + shiftX, globalPosY - shiftY, 6, 6);
			}
		}
	}
}
