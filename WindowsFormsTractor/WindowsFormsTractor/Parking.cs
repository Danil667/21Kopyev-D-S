using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class Parking<T> where T : class, ITransport
	{
		private Dictionary<int, T> _places;
		private int _maxCount;
		private int PictureWidth { get; set; }
		private int PictureHeight { get; set; }
		private const int _placeSizeWidth = 160;
		private const int _placeSizeHeight = 55;
		public Parking(int sizes, int pictureWidth, int pictureHeight)
		{
			_maxCount = sizes;
			_places = new Dictionary<int, T>();
			PictureWidth = pictureWidth;
			PictureHeight = pictureHeight;
		}
		public static int operator +(Parking<T> p, T tractor)
		{
			if (p._places.Count == p._maxCount)
			{
				return -1;
			}
			for (int i = 0; i < p._maxCount; i++)
			{
				if (p.CheckFreePlace(i))
				{
					p._places.Add(i, tractor);
					p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 20,
					i % 5 * _placeSizeHeight + 29, p.PictureWidth, p.PictureHeight);
					return i;
				}
			}
			return -1;
		}
		public static T operator -(Parking<T> p, int index)
		{
			if (!p.CheckFreePlace(index))
			{
				T tractor = p._places[index];
				p._places.Remove(index);
				return tractor;
			}
			return null;
		}
		private bool CheckFreePlace(int index)
		{
			return !_places.ContainsKey(index);
		}
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			var keys = _places.Keys.ToList();
			for (int i = 0; i < keys.Count; i++)
			{
				_places[keys[i]].DrawTractor(g);
			}
		}
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 380);
			for (int i = 0; i < _maxCount / 5; i++)
			{
				for (int j = 0; j < 6; ++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
					i * _placeSizeWidth + 110, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 380);
			}
		}
		public T this[int ind]
		{
			get
			{
				if (_places.ContainsKey(ind))
				{
					return _places[ind];
				}
				return null;
			}
			set
			{
				if (CheckFreePlace(ind))
				{
					_places.Add(ind, value);
					_places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 20, ind % 5 * _placeSizeHeight + 29, PictureWidth, PictureHeight);
				}
			}
		}
	}
}
