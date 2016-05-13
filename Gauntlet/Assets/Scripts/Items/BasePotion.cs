using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {
	public enum PotionTypes{ 
		Health,
		Energy, 
		Strength,
		Speed, 
		Defense
	}

	private PotionTypes _potionTypes; 

	public PotionTypes PotionType{ 
		get{ 
			return _potionTypes; 
		}
		set{ 
			_potionTypes = value; 
		} 
	}
}
