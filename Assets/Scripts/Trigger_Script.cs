using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Script : MonoBehaviour
{

    public GameObject fence;
    // Start is called before the first frame update
    void Start()
    {
        fence.gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Player"){
            fence.gameObject.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
