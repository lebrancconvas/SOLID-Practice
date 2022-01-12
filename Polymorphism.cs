using System;

namespace Polymorphism
{

	class Animal 
	{
	
		private string _name = default!;
		public void setName(string name)
		{
			_name = name;
		}

		public string getName()
		{
			return _name;
		}
	}

	class Dog : Animal
	{
		public void bark()
		{
			Console.WriteLine("Hong Hong");
		}

		public void bite()
		{
			Console.WriteLine("The Dog is biting.");
		}
	}
}