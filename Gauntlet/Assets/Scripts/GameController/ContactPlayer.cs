using UnityEngine;
using System.Collections;

public class ContactPlayer : MonoBehaviour {

	private int scoreValue =0; 
	private GameController gameController;
	private Characters character;  
	void Start(){
		GameObject gameControllerObj = GameObject.FindWithTag ("GameController"); 
		if (gameControllerObj != null) {
			gameController = gameControllerObj.GetComponent<GameController>();
		}
		if (gameController == null) { 
			Debug.Log ("Cannot Find 'GameController' Script"); 
		}
		
		
	}
	void OnTriggerEnter(Collider other){

		if (other.tag == "Chest") { 
			gameController.p1scoreCounter += gameController.chestPoints; 
			gameController.AddScore (scoreValue);  
			Destroy(other.gameObject); 
			 
			Debug.Log (gameController.p1scoreCounter); 
		}
	
		
	}

}
