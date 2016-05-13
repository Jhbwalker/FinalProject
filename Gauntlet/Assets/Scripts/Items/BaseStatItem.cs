using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {
	private int attack; 
	private int speed; 
	private int defense; 
	private int health; 

	public int Health{ 
		get
		{ 
			return health; 
		} 
		set
		{ 
			health = value; 
		} 
		
	}
	public int Attack{ 
		get
		{ 
			return attack; 
		} 
		set
		{ 
			attack = value; 
		} 
		
	}
	public int Speed{ 
		get
		{ 
			return speed; 
		} 
		set
		{ 
			speed = value; 
		}
		
	}
	public int Defense{ 
		get
		{ 
			return defense; 
		} 
		set
		{ 
			defense = value; 
		} 
		
	}

}
