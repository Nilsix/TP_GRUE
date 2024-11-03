using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementCrochet : MonoBehaviour
{
    public ArticulationBody crochet;
    public float force = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.LeftControl)){
            crochet.AddRelativeForce(transform.up * -force);
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            crochet.AddRelativeForce(transform.up * force);
        }
    }
}
