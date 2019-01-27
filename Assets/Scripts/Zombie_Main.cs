using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Main : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponent<Chase>().setHealth(1); //Calling set health var to
    }

}
