using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float maxHealth = 100.0f;
	public float curHealth = 10.0f;
	public float sanityDrainSpeed = 500.0f; //# of milliseconds for 1 Health to drop.
	public string sanity = "Sanity: ";
	
	void Start () {
		
	}
	
	
	void Update () {
		curHealth = (int)Mathf.Clamp(curHealth - (Time.deltaTime * (1000 / sanityDrainSpeed)),0.0f,maxHealth);
	}
	
	void OnGUI() {
		GUI.Box(new Rect(350, 10, Screen.width / 2 /(maxHealth / curHealth), 25), sanity + curHealth + "/" + maxHealth);
	}
}
