using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 4f, -8f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            offset = new Vector3(0, 4f, -8f);

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            offset = new Vector3(0, 4f, 0f);
        }
        transform.position = Player.transform.position + offset;



    }
}
