using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Сети_Петри
{
	class Line
	{
		public int Width { get; set; } = 1;
		public Point Pos { set; get; }
		public Line(Point pos)
		{
			Pos = pos;
		}
	}
}
