// See https://aka.ms/new-console-template for more information

namespace DanielAriasHoteleriaMascotasRep
{ 
    class Program
{
		class Persona
		{
			public void method()
			{
				Console.WriteLine("");
			}
		}
		class Extendida : Cliente
		{
			public void method2()
			{
				Console.WriteLine("");
			}
		}

		class Extendida2 : Trabajador
		{
			public void method3()
			{
				Console.WriteLine("");
			}
		}

		
		static void Main(string[] args)
{
            Extendida obj = new Extendida();
            obj.method2();

			Extendida2 obj2 = new Extendida2();
			obj.method2();
		}
}
}