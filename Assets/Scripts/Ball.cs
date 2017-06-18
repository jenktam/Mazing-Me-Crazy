using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Pick Up"))
        //{
        //    other.gameObject.SetActive(false);
        //}
        if (other.name == "Goal")
        {
            Destroy(gameObject);
            Debug.Log("You Win!");
        }
    }
}
