using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public static bool pressedEscape = false;

	private Rigidbody rb;
	public static int count;

    void Update ()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
		if (Input.GetKeyDown("escape"))
		{
			if (pressedEscape == false) {
				Debug.Log ("Menu loaded!");
				SceneManager.LoadScene ("MiniMenu", LoadSceneMode.Additive);
				pressedEscape = true;
			}
			else if (pressedEscape == true) {
				Debug.Log ("Menu removed!");
                SceneManager.UnloadScene("MiniMenu");
                pressedEscape = false;
			}
			else 
			{
				Debug.Log ("I don't know what this game is doing anymore...");
			}
		}
    }
    void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
	}

	void FixedUpdate () //Movement of player.
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) //Checks to see if you touched the pickup, if yes then it will disappear and get counted.
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 10) //When you collect max amount of coins then do something.
		{
			Debug.Log ("You collected all the coins!");
		}

	}
}
