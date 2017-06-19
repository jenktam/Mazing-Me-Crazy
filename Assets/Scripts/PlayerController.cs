using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int count;

    public Text countText;
    public Text winText;
    public Text loseText;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        loseText.text = "";
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

        if (other.CompareTag("Hole"))
        {
            Destroy(gameObject);
            loseText.text = "You Lose :(";
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
