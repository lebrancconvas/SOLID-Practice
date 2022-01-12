using MMOGame;

namespace Program
{
	class Program
	{
		public static void Main(string[] args)
		{
			Character char01 = new Human()
			{
				CharacterName = "Noah",
				ATK = 200,
				DEF = 100
			};

			Human noah = (Human)char01; 
			Console.WriteLine($"Status\nName: {noah.CharacterName}\nATK: {noah.ATK}\nDEF: {noah.DEF}"); 
		} 
	}
}