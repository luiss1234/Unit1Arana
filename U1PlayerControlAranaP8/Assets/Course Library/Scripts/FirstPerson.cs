using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;


    // Start is called before the first frame update
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("CameraSwitch"))
        {
            Cam1.enabled = !Cam1.enabled;
            Cam2.enabled = !Cam2.enabled;
        }
    }
}
