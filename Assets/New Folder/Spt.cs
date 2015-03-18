using UnityEngine;
using System.Collections;

public class Spt : MonoBehaviour {
	static public int rahunok;
	/*public GameObject MyObj;
	public GameObject MyObj1;
	public GameObject MyObj2;
	float time=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;
		if (time > 2) {
			int Day= Random.Range(1,4);
			if(Day == 1){
			Instantiate (MyObj, new Vector3 (Random.Range (-10f, 10f), Random.Range (-10f, 10f), 0f), new Quaternion (0f, 0f, 0f, 0f));	
			}
			else if(Day == 2){
				Instantiate (MyObj1,new Vector3(Random.Range (-10, 10f), Random.Range (-10f,10f), 0f), new Quaternion(0f,0f,0f,0f));
				             }
			else { 
					Instantiate (MyObj2,new Vector3(Random.Range (-10f, 10f), Random.Range (-10f,10f), 0f), new Quaternion(0f,0f,0f,0f));
				}  
					
		*\	time=0;
		}
	 }
	}

