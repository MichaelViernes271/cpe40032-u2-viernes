﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }
	
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
		// New spawn time interval
		spawnInterval = Random.Range(3.0f, 5.1f);
		Invoke("SpawnRandomBall", spawnInterval);
		
		int ballType = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballType], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
