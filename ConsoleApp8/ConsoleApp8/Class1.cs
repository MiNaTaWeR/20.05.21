using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Car
	{
		public string name;
		public string xarakter;
		public string xararter2;

		public Car (string v1,string v2, string v3)
		{
			name = v1;

		}
		internal void goes(string v)
		{
			Console.WriteLine(name + " " + v);

		}
	}

}
