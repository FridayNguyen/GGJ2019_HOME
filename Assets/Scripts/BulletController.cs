using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    private float death_timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        death_timer += Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);


        if (death_timer > 4F) { Destroy(gameObject); }

    }
}
