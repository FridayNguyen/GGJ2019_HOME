using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Brute_Main : MonoBehaviour
{
    // Health variable of brute
    public int health = 5;

    Renderer rend;

    Color myColor;

    void Awake()
    {
        gameObject.GetComponent<Chase>().setHealth(health); //Calling set health var to 10 because it must take more hits
        rend = gameObject.GetComponent<Renderer>();
        myColor = rend.material.color;
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(flicker_delay());
    }

    IEnumerator flicker_delay(){
        //531482
        //rgb(83,20,130)
        //rend.material.color = new Color(83,20,130,1);
        rend.material.SetColor("_Color", new Color(255,0,0)*.05f);
        yield return new WaitForSeconds(.25f);
        rend.material.color = myColor;
        
    }
}
