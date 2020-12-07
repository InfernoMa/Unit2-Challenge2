using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float   waitTime  = 1; // Time that the player has to wait to spawn object
    private float   startTime = 0; // Time after start when player can spawn the object again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, after delay, spawn object [Dog]
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > startTime)
        {
            startTime = Time.time + waitTime; // set start time +1 so that the player has to wait to spawnobject when starttime hits zero
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
