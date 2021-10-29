using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player keyboard input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //use transform.Translate method to change the position
        // set the speed 5 meter/ second * forward key
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // turn vehicle left or right
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime  );
    }
}
