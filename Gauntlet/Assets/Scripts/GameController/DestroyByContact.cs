using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	private int scoreValue =0; 
	private GameController gameController;
	private Characters character; 
	public AudioSource aCP; 
	void Start(){
		GameObject gameControllerObj = GameObject.FindWithTag ("GameController"); 
		if (gameControllerObj != null) {
			gameController = gameControllerObj.GetComponent<GameController>();
		}
		if (gameController == null) { 
			Debug.Log ("Cannot Find 'GameController' Script"); 
		}
		aCP = GetComponent<AudioSource> ();

	}
	void OnTriggerEnter(Collider other){
		 
		if (other.tag == "Wall") { 
			return; 
		} 
		else if (other.tag == "Chest") { 

			gameController.p1scoreCounter += gameController.chestPoints /2; 
			gameController.AddScore (scoreValue);  
			Destroy (other.gameObject); 
			Destroy (gameObject); 
			aCP.Play (); 
			Debug.Log (gameController.p1scoreCounter); 
		}
		else if (other.tag == "Food") { 

			gameController.p1scoreCounter += gameController.FoodPoints; 
			gameController.AddScore (scoreValue);  
			Destroy (other.gameObject); 
			Destroy (gameObject); 
			Debug.Log (gameController.p1scoreCounter);
			 

		}

	}

}
