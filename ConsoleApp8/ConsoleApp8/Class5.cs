using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Cargo : tpansport
	{

		public Cargo(string v1, string v2, string v3) : base(v1, v2, v3)
		{
	
		}
		internal void loading(string v)
		{
			Console.WriteLine(Name + " " + v);

		}
		internal void goes(string v)
		{
			Console.WriteLine(Name + " " + v);

		}

	}
}
