using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectorManagerScript : MonoBehaviour {
     public GameObject SectionPrefabMaybe;
     public List<SectionCreator> Sectors;
     public GameManager GM;
     public float ScreenWidth;
     // Use this for initialization
     void Start () {

          for (int i = 0; i<GameManager.Size; i++)
          {
               GameObject sector = Instantiate(SectionPrefabMaybe, transform.position + new Vector3(i * ScreenWidth, 0, 0),
                    Quaternion.identity, transform);
               sector.GetComponent<SectionCreator>().Generate(GM.SectorType[i]);               
          }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
