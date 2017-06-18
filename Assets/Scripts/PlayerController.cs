using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int count;

    public Text countText;
    public Text winText;
    //public float speed;
    //private Rigidbody rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
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
