﻿using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.LookAt(Camera.main.transform.position, Vector3.up);
    }
}
