using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentScript : MonoBehaviour {

    public Vector3 currentRot;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update () {

        //eulerAngles finds currentRotation
        currentRot = GetComponent<Transform>().eulerAngles;

        //Horizontal Tilt
        //if currentRotation numbers wrong, ball will get stuck
        if ((Input.GetAxis("Horizontal") > .2) &&
            (currentRot.z <= 10 || currentRot.z >= 348))
        {
            transform.Rotate(0, 0, 1);
        }
        if((Input.GetAxis("Horizontal") < -.2) &&
            (currentRot.z >= 349 || currentRot.z <= 11))
        {
            transform.Rotate(0, 0, -1);
        }

        //Vertical Tilt
        if ((Input.GetAxis("Vertical") > .2) &&
            (currentRot.x <= 10 || currentRot.x >= 348))
        {
            transform.Rotate(1, 0, 0);
        }
        if ((Input.GetAxis("Vertical") < -.2) &&
            (currentRot.x >= 349 || currentRot.x <= 11))
        {
            transform.Rotate(-1, 0, 0);
        }
    }
}
