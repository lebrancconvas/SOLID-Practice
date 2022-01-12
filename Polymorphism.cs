// using Internal;
using System;

namespace Polymorphism
{

	class Animal 
	{
		public string Name {get; set;} = default!;

		public virtual void Barking(String barkingSound)
		{
			Console.WriteLine(barkingSound);
		}
	}

	class Dog : Animal
	{

		public void bite()
		{
			Console.WriteLine($"Status: {Name} is biting."); 
		}
	}

	class Cat : Animal 
	{
		public void bark()
		{
			Console.WriteLine("Meow Meow");
		}
	}
}