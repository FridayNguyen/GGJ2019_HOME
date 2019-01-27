using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Main_Script : MonoBehaviour
{
    
    /*
    Keep Track of:
        - Health
    
    Control:
        - Time of shooting for all other children (Heart, Cannons, Spawners)
        - Rotation
        - Phase Control
        - Position of all other components
        - End Game Screen

    
    Cannon:
        ~ Projectile shooting entity

    Heart
        ~ Laser Shooting Entity
     */
    
    
    
    // Start is called before the first frame update

    public int boss_health = 100;
    private Quaternion constant_rotation;

    private Rigidbody rigBody;

    private Vector3[] shoot_locations = new Vector3[9];

    private GameObject cannon1;
    private GameObject cannon2;

    void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            //shoot_locations[i] = new Vector3()
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player"){ Destroy(col.gameObject);} //Dest Player
        if(col.gameObject.name == "bullet-shotgun"){boss_health--; }       //Dest Bullet
    }



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*Time.deltaTime*20);
    }
}
