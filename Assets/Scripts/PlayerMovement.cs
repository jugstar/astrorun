using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float jumpForce = 5f;
    [SerializeField] float fallSpeed = 10f;
    public Rigidbody rb;
    //public Vector3 movement;
    //public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        * Note: Player movement will need to change so that input is UI buttons
        *       The game is currently using PC buttons for input
        */

        //------------------- TEST CODE 1 : IGNORE --------------------------//
        // Only get input for x and y axis since we only move character left/right and up.
        // Normalized diagonals to prevent faster movement when two inputs are used together.
        //movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;

        //-------------------    TEST CODE 2    --------------------------//

        
        // Note the first 2 statements may need to be chaned to use rb instead of transform
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rb.useGravity = true;
        }
        if(rb.velocity.y > 0)
        {
            rb.AddForce(Vector3.down * fallSpeed);
        }



    }

    /*private void FixedUpdate()
     {
         moveCharacter(movement);
     }

     void moveCharacter(Vector3 direction)
     {
         rb.velocity = direction * speed * Time.fixedDeltaTime;
     }*/
}
