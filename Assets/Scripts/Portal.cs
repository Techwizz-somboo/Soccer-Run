using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("Portal Touched!");
		if (PlayerController.count >= 10) //When you collect max amount of coins then do something.
		{
			Debug.Log ("You collected all the coins!");
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}

		if (PlayerController.count < 10) 
		{
			Debug.Log ("You need to collect all the coins first...");
		}
	}
}
