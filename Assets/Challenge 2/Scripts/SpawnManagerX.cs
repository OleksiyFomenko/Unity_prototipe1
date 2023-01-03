using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 6.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index, random spawn position and random interval
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int spawnNum = Random.Range(0, ballPrefabs.Length);
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnNum], spawnPos, ballPrefabs[spawnNum].transform.rotation);
    }

}
