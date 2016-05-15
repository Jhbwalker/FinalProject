using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion; 

	void Start(){ 
		CreatePotion ();
		Debug.Log (newPotion.ItemName); 
		Debug.Log (newPotion.ItemDescriptions);
		Debug.Log (newPotion.PotionType);
		Debug.Log (newPotion.ItemID); 
	

	}

	private void CreatePotion(){
		newPotion = new BasePotion(); 
		newPotion.ItemName = "Potion"; 
		newPotion.ItemDescriptions = "This is a potion"; 
		newPotion.ItemID = Random.Range(1, 101);
		ChoosePotionType (); 
	}

	private void ChoosePotionType(){ 
		int randomTemp = Random.Range (0, 6); 
		if(randomTemp == 0){ 
			newPotion.PotionType = BasePotion.PotionTypes.Health; 
		}
		else if(randomTemp == 1){ 
			newPotion.PotionType = BasePotion.PotionTypes.Energy; 
		}
		else if(randomTemp == 2){ 
			newPotion.PotionType = BasePotion.PotionTypes.Strength; 
		}
		else if(randomTemp == 3){ 
			newPotion.PotionType = BasePotion.PotionTypes.Speed; 
		}
		else if(randomTemp == 0){ 
			newPotion.PotionType = BasePotion.PotionTypes.Defense; 
		}
	}
}
