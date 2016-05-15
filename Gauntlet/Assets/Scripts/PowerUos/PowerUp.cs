using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	public bool doublePoitnts; 
	public bool speedIncrease; 


	public float powerupLength; 

	private PowerUpController pManager; 


	// Use this for initialization
	void Start () {
		pManager = FindObjectOfType<PowerUpController> (); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "P1" || other.name == "P2" || other.name == "P3" || other.name == "P4") 
		{ 
			pManager.ActivatePowerUp(doublePoitnts, speedIncrease, powerupLength); 


		} 
		gameObject.SetActive(false); 

	}
}
