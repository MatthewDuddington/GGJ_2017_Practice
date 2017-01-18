using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartBeatController : MonoBehaviour {

    public GameManager GM;



    int counter; 
    float current_size = 0.5f; 


    


	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
        current_size = GM.sector_size[counter%10];
        counter++; 
	}

    






    public float getCurrentSize()
    {
        return current_size;
    }
}