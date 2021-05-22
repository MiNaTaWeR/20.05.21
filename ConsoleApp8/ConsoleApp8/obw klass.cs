using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class tpansport 
	{
		protected string Name { set; get; }
		protected string Xarakter { set; get;}
	    protected string Xarakter2 { set; get;}

        public tpansport(string Name, string Xarakter, string Xarakter2)
		{
			this.Name = Name;
			this.Xarakter = Xarakter;
			this.Xarakter2 = Xarakter2;


		}




	}
}
