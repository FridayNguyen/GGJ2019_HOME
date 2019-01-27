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
    public int phase_two_health = 70;
    public int phase_three_health = 40;
    private Quaternion constant_rotation;

    private Rigidbody rigBody;

    public int rotation_speed;

    private GameObject laser1;
    //private 

    void Start()
    {
        rotation_speed = 20;

        laser1 = gameObject.transform.Find("Laser 1").gameObject;

        //laser_control(false);




    }

    public void get_shot(){
        boss_health--;

    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player"){ Destroy(col.gameObject);} //Dest Player
        if(col.gameObject.name == "bullet-shotgun"){boss_health--; }       //Dest Bullet
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Player"){
            Destroy(col.gameObject); //Alter later with game manager
        }

    }



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*Time.deltaTime*rotation_speed);


        //Standard must be changed for dynamic testing
        if(boss_health < phase_two_health && rotation_speed < 40){
            change_rotation_speed(30);
        }
        else if (boss_health < phase_three_health && rotation_speed < 55){
            change_rotation_speed(40);
        }



    }

    void laser_control(bool set){ //Turns lasers on and off
        laser1.gameObject.SetActive(set);
    }

    public void change_rotation_speed(int new_rotation_speed){
        rotation_speed = new_rotation_speed;
    }
}
