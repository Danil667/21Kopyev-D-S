using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTractor
{
	public interface ITractor
	{
		void DrawRinks(TractorRinksCount Count, Graphics g, Color color);
	}
}
