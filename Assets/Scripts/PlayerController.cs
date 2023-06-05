using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 movement;
    public float speed = 12f;
 


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        * Note: Player movement may need to change so that input is UI buttons.
        *       The game is currently using PC buttons for input
        */

        // Instantiate new Vector3 with input from x (to move left/right) and y (jump) axis. 
        // No need to move character forward as platform will be moving towards the character.
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        



    }

     //FixedUpdate is called at measured intervals. FixedUpdate used for physics functions
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    private void moveCharacter(Vector3 direction)
    {
        
        direction = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + direction);
        
    }

    // Function detects if we collide with obstacle
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Collision Detected." +other.name);
        
        if (other.gameObject.name == "Obstacle(Clone)") {
            SceneManager.LoadScene("Game");
        }
    }
}
