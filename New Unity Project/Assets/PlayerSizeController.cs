using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSizeController : MonoBehaviour {

    public heartBeatController HB; 


	// Use this for initialization
	void Start () {
	

        	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3 (1, HB.getCurrentSize(), 1);
	}
}
