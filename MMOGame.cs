using System;

namespace MMOGame
{
	class Character
	{
		public string CharacterName {get; set;} = default!;
		public int ATK {get; set;}
		public int DEF {get; set;} 
	}

	class Human : Character
	{
		
	}
}