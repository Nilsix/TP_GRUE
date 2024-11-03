using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvements : MonoBehaviour{
    float speed = 0.01f;
    float originalSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
{
        transform.Translate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
        transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.Rotate(Vector3.forward, -2);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.Rotate(Vector3.forward, 2);
        }
        if(Input.GetKey(KeyCode.Space)){
            speed = 0.05f;
        }
        else{
            speed = originalSpeed;
        }
       
    }
}
