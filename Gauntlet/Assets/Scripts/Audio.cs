using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {
	public AudioSource aS; 
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){ 
		if (other.tag == "Chest") { 
			aS.Play (); 
		}
	}
}
