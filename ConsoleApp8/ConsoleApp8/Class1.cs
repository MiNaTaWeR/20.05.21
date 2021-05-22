using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Car : tpansport
	{
		public Car (string v1,string v2, string v3) : base(v1, v2, v3)
		{

		}
		internal void goes(string v)
		{
			Console.WriteLine(Name + " " + v);

		}
	}

}
