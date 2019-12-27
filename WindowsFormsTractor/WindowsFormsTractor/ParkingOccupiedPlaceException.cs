using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public class ParkingOccupiedPlaceException : Exception
	{
		public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
		{ }
	}
}
