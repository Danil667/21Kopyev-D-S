using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class TractorLoader : Tractor, IComparable<TractorLoader>, IEquatable<TractorLoader>
	{
		public Color DopColor { private set; get; }
		public bool RearBucket { private set; get; }
		public bool FrontBucket { private set; get; }
		public bool Lantern { private set; get; }
		public TractorLoader(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rearbucket, bool lantern, bool frontbucket) :
			base(maxSpeed, weight, mainColor)
		{
			DopColor = dopColor;
			RearBucket = rearbucket;
			Lantern = lantern;
			FrontBucket = frontbucket;
		}
		public TractorLoader(string info) : base(info)
		{
			string[] strs = info.Split(';');
			if (strs.Length == 7)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				DopColor = Color.FromName(strs[3]);
				RearBucket = Convert.ToBoolean(strs[4]);
				Lantern = Convert.ToBoolean(strs[5]);
				FrontBucket = Convert.ToBoolean(strs[6]);
			}
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
		}
		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
		public override string ToString()
		{
			return base.ToString() + ";" + DopColor.Name + ";" + RearBucket + ";" + Lantern + ";" + FrontBucket;
		}
		public int CompareTo(TractorLoader other)
		{
			var res = (this is Tractor).CompareTo(other is Tractor);
			if (res != 0)
			{
				return res;
			}
			if (DopColor != other.DopColor)
			{
				DopColor.Name.CompareTo(other.DopColor.Name);
			}
			if (FrontBucket != other.FrontBucket)
			{
				return FrontBucket.CompareTo(other.FrontBucket);
			}
			if (RearBucket != other.RearBucket)
			{
				return RearBucket.CompareTo(other.RearBucket);
			}
			if (Lantern != other.Lantern)
			{
				return Lantern.CompareTo(other.Lantern);
			}
			return 0;
		}
		public bool Equals(TractorLoader other)
		{
			var res = (this as Tractor).Equals(other as Tractor);
			if (!res)
			{
				return res;
			}
			if (GetType().Name != other.GetType().Name)
			{
				return false;
			}
			if (DopColor != other.DopColor)
			{
				return false;
			}
			if (FrontBucket != other.FrontBucket)
			{
				return false;
			}
			if (RearBucket != other.RearBucket)
			{
				return false;
			}
			if (Lantern != other.Lantern)
			{
				return false;
			}
			return true;
		}
		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is TractorLoader carObj))
			{
				return false;
			}
			else
			{
				return Equals(carObj);
			}
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
