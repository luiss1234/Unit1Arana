using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the input for vertical movement (up/down)
         verticalInput = Input.GetAxis("Vertical");

        // Move the plane up and down
        transform.Translate(Vector3.forward *  speed);
            
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);

       
    }
}
