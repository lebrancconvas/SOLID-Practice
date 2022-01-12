// using System;
using Polymorphism;
namespace solid
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Dog dg1 = new Dog();
			dg1.setName("Big Dog");
			string dog1name = dg1.getName();
			Console.WriteLine($"Dog Name: {dog1name}");
		}
	}
}