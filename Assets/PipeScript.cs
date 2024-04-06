using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float pillarSpeed = 5;
    public float deadZone = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pillarSpeed * Time.deltaTime);
         if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed!");
            Destroy(gameObject);
        }
    }
}
