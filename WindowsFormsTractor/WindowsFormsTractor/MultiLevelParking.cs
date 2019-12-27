using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class MultiLevelParking
	{
		List<Parking<ITransport>> parkingStages;
		private const int countPlaces = 20;
		private int pictureWidth;
		private int pictureHeight;
		public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
		{
			parkingStages = new List<Parking<ITransport>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
			for (int i = 0; i < countStages; ++i)
			{
				parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
			}
		}
		public Parking<ITransport> this[int ind]
		{
			get
			{
				if (ind > -1 && ind < parkingStages.Count)
				{
					return parkingStages[ind];
				}
				return null;
			}
		}
		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.WriteLine("CountLevels:" + parkingStages.Count);
				foreach (var level in parkingStages)
				{
					sw.WriteLine("Level");
					for (int i = 0; i < countPlaces; i++)
					{
						var tractor = level[i];
						if (tractor != null)
						{
							if (tractor.GetType().Name == "Tractor")
							{
								sw.Write(i + ":Tractor:");
							}
							if (tractor.GetType().Name == "TractorLoader")
							{
								sw.Write(i + ":TractorLoader:");
							}
							sw.WriteLine(tractor);
						}
					}
				}
			}
			return true;
		}
		private void WriteToFile(string text, FileStream stream)
		{
			byte[] info = new UTF8Encoding(true).GetBytes(text);
			stream.Write(info, 0, info.Length);
		}
		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			using (StreamReader sr = new StreamReader(filename))
			{
				var strs = sr.ReadLine();
				if (strs.Contains("CountLevels"))
				{
					int count = Convert.ToInt32(strs.Split(':')[1]);
					if (parkingStages != null)
					{
						parkingStages.Clear();
					}
					parkingStages = new List<Parking<ITransport>>(count);
				}
				else
				{
					return false;
				}
				int counter = -1;
				ITransport tractor = null;
				while (counter < parkingStages.Count)
				{
					strs = sr.ReadLine();
					if (strs == "Level")
					{
						counter++;
						parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
						continue;
					}
					if (string.IsNullOrEmpty(strs))
					{
						break;
					}
					if (strs.Split(':')[1] == "Tractor")
					{
						tractor = new Tractor(strs.Split(':')[2]);
					}
					else if (strs.Split(':')[1] == "TractorLoader")
					{
						tractor = new TractorLoader(strs.Split(':')[2]);
					}
					parkingStages[counter][Convert.ToInt32(strs.Split(':')[0])] = tractor;
				}
			}
			return true;
		}
	}
}
