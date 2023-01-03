using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool allowedSpawn = true;

    public float nextActionTime = 0.0f;
    public float period = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && allowedSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            allowedSpawn = false;            
        }
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            allowedSpawn = true;
        }
    }    
}
