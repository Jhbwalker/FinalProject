using UnityEngine;
using System.Collections;

public class PowerUpController : MonoBehaviour {
	private bool doublePoints; 
	private bool speedUp; 

	private bool powerupActive; 

	private float powerUpLengthCounter; 
	//private ScoreManager; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ActivatePowerUp(bool dP, bool speed, float time)
	{ 

		doublePoints = dP; 
		speedUp = speed; 

		powerUpLengthCounter = time; 
	}
}
