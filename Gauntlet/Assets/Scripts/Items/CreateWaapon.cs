using UnityEngine;
using System.Collections;

public class CreateWaapon : MonoBehaviour {

	private BaseWeapon newWeapon; 
	public GameObject testObject; 



	public void CreateWeapon(){ 

		newWeapon = new BaseWeapon(); 
		//assign a name to the weapon
		newWeapon.ItemName = "W" + Random.Range (1, 101);
		//weapon desc. 
		newWeapon.ItemDescriptions = "new Weapon"; 
		// weapon id
		newWeapon.ItemID = Random.Range (1, 101); 
		// stats
		newWeapon.Attack = Random.Range (1, 15);
		newWeapon.Defense = Random.Range (1, 15);
		newWeapon.Speed = Random.Range (1, 15);
		newWeapon.Health = Random.Range (1, 15);


		//choose type of weapon
		PickWeaponType(); 

	}
	private void PickWeaponType(){ 
		int randomNumb = Random.Range (1, 5);

		if (randomNumb == 1) { 
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD; 
		} else if (randomNumb == 2) { 
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW; 
		} else if (randomNumb == 3) { 
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF; 
		} else if (randomNumb == 4) { 
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.HOLYSWORD; 
		}  
	
	
	
	}
}
