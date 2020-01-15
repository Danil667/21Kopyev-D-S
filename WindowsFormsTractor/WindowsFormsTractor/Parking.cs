using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class Parking<T, A> where T : class, ITransport where A : class, ITractor
	{
		private T[] _places;
		private A[] tractorR;
		private int PictureWidth { get; set; }
		private int PictureHeight { get; set; }
		private const int _placeSizeWidth = 160;
		private const int _placeSizeHeight = 55;
		public Parking(int sizes, int countTractor, int pictureWidth, int pictureHeight)
		{
			_places = new T[sizes];
			tractorR = new A[countTractor];
			PictureWidth = pictureWidth;
			PictureHeight = pictureHeight;
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i] = null;
			}
		}
		public static int operator +(Parking<T, A> p, T tractor)
		{
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p.CheckFreePlace(i))
				{
					p._places[i] = tractor;
					p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 20,
					i % 5 * _placeSizeHeight + 32, p.PictureWidth, p.PictureHeight);
					return i;
				}
			}
			return -1;
		}
		public static T operator -(Parking<T, A> p, int index)
		{
			if (index < 0 || index > p._places.Length)
			{
				return null;
			}
			if (!p.CheckFreePlace(index))
			{
				T tractor = p._places[index];
				p._places[index] = null;
				return tractor;
			}
			return null;
		}
		public static bool operator <(Parking<T, A> p, int index)
		{
			int freePlaces = 0;
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p.CheckFreePlace(i))
				{
					freePlaces++;
				}
			}
			return freePlaces < index ? true : false;
		}
		public static bool operator >(Parking<T, A> p, int index)
		{
			int freePlaces = 0;
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p.CheckFreePlace(i))
				{
					freePlaces++;
				}
			}
			return freePlaces > index ? true : false;
		}
		private bool CheckFreePlace(int index)
		{
			return _places[index] == null;

		}
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				if (!CheckFreePlace(i))
				{
					_places[i].DrawTractor(g);
				}
			}
			for (int i = 0; i < tractorR.Length; i++)
			{
				if (tractorR[i] != null)
				{
					tractorR[i].DrawRinks(TractorRinksCount.FIVE, g, Color.White);
				}
			}
		}
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 380);
			for (int i = 0; i < _places.Length / 5; i++)
			{
				for (int j = 0; j < 6; ++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
					i * _placeSizeWidth + 110, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 380);
			}
		}
	}
}
