﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

     private void OnTriggerEnter(Collider other)
     {
          if (other.gameObject.CompareTag("Pickup"))
          {
               other.gameObject.SetActive(false);              
          }
     }
}
