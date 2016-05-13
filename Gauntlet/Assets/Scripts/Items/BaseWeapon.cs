using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {


	public enum WeaponTypes{ 
		SWORD, 
		BOW, 
		STAFF, 
		HOLYSWORD
	}

	private WeaponTypes _weaponType; 

	public WeaponTypes WeaponType { 
		get { 
			return _weaponType; 
		}
		set { 
			_weaponType = value; 
		}  
	}

}
