using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Cargo
	{
		public string name;
		public string xarakter;
		public string xararter2;

		public Cargo(string v1, string v2, string v3)
		{
			name = v1;

		}
		internal void loading(string v)
		{
			Console.WriteLine(name + " " + v);

		}
		internal void goes(string v)
		{
			Console.WriteLine(name + " " + v);

		}

	}
}
