using UnityEngine;
using System.Collections;
using System; 

public class Characters : MonoBehaviour {
	private string _CharacterName;
	private string _charType; 

	private int _health; 
	private int _attack;
	private int _defense;
	private int _speed; 

	public GameObject weaponObject; 
	public int joystickNumber;

	public string CharacterName{ 
		get
		{ 
			return _CharacterName; 
		} 
		set
		{ 
			_CharacterName = value; 
		} 

	}
	public string CharType{ 
		get
		{ 
			return _charType; 
		} 
		set
		{ 
			_charType = value; 
		} 
	
	}
	public int Health{ 
		get
		{ 
			return _health; 
		} 
		set
		{ 
			_health = value; 
		} 

	}
	public int Attack{ 
		get
		{ 
			return _attack; 
		} 
		set
		{ 
			_attack = value; 
		} 
		
	}
	public int Speed{ 
		get
		{ 
			return _speed; 
		} 
		set
		{ 
			_speed = value; 
		} 
		
	}
	public int Defense{ 
		get
		{ 
			return _defense; 
		} 
		set
		{ 
			_defense = value; 
		} 
		
	}



	void Awake(){ 
		 
	
	}


	// Use this for initialization
	void Start () {
		weaponObject = Resources.Load ("Sphere") as GameObject; 
	}
	
	// Update is called once per frame
	void Update () {

		Fire (); 
	}
	public void Fire(){ 
		string joystickString = joystickNumber.ToString ();

		if (Input.GetButtonDown ("X_P" + joystickString)) { 
			GameObject projectile = Instantiate(weaponObject) as GameObject; 
			projectile.transform.position = transform.position + transform.forward*2;
			Rigidbody rb = projectile.GetComponent<Rigidbody>(); 
			rb.velocity = transform.forward *15; 
			
		}

	} 
}
