using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentScript : MonoBehaviour {

    public float rotationSpeed = 40;
    public float maxRotationAngle = 11;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update () {
        //eulerAngles finds currentRotation
        Vector3 currentRot = GetComponent<Transform>().eulerAngles;

        //rotation determines how much we want to rotate the board during this frame.
        float rotationAmount = rotationSpeed * Time.deltaTime;

        //Horizontal Tilt
        if(currentRot.z >= 180)
        {
            currentRot.z -= 360;
        }
        //increase
        if (Input.GetAxis("Horizontal") < -.2 && currentRot.z <= maxRotationAngle)
        {
            transform.Rotate(0, 0, rotationAmount);
        }
        //decrease
        if(Input.GetAxis("Horizontal") > .2 && currentRot.z >= -1 * maxRotationAngle)
        {
            transform.Rotate(0, 0, -1 * rotationAmount);
        }

        //Vertical Tilt
        if (currentRot.x >= 180)
        {
            currentRot.x -= 360;
        }
        //increase
        if (Input.GetAxis("Vertical") > .2 && currentRot.x <= maxRotationAngle)
        {
            transform.Rotate(rotationAmount, 0, 0);
        }
        //decrease
        if (Input.GetAxis("Vertical") < -.2 && currentRot.x >= -1 * maxRotationAngle)
        {
            transform.Rotate(-1 * rotationAmount, 0, 0);
        }
    }
}
