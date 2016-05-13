using UnityEngine;
using System.Collections;
using System; 

public class Characters : MonoBehaviour {
	private string _CharacterName;
	private string _charType;
	private string healthDisplay = "Health: ";

	private float _health; 
	private float _curHealth;
	private int _attack;
	private int _defense;
	private int _speed; 

	public GameObject hidden; 
	public GameObject weaponObject; 
	public int joystickNumber;
	private float healthRemaining;

	private bool isWarrior;
	private bool isArcher;
	private bool isMage; 
	private bool isValk; 
	private bool charActive;

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
	public float Health{ 
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
	public bool IsWarrior{
		get{
			return isWarrior; 
		}
		set{
			isWarrior = value; 
		}

	}
	public bool IsArcher{
		get{
			return isArcher; 
		}
		set{
			isArcher = value; 
		}
		
	}
	public bool IsMage{
		get{
			return isMage; 
		}
		set{
			isMage = value; 
		}
		
	}
	public bool IsValk{
		get{
			return isValk; 
		}
		set{
			isValk = value; 
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
		_health -= Time.deltaTime; 
		_curHealth = _health;
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
	void OnGUI(){
		if (_health > 0 && isWarrior == true) {
			//GUI.Label (new Rect (100, 100, 200, 100), "Health: " + (int)_health); 
			GUI.color = Color.red; 
			GUI.Box(new Rect(350, 30, Screen.width / 2 /(_health / _curHealth), 25), healthDisplay + _health);
		
		}
		else {
			GUI.Label (new Rect(100,100,100,100), "Health: You are Dead"); 
		}
		if (_health > 0 && isArcher == true) {
			//GUI.Label (new Rect (100, 100, 200, 100), "Health: " + (int)_health); 
			GUI.color = Color.yellow; 
			GUI.Box(new Rect(350, 60, Screen.width / 2 /(_health / _curHealth), 25), healthDisplay + _health);
		
		} 
		else {
			GUI.Label (new Rect(100,100,100,100), "Health: You are Dead"); 
		}
		if (_health > 0 && isMage == true) {
			//GUI.Label (new Rect (100, 100, 200, 100), "Health: " + (int)_health); 
			GUI.color = Color.blue; 
			GUI.Box(new Rect(350, 90, Screen.width / 2 /(_health / _curHealth), 25), healthDisplay + _health);

		} 
		else {
			GUI.Label (new Rect(100,100,100,100), "Health: You are Dead"); 
		}
		if (_health > 0 && isValk == true) {
			//GUI.Label (new Rect (100, 100, 200, 100), "Health: " + (int)_health); 
			GUI.color = Color.green; 
			GUI.Box(new Rect(350, 120, Screen.width / 2 /(_health / _curHealth), 25), healthDisplay + _health);
		} 
		else {
			GUI.Label (new Rect(100,100,100,100), "Health: You are Dead"); 
		}



	}
	void DropInDropOut(){ 
		; 
		string joystickString = joystickNumber.ToString ();
		if (!charActive) {
			if(Input.GetButtonDown("Start_P" + joystickString)){
				hidden = GameObject.Find ("player2"); 
				 
			}
		}


	}
}
