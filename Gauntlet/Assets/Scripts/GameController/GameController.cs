using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using System.Collections.Generic; 
public class GameController : MonoBehaviour {
	public float p1scoreCounter=0;
	public float p2scoreCounter=0;
	public float p3scoreCounter=0;
	public float p4scoreCounter=0;

	public  Text p1ScoreText;
	public  Text p2ScoreText;
	public  Text p3ScoreText;
	public  Text p4ScoreText;

	public float chestPoints; 
	public float enemiesPoints; 
	public float DeathPoints;
	public float FoodPoints; 

	public static List<float> scoreMultipliers = new List<float> (); 

	public static void AddScoreMultiplier(float multiplier){ 
		scoreMultipliers.Add (multiplier); 
		float totalMultiplier = 1; 

		foreach (float m in scoreMultipliers) {
			totalMultiplier *=m; 
		}
		print ("Total multiplier is now" + totalMultiplier + "."); 
	}
	public static void RemoveScoreMultiplier(float multiplier){ 
		scoreMultipliers.Remove (multiplier); 
		float totalMultiplier = 1; 
		
		foreach (float m in scoreMultipliers) {
			totalMultiplier *=m; 
		}
		print ("Total multiplier is now" + totalMultiplier + "."); 
	}

	public void ChangeCharSpeed(){ 


	}
	void Update(){ 
		//p1ScoreText.text = "Score: " + p1scoreCounter; 

	}

	public void AddScore(int newScoreValue)
	{
		p1scoreCounter += newScoreValue;
		UpdateScore (); 

	}
	public void UpdateScore(){
		p1ScoreText.text = "Score: " + p1scoreCounter;
	}


}
