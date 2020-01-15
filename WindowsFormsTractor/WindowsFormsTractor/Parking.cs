using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class Parking<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Parking<T>>
		where T : class, ITransport
	{
		private Dictionary<int, T> _places;
		private int _maxCount;
		private int PictureWidth { get; set; }
		private int PictureHeight { get; set; }
		private const int _placeSizeWidth = 160;
		private const int _placeSizeHeight = 55;
		private int _currentIndex;
		public int GetKey
		{
			get
			{
				return _places.Keys.ToList()[_currentIndex];
			}
		}
		public Parking(int sizes, int pictureWidth, int pictureHeight)
		{
			_maxCount = sizes;
			_places = new Dictionary<int, T>();
			_currentIndex = -1;
			PictureWidth = pictureWidth;
			PictureHeight = pictureHeight;
		}
		public static int operator +(Parking<T> p, T tractor)
		{
			if (p._places.Count == p._maxCount)
			{
				throw new ParkingOverflowException();
			}
			if (p._places.ContainsValue(tractor))
			{
				throw new ParkingAlreadyHaveException();
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
			throw new ParkingNotFoundException(index);		
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
				else
				{
					throw new ParkingOccupiedPlaceException(ind);
				}
			}

		}
		public T Current
		{
			get
			{
				return _places[_places.Keys.ToList()[_currentIndex]];
			}
		}
		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}
		public void Dispose()
		{
			_places.Clear();
		}
		public bool MoveNext()
		{
			if (_currentIndex + 1 >= _places.Count)
			{
				Reset();
				return false;
			}
			_currentIndex++;
			return true;
		}
		public void Reset()
		{
			_currentIndex = -1;
		}
		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		public int CompareTo(Parking<T> other)
		{
			if (_places.Count > other._places.Count)
			{
				return -1;
			}
			else if (_places.Count < other._places.Count)
			{
				return 1;
			}
			else if (_places.Count > 0)
			{
				var thisKeys = _places.Keys.ToList();
				var otherKeys = other._places.Keys.ToList();
				for (int i = 0; i < _places.Count; ++i)
				{
					if (_places[thisKeys[i]] is Tractor && other._places[thisKeys[i]] is TractorLoader)
					{
						return 1;
					}
					if (_places[thisKeys[i]] is TractorLoader && other._places[thisKeys[i]] is Tractor)
					{
						return -1;
					}
					if (_places[thisKeys[i]] is Tractor && other._places[thisKeys[i]] is Tractor)
					{
						return (_places[thisKeys[i]] is Tractor).CompareTo(other._places[thisKeys[i]] is Tractor);
					}
					if (_places[thisKeys[i]] is TractorLoader && other._places[thisKeys[i]] is TractorLoader)
					{
						return (_places[thisKeys[i]] is TractorLoader).CompareTo(other._places[thisKeys[i]] is TractorLoader);
					}
				}
			}
			return 0;
		}
	}
}
