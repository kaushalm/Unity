﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {

    public GameObject [] cars;
    int carNo;
    public float maxPos = 2f;
    public float delayTimer = 1f;
    float timer;
    // Use this for initialization
	void Start () {

        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2f, 2f), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 6);
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }

    }
}
