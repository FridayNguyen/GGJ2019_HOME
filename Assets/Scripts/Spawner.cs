using UnityEngine;

//Should be able to drag this to create a spawn point
//Be able to have a fcn that spawns an enemy

public class Spawner : MonoBehaviour
{
    // public  playerHealth;       // Reference to the player's heatlh.
    public GameObject zombieType;                // The enemy prefab to be spawned.
    public float spawnTime;            // How long between each spawn.
    public Transform spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public int mob_cap;                     // The amount of zombies to be allowed to be spawned from manager
    public int randSpawnCap;                       // the max that should be spawned at a time
    //Meant to enable spawning of a specific enemy type via a fcn.
    public void spawn_point(GameObject zombie, float time, int cap, Transform trans, int spawnQuantity)
    {
        zombieType = zombie;
        spawnTime = time;
        mob_cap = cap;
        spawnPoints = trans;
        randSpawnCap = spawnQuantity;
    }

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime); //wait be fore doing it and 
        // Potentially have the time vary to allow for different rates of spawn.
    }

    void Spawn()
    {
       //spawnPoints = trans;
       int spawn_amount = Random.Range(0, randSpawnCap); //how many enemy to spawn

        if (mob_cap != 0)
        {
            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            for (int enemy_to_spawn = 1; enemy_to_spawn <= spawn_amount; enemy_to_spawn++) {
                Instantiate(zombieType, spawnPoints.position, spawnPoints.rotation);
                mob_cap--;
            }
        }
    }
}