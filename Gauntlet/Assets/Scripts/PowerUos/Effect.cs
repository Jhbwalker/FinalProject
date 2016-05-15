using UnityEngine;
using System.Collections;
using UnityEngine.Events; 

public class Effect : MonoBehaviour {
	public float length; 
	public UnityAction action; 
	public UnityAction endAction; 

	public Effect(float lenght, UnityAction action, UnityAction endAction){
		this.length = lenght; 
		this.action = action; 
		this.endAction = endAction; 

	}

}
