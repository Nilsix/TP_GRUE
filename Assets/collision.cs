using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter(Collision Collision){
        if(Collision.gameObject.name == "Crochet" && (Collision.transform.position.y> transform.position.y )){
            FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedArticulationBody = Collision.articulationBody;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
    }
}
