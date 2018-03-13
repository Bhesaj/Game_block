using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static int currentScore = 0;
	public static int highScore;

	public static int currentLevel;
	public static int unlockedLevel;
	public AudioSource Goal;


	void Start()
	{
		Goal.Play ();
		DontDestroyOnLoad (gameObject);
	}
		
	public static void CompleteLevel()
	{
		currentLevel++;
		SceneManager.LoadScene (currentLevel);
	}
		

}
