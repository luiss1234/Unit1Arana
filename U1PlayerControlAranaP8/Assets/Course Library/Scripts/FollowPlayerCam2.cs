using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCam2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, 2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
