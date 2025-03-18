using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 60.0f;
    public float verticalInput;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the input for vertical movement (up/down)
        float verticalInput = Input.GetAxis("Vertical");

        // Move the plane up and down
        transform.Translate(Vector3.up * verticalInput * moveSpeed * Time.deltaTime);






        // get the user's vertical input
       

        // move the plane forward at a constant rate
       

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);

       
    }
}
