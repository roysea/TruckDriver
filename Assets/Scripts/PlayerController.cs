using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get transform component of the vehicle object
        // use Translate method to change the position
        
        // to slow down the vehicle 20 meter/ second
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
