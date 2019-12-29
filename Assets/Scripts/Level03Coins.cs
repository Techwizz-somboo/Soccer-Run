using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level03Coins : MonoBehaviour {

    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject coin5;
    public GameObject coin6;
    public GameObject coin7;
    public GameObject coin8;
    public GameObject coin9;
    public GameObject coin10;

    void Start()
    {
        coin2.gameObject.GetComponent<Renderer>().enabled = false;
        coin3.gameObject.GetComponent<Renderer>().enabled = false;
        coin4.gameObject.GetComponent<Renderer>().enabled = false;
        coin5.gameObject.GetComponent<Renderer>().enabled = false;
        coin6.gameObject.GetComponent<Renderer>().enabled = false;
        coin7.gameObject.GetComponent<Renderer>().enabled = false;
        coin8.gameObject.GetComponent<Renderer>().enabled = false;
        coin9.gameObject.GetComponent<Renderer>().enabled = false;
        coin10.gameObject.GetComponent<Renderer>().enabled = false;
    }

    void Update ()
    {
        if (PlayerController.count >= 1) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 2 is visible");
            //coin2.gameObject.SetActive(true);
            coin2.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 2) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 3 is visible");
            //coin2.gameObject.SetActive(true);
            coin3.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 3) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 4 is visible");
            //coin2.gameObject.SetActive(true);
            coin4.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 4) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 5 is visible");
            //coin2.gameObject.SetActive(true);
            coin5.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 5) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 6 is visible");
            //coin2.gameObject.SetActive(true);
            coin6.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 6) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 7 is visible");
            //coin2.gameObject.SetActive(true);
            coin7.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 7) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 8 is visible");
            //coin2.gameObject.SetActive(true);
            coin8.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 8) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 9 is visible");
            //coin2.gameObject.SetActive(true);
            coin9.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 9) //When you collect max amount of coins then do something.
        {
            Debug.Log("Coin 10 is visible");
            //coin2.gameObject.SetActive(true);
            coin10.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (PlayerController.count >= 10) //When you collect max amount of coins then do something.
        {
            Debug.Log("You can now go in the portal...");
            //coin2.gameObject.SetActive(true);
            coin10.gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
