using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dasher_Main : MonoBehaviour
{

    Ray targetRay;
    RaycastHit rayHit; 
    Rigidbody rigBod;
    Renderer rend;

    private bool flicker; 
    private bool dashing;
    public int dash_force;
    private Color default_color = new Color(36,36,93);

    Vector3 dash_vector;

    private bool track_time; 
    private bool time_cooldown;
    private float dash_attack_timer;
    private float dash_attack_cooldown;

    public float range;

    private NavMeshAgent NavMeshA;

    // Start is called before the first frame update


    void dash(){
        //rigBod.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;

        dash_vector = dash_force*transform.forward;
        rigBod.AddForce(dash_vector); 

    }

    void dash_flicker(){


    }
    

    void Start()
    {
        gameObject.GetComponent<Chase>().setHealth(1); //Calling set health var 
        NavMeshA = GetComponent<NavMeshAgent>();
        rigBod = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        dashing = false; 
        
    }


    // Update is called once per frame

    void FixedUpdate()
    {

        if(track_time){
            dash_attack_timer += Time.deltaTime;
        }
        dash_attack_cooldown += Time.deltaTime;

        //dash_attack_cooldown += Time.deltaTime;

        //Debug.Log(dash_attack_timer);
        Debug.DrawRay(transform.position,transform.forward*range, Color.red); //Comment out to remove red line

        if(Physics.Raycast(transform.position,transform.forward,range))
        {
            
            Debug.Log("TRIGGGER!");
            track_time = true;
            if (dash_attack_timer < .5f && dash_attack_cooldown > 2f) { 
                NavMeshA.velocity = new Vector3(0,0,0);
                }
            dash_attack_cooldown = 0;
            

            
        }

        
        if(dash_attack_timer > .5f){
            NavMeshA.velocity = dash_force*transform.forward;
            dash_attack_timer = 0;
            Debug.Log("TIMER RESET!");
            track_time = false;


        }



        


        
        



    }



}

    



    

