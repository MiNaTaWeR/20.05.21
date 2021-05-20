using System;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{
			Car BMW = new Car("BWM", "Сonvenient", "Beautiful");
			Water Princess_25M = new Water("Princess_25M", "Expensive", "Operated");
			Air M350 = new Air("M350", "Comfortable", "Fast");
			Bicycle LEGEND29 = new Bicycle("LEGEND29", "Convenient", "High-speed");
			Cargo Kamaz = new Cargo ("Kamaz", "Capacious", "Heavy");

			BMW.goes("Едет по дороге в Москву");
			BMW.goes("Едет из Москвы");

			Princess_25M.floats("Плывет в Москву");
			Princess_25M.floats("Плывет из Москвы");

			M350.fly("Летит в Москву");
			M350.fly("Летит из Москвы");

			LEGEND29.slides("Катится в Москву");
			LEGEND29.slides("Катится из Москвы");

			Kamaz.goes("Едет в Москву");
			Kamaz.loading("Загружает в Москве");
			Kamaz.goes("Едет в Курган");
			Kamaz.loading("Выгружает в Кургане");




		}

		






	}
}
