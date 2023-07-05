using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public Rigidbody2D myRigitBody;
    public int jumpForce;
    public float acceleration = 3;
    public float speed = 3;
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive) {
            myRigitBody.velocity = Vector2.up * jumpForce;
        }
        if(myRigitBody.velocity.x < speed / 50)
        {
            myRigitBody.velocity += Vector2.right * acceleration / 50 * Time.deltaTime;
        }
        
    }   

    public void dead() { isAlive = false;  }
}
