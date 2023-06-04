using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_ObstacleController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // Function destroys obstacle when it goes out of the screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
