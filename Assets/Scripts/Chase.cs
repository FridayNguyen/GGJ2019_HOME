using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Chase : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent nav_agent;

    private GameObject player;
    private int health; //Only able to access through the set method
    void OnCollisionEnter(Collision col){

        if(col.gameObject.name == "Player"){
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Bullet"){
            health--; //This reduces health by one in the main script
            Destroy(col.gameObject);
        }
    }
    void Start()
    {
        nav_agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.Find("Player");
    
    }

    // Update is called once per frame
    void Update()
    {
        
        nav_agent.destination = player.transform.position;
        if(health == 0){
            Destroy(gameObject);
        }
    }


    public void setHealth(int new_health){
        health = new_health; 
    }


}
