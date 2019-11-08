﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
