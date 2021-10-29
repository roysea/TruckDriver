using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after truck is moved so camera always follows the truck
    void LateUpdate()
    {
        // offset camera behind player 
        transform.position = player.transform.position + offset;
    }
}
