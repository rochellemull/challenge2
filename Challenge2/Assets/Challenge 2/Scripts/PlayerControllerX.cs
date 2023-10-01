using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //set the minimum time needed before next dog appears
    private float timeDelay = 1.0f;
    // keeps track of time since button last pressed
    private float timePassed;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if the time passed is more than delay
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timePassed)
        {
            // adds to time to ensure it doesnt spawn too early
            timePassed = Time.time + timeDelay;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
