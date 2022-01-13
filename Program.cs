using MMOCharacter;

namespace Program
{
	class Program
	{
		public static void Main(string[] args)
		{
			Character char01 = new Human()
			{
				CharacterName = "Noah",
				HP = 7000,
				ATK = 200,
				DEF = 100
			};

			Human noah = (Human)char01; 
			Console.WriteLine($"Status\nName: {noah.CharacterName}\nHP: {noah.HP}\nATK: {noah.ATK}\nDEF: {noah.DEF}"); 
		} 
	}
}