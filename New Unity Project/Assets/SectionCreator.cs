using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionCreator : MonoBehaviour {
     public const int PrefabsArraySize = 3;
     public GameObject[] prefabs;
     public Transform[] positions;
	// Use this for initialization
	void Start () {
              
     }
	
	// Update is called once per frame
	void Update () {
		
	}

     public void Generate(int index)
     {
          int num = Random.Range(0, positions.Length);
          Instantiate(prefabs[index], positions[num].position,
               transform.rotation, transform);

          List<int> indexes = new List<int>();
          indexes.Add(0); indexes.Add(1); indexes.Add(2);
          indexes.Remove(num);
          Instantiate(prefabs[Random.Range(0, PrefabsArraySize)], positions[indexes[0]].position,
               transform.rotation, transform);
          Instantiate(prefabs[Random.Range(0, PrefabsArraySize)], positions[indexes[1]].position,
               transform.rotation, transform);
     }
}
