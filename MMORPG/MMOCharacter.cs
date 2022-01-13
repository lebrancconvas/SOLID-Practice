using System;

namespace MMOCharacter
{
	class Character
	{
		public string CharacterName {get; set;} = default!;
		public int HP {get; set;}
		public int ATK {get; set;}
		public int DEF {get; set;} 
	}

	class Human : Character
	{
		
	}

	class Beast : Character
	{

	}

	class Robot : Character
	{

	}

	class Entity : Character
	{

	}

	class Being : Character
	{
		
	}
}