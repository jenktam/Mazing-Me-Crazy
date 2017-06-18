using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int count;

    public Text countText;
    public Text winText;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
        if(other.name == "Goal")
        {
            Destroy(gameObject);
            Debug.Log("You Win!");
        }

        count++;
        SetCountText();
    }

    private void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if(count >= 10)
        {
            winText.text = "You Win!";
        }
    }
}
