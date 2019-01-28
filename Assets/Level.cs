using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject level;
    void Start()
    {
        level.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Player"){
            level.gameObject.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
