using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Heart : MonoBehaviour
{

    private Renderer rend;
    private Color myColor;

    Boss_Main_Script boss_script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Awake()
    {
    
        rend = gameObject.GetComponent<Renderer>();
        myColor = rend.material.color;
        boss_script = gameObject.GetComponentInParent<Boss_Main_Script>();
    }

    public void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Bullet"){
            boss_script.get_shot();
            StartCoroutine(flicker_delay());
            Destroy(other.gameObject);
        }
        
    }

IEnumerator flicker_delay(){
        rend.material.SetColor("_Color", new Color(255,0,0)*.05f);
        yield return new WaitForSeconds(.25f);
        rend.material.color = myColor;
        
    }
    void Update()
    {
        
    }
}
