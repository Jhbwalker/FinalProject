using UnityEngine;
using System.Collections;

public class ArcherClass : Characters {
	
	public ArcherClass() 
	{  
		CharacterName = "Archer"; 
		CharType = "A Long ranger"; 
		
		Health = 50; 
		Attack = 8; 
		Speed = 7; 
		Defense = 2;
		IsArcher = true;

		if (Health <= 0) { 
			IsArcher = false; 

		}
		
		
	}
}
