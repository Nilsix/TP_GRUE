using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvoir : MonoBehaviour
{
    public ArticulationBody moufle;

    private float extensionSpeed = 1f;
    private float maxExtension = 10f;
    private float minExtension = 0f;
    private Vector3 initialMouflePosition;
    private float currentExtension = 0f;
    public float forceMouffle = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        if(moufle != null){
            initialMouflePosition = moufle.transform.localPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N)){
            ExtendMouffle();
        }

        if(Input.GetKey(KeyCode.B)){
            RetractMouffle();
        }
    }

    void ExtendMouffle(){
        if(moufle != null && currentExtension < maxExtension){
            currentExtension += extensionSpeed * Time.deltaTime;
            currentExtension = Mathf.Min(currentExtension,maxExtension);
            UpdateMouflePosition();
        }
    }

    void RetractMouffle(){
        if(moufle != null && currentExtension > minExtension){
            currentExtension -= extensionSpeed * Time.deltaTime;
            currentExtension = Mathf.Max(currentExtension,minExtension);
            UpdateMouflePosition();
        }
    }

    void UpdateMouflePosition(){
        Vector3 newPosition = initialMouflePosition + Vector3.down * currentExtension;
        moufle.transform.localPosition = newPosition; 
    }
}
