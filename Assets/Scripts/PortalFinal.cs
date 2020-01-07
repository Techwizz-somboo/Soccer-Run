using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalFinal : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Portal Touched!");
        if (PlayerController.count >= 10) //When you collect max amount of coins then do something.
        {
            Debug.Log("You collected all the coins!");
            SceneManager.LoadScene("ThanksForPlay", LoadSceneMode.Additive);
        }

        if (PlayerController.count < 10)
        {
            Debug.Log("You need to collect all the coins first...");
        }
    }
}
